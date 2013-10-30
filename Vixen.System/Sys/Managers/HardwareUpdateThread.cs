﻿using System;
using System.Diagnostics;
using System.Threading;
using Vixen.Sys.Instrumentation;
using Vixen.Sys.Output;

namespace Vixen.Sys.Managers
{
	internal class HardwareUpdateThread : IDisposable
	{
		private static NLog.Logger Logging = NLog.LogManager.GetCurrentClassLogger();		private Thread _thread;
		private ExecutionState _threadState = ExecutionState.Stopped;
		private EventWaitHandle _finished;
		private AutoResetEvent _updateSignalerSync;
		private ManualResetEvent _pauseSignal;
		private Stopwatch _localTime;

		private MillisecondsValue _sleepTimeActualValue;
		private OutputDeviceRefreshRateValue _refreshRateValue;
		private MillisecondsValue _updateTimeValue;
		private MillisecondsValue _intervalDeltaValue;
		private MillisecondsValue _executionTimeValue;

		private const int STOP_TIMEOUT = 4000; // Four seconds should be plenty of time for a thread to stop.

		public event EventHandler Error;

		public HardwareUpdateThread(IOutputDevice outputDevice)
		{
			OutputDevice = outputDevice;
			_thread = new Thread(_ThreadFunc) {Name = string.Format("{0} update", outputDevice.Name), IsBackground = true};
			_finished = new EventWaitHandle(false, EventResetMode.ManualReset);
			_updateSignalerSync = new AutoResetEvent(false);
			_pauseSignal = new ManualResetEvent(true);
			_localTime = new Stopwatch();
		}

		public IOutputDevice OutputDevice { get; private set; }

		public void Start()
		{
			if (_threadState == ExecutionState.Stopped) {
				_threadState = ExecutionState.Started;
				OutputDevice.Start();
				_finished.Reset();
				_localTime.Start();
				_CreatePerformanceValues();
				_thread.Start();
			}
		}

		public void Stop()
		{
			if (_threadState == ExecutionState.Started) {
				_threadState = ExecutionState.Stopping;
				_updateSignalerSync.Set();
				Resume();
				_localTime.Stop();
				_RemovePerformanceValues();
				OutputDevice.Stop();
			}
		}

		public void Pause()
		{
			OutputDevice.Pause();
			_pauseSignal.Reset();
		}

		public void Resume()
		{
			OutputDevice.Resume();
			_pauseSignal.Set();
		}

		public void WaitForFinish()
		{
			if (!_finished.WaitOne(STOP_TIMEOUT)) {
				// Timed out waiting for a stop.
				//(This will prevent hangs in stopping, due to controller code failing to stop).
				throw new TimeoutException( string.Format("Controller {0} failed to stop in the required amount of time.", OutputDevice.Name));
			}
		}

		private long _lastMs = 0;
		private long _lastMs2 = 0;

		private void _ThreadFunc()
		{
			// Thread main loop
			try {
				IOutputDeviceUpdateSignaler signaler = _CreateOutputDeviceUpdateSignaler();

				while (_threadState != ExecutionState.Stopping) {
					long nowMs = _localTime.ElapsedMilliseconds;
					long dtMs = nowMs - _lastMs;
					_lastMs = nowMs;

					var lastTS = Execution.UpdateState();
					long execMs = _localTime.ElapsedMilliseconds - nowMs;

					_UpdateOutputDevice();
					long outputMs = _localTime.ElapsedMilliseconds - nowMs - execMs;

					// instrumentation counters...
					_intervalDeltaValue.Set(Math.Abs(OutputDevice.UpdateInterval - dtMs));
					_executionTimeValue.Set(_localTime.ElapsedMilliseconds - _lastMs);

					// log stuff after real work is done...

					// prep a sample info string for later...
					string sampinfo = "";
					long sampMs = 0;
					foreach (var name in lastTS.Keys)
					{
						if (!name.Contains("System"))
						{
							sampMs = (long)lastTS[name].TotalMilliseconds;
							sampinfo += String.Format("{0}:{1} ", name, sampMs);
						}
					}

					// our cycle jitter was captured above
					bool jitter = false;
					if (Math.Abs(OutputDevice.UpdateInterval - dtMs) > 10) {
						jitter = true;
						Logging.Debug("hwt jitter:  {0}: nowMs:{1}, dtMs:{2}", OutputDevice.Name, nowMs, dtMs);
					}

					// only worry about state sample jitter if it is running
					long dtMs2 = 0;
					if (sampMs > 0) {
						dtMs2 = sampMs - _lastMs2;
						_lastMs2 = sampMs;
						if (Math.Abs(OutputDevice.UpdateInterval - dtMs2) > 10 && sampMs > 0 && dtMs2 > 0)
						{
							jitter = true;
							Logging.Debug("samp jitter:  {0}: sampMs:{1}, dts:{2}",
											OutputDevice.Name, sampMs, dtMs2);
						}
					}
					// summary output for all threads of jitter...
					// change the false in statuslog to true to get a no-preview output each time through.. 
					bool statuslog = false && (sampMs > 0 && dtMs2 > 0 && !OutputDevice.Name.Contains("Preview"));
					if ( jitter || statuslog) {
							Logging.Debug("{0}: nowMs:{1}, dtMs:{2}, execMs:{3}, outMs:{4}, ts:{5}, dts={6}",
											OutputDevice.Name, nowMs, dtMs, execMs, outputMs, sampinfo, dtMs2);
					}

					// wait for the next go 'round
					_WaitOnSignal(signaler);
					_WaitOnPause();
				}

				_threadState = ExecutionState.Stopped;
				_finished.Set();
			}
			catch (Exception ex) {
				// Do this before calling OnError so that we can be in the stopped state.
				// Otherwise, we'll have a deadlock as the event causes a shutdown which
				// waits for the thread to end.
				_threadState = ExecutionState.Stopped;
				_finished.Set();

				Logging.ErrorException(string.Format("Controller {0} error", OutputDevice.Name), ex);
				OnError();
			}
		}

		private IOutputDeviceUpdateSignaler _CreateOutputDeviceUpdateSignaler()
		{
			IOutputDeviceUpdateSignaler signaler = OutputDevice.UpdateSignaler ?? new IntervalUpdateSignaler();
			signaler.OutputDevice = OutputDevice;
			signaler.UpdateSignal = _updateSignalerSync;

			return signaler;
		}

		private void _UpdateOutputDevice()
		{
			_refreshRateValue.Increment();

			long timeBeforeUpdate = _localTime.ElapsedMilliseconds;

			OutputDevice.Update();

			_updateTimeValue.Set(_localTime.ElapsedMilliseconds - timeBeforeUpdate);
		}

		private void _WaitOnSignal(IOutputDeviceUpdateSignaler signaler)
		{
			long timeBeforeSignal = _localTime.ElapsedMilliseconds;

			signaler.RaiseSignal();
			//_updateSignalerSync.WaitOne();

			long timeAfterSignal = _localTime.ElapsedMilliseconds;
			_sleepTimeActualValue.Set(timeAfterSignal - timeBeforeSignal);
		}

		private void _WaitOnPause()
		{
			_pauseSignal.WaitOne();
		}

		private void _CreatePerformanceValues()
		{
			_refreshRateValue = new OutputDeviceRefreshRateValue(OutputDevice);
			VixenSystem.Instrumentation.AddValue(_refreshRateValue);
			_sleepTimeActualValue = new MillisecondsValue(string.Format("Output device sleep time [{0}]", OutputDevice.Name));
			VixenSystem.Instrumentation.AddValue(_sleepTimeActualValue);
			_intervalDeltaValue = new MillisecondsValue(string.Format("Output device delta time [{0}]", OutputDevice.Name));
			VixenSystem.Instrumentation.AddValue(_intervalDeltaValue);
			_executionTimeValue = new MillisecondsValue(string.Format("Output device system time [{0}]", OutputDevice.Name));
			VixenSystem.Instrumentation.AddValue(_executionTimeValue);
			_updateTimeValue = new MillisecondsValue(string.Format("Output device update time [{0}]", OutputDevice.Name));
			VixenSystem.Instrumentation.AddValue(_updateTimeValue);
		}

		private void _RemovePerformanceValues()
		{
			if (_refreshRateValue != null) {
				VixenSystem.Instrumentation.RemoveValue(_refreshRateValue);
			}
			if (_updateTimeValue != null) {
				VixenSystem.Instrumentation.RemoveValue(_updateTimeValue);
			}
			if (_sleepTimeActualValue != null) {
				VixenSystem.Instrumentation.RemoveValue(_sleepTimeActualValue);
			}
		}

		protected virtual void OnError()
		{
			if (Error != null) {
				Error.Raise(this, EventArgs.Empty);
			}
		}

		public void Dispose()
		{
			_Dispose();
		}

		~HardwareUpdateThread()
		{
			_Dispose();
			GC.SuppressFinalize(this);
		}

		private void _Dispose()
		{
			_finished.Dispose();
			_updateSignalerSync.Dispose();
			_pauseSignal.Dispose();
		}
	}
}