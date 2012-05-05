﻿using System;
using System.Collections.Generic;
using System.Linq;
using Vixen.Module.Controller;
using Vixen.Module.PostFilter;
using Vixen.Commands;

namespace Vixen.Sys.Output {
	//public class OutputController : OutputDeviceBase, IEnumerable<OutputController> {
	public class OutputController : ModuleBasedController<IControllerModuleInstance, CommandOutput>, IEnumerable<OutputController> {
		//private Guid _moduleId;
		//private IControllerModuleInstance _module;
		//private ModuleLocalDataSet _dataSet = new ModuleLocalDataSet();
		////private List<Output> _outputs = new List<Output>();
		////private Output[] _outputArray = new Output[0];
		////private HashSet<IOutputSourceCollection> _sourceCollections;
		//private OutputCollection<CommandOutput> _outputs; 

		public OutputController(string name, int outputCount, Guid moduleId)
			: this(Guid.NewGuid(), name, outputCount, moduleId) {
		}

		public OutputController(Guid id, string name, int outputCount, Guid moduleId)
			: base(id, name, outputCount, moduleId) {
			//: base(id, name) {
			//_outputs = new OutputCollection<CommandOutput>(Id);
			//ModuleId = moduleId;
			//OutputCount = outputCount;
		}

		protected override IControllerModuleInstance GetControllerModule(Guid moduleId) {
			IControllerModuleInstance module = Modules.ModuleManagement.GetController(moduleId);
			ResetDataPolicy(module);
			return module;
		}

		//override protected void _Start() {
		//    if(Module != null) {
		//        Module.Start();
		//    }
		//}

		//override protected void _Stop() {
		//    if(Module != null) {
		//        Module.Stop();
		//    }
		//}

		//protected override void _Pause() {
		//    if(Module != null) {
		//        Module.Pause();
		//    }
		//}

		//protected override void _Resume() {
		//    if(Module != null) {
		//        Module.Resume();
		//    }
		//}

		//// Must be a property for data binding.
		//public Guid ModuleId {
		//    get { return _moduleId; }
		//    set {
		//        _moduleId = value;
		//        _module = null;
		//    }
		//}

		//public IControllerModuleInstance Module {
		//    get {
		//        if(_module == null) {
		//            _module = Modules.ModuleManagement.GetController(_moduleId);

		//            if(_module != null) {
		//                _SetOutputModuleOutputCount();
		//                _SetModuleData();
		//                ResetUpdateInterval();
		//                ResetDataPolicy();
		//            }
		//        }
		//        return _module;
		//    }
		//}

		public IDataPolicy DataPolicy { get; set; }

		//private void _SetOutputModuleOutputCount() {
		//    if(_module != null && OutputCount != 0) {
		//        _module.OutputCount = OutputCount;
		//    }
		//}

		//private void _SetModuleData() {
		//    if(_module != null && ModuleDataSet != null) {
		//        ModuleDataSet.AssignModuleTypeData(_module);
		//    }
		//}

		//public ModuleLocalDataSet ModuleDataSet {
		//    get { return _dataSet; }
		//    set {
		//        _dataSet = value;
		//        _SetModuleData();
		//    }
		//}

		override protected void _UpdateState() {
			if(VixenSystem.ControllerLinking.IsRootController(this) && _ControllerChainOutputModule != null) {
				//lock(_outputs) {
				BeginOutputChange();
				try {
					foreach(OutputController controller in this) {
						//controller._outputs.UpdateState(x => x.Command = _GenerateOutputCommand(x));
						controller.UpdateOutputStates(x => x.Command = _GenerateOutputCommand(x));

						//// All outputs for a controller update in parallel.
						//// ForAll doesn't collate the results, a slight optimization since
						//// we don't care about the order they complete in.
						//controller._outputs.AsParallel().ForAll(x =>
						////Parallel.ForEach(controller._outputs, x =>
						//    {
						//        x.UpdateState();
						//        x.Command = _GenerateOutputCommand(x);
						//    });
					}

					// Latch out the new state.
					// This must be done in order of the chain links so that data
					// goes out the port in the correct order.
					foreach(OutputController controller in this) {
						// A single port may be used to service multiple physical controllers,
						// such as daisy-chained Renard controllers.  Tell the module where
						// it is in that chain.
						controller._ControllerChainOutputModule.ChainIndex = VixenSystem.ControllerLinking.GetChainIndex(controller.Id);

						//ICommand[] outputStates = controller._outputs.Select(x => x.Command).ToArray();
						ICommand[] outputStates = controller.ExtractFromOutputs(x => x.Command).ToArray();
						controller._ControllerChainOutputModule.UpdateState(outputStates);
					}
				} finally {
					EndOutputChange();
				}
			}
		}

		//public CommandOutput[] Outputs {
		//    //get { return _outputArray; }
		//    get { return _outputs.AsArray; }
		//}

		//public int OutputCount {
		//    get { return _outputs.Count; }
		//    set {
		//        _outputs.Count = value;
		//        //// Adjust the outputs list.
		//        //lock(_outputs) {
		//        //    if(value < _outputs.Count) {
		//        //        _outputs.RemoveRange(value, _outputs.Count - value);
		//        //    } else {
		//        //        while(_outputs.Count < value) {
		//        //            // Create a new output.
		//        //            Output output = new Output();
		//        //            _outputs.Add(output);
		//        //        }
		//        //    }
		//        //}

		//        //_outputArray = _outputs.ToArray();

		//        _SetOutputModuleOutputCount();
		//    }
		//}

		private IControllerModuleInstance _ControllerChainOutputModule {
			get {
				// When output controllers are linked, only the root controller will be
				// connected to the port, therefore only it will have the output module
				// used during execution.
				OutputController priorController = VixenSystem.Controllers.GetPrior(this);
				return (priorController != null) ? priorController._ControllerChainOutputModule : Module;
			}
		}

		//override public bool HasSetup {
		//    get { return _module.HasSetup; }
		//}

		///// <summary>
		///// Runs the controller setup.
		///// </summary>
		///// <returns>True if the setup was successful and committed.  False if the user canceled.</returns>
		//override public bool Setup() {
		//    if(_module != null) {
		//        if(_module.Setup()) {
		//            return true;
		//        }
		//    }
		//    return false;
		//}

		//public void AddSources(IOutputSourceCollection sources) {
		//    _outputs.AddSources(sources);
		//    //if(_sourceCollections.Add(sourceCollection)) {
		//    //    ReloadSources();
		//    //}
		//}

		//public void RemoveSources(IOutputSourceCollection sources) {
		//    _outputs.RemoveSources(sources);
		//    //if(sources != null) {
		//    //    if(_sourceCollections.Remove(sources)) {
		//    //        ReloadSources();
		//    //    }
		//    //}
		//}

		//public void ReloadSources() {
		//    _outputs.ReloadSources();
		//    //for(int i=0; i<OutputCount; i++) {
		//    //    ReloadOutputSources(i);
		//    //}
		//}

		//public void ReloadOutputSources(int outputIndex) {
		//    _outputs.ReloadOutputSources(outputIndex);
		//    //if(outputIndex < OutputCount) {
		//    //    Output output = _outputs[outputIndex];
		//    //    IEnumerable<IOutputStateSource> outputSources = _GetAllOutputSources(outputIndex);
		//    //    output.ClearSources();
		//    //    output.AddSources(outputSources);
		//    //}
		//}

		////private IEnumerable<IOutputStateSource> _GetAllOutputSources(int outputIndex) {
		////    if(outputIndex < OutputCount) {
		////        return _sourceCollections.SelectMany(x => x.GetOutputSources(Id, outputIndex));
		////    }
		////    return Enumerable.Empty<IOutputStateSource>();
		////}



		////public void AddSource(IOutputStateSource source, int outputIndex) {
		////    if(source != null && outputIndex < OutputCount) {
		////        _outputs[outputIndex].AddSource(source);
		////    }
		////}

		////public void RemoveSource(IOutputStateSource source, int outputIndex) {
		////    if(source != null && outputIndex < OutputCount) {
		////        _outputs[outputIndex].RemoveSource(source);
		////    }
		////}

		//public void ClearSources(int outputIndex) {
		//    _outputs.ClearSources(outputIndex);
		//    //if(outputIndex < OutputCount) {
		//    //    _outputs[outputIndex].ClearSources();
		//    //}
		//}

		public void AddPostFilter(int outputIndex, IPostFilterModuleInstance filter) {
			if(filter != null && outputIndex < OutputCount) {
				// Must be the controller store, and not the system store, because the system store
				// deals only with static data and there may be multiple instances of a type of filter.
				ModuleDataSet.AssignModuleInstanceData(filter);
				Outputs[outputIndex].AddPostFilter(filter);
			}
		}

		public void InsertPostFilter(int outputIndex, int index, IPostFilterModuleInstance filter) {
			if(filter != null && outputIndex < OutputCount) {
				ModuleDataSet.AssignModuleInstanceData(filter);
				Outputs[outputIndex].InsertPostFilter(index, filter);
			}
		}

		public void RemovePostFilter(int outputIndex, IPostFilterModuleInstance filter) {
			if(filter != null && outputIndex < OutputCount) {
				ModuleDataSet.RemoveModuleInstanceData(filter);
				Outputs[outputIndex].RemovePostFilter(filter);
			}
		}

		public void ClearPostFilters(int outputIndex) {
			if(outputIndex < OutputCount) {
				foreach(IPostFilterModuleInstance filter in Outputs[outputIndex].GetAllPostFilters().ToArray()) {
					RemovePostFilter(outputIndex, filter);
				}
			}
		}

		//override public bool IsRunning {
		//    get { return _module != null && _module.IsRunning; }
		//}

		//public override bool IsPaused {
		//    get { return _module != null && _module.IsPaused; }
		//}

		//public void ResetUpdateInterval() {
		//    if(Module != null) {
		//        UpdateInterval = Module.UpdateInterval;
		//    }
		//}

		public void ResetDataPolicy(IControllerModuleInstance module) {
			if(module != null) {
				DataPolicy = module.DataPolicy;
			}
		}

		private ICommand _GenerateOutputCommand(CommandOutput output) {
			IDataPolicy effectiveDataPolicy = _GetOutputEffectiveDataPolicy(output);
			return effectiveDataPolicy.GenerateCommand(output.State);
		}

		private IDataPolicy _GetOutputEffectiveDataPolicy(CommandOutput output) {
			return output.DataPolicy ?? DataPolicy;
		}

		//public override string ToString() {
		//    return Name;
		//}

		#region IEnumerable<OutputController>
		public IEnumerator<OutputController> GetEnumerator() {
			if(VixenSystem.ControllerLinking.IsRootController(this)) {
				return new ChainEnumerator(this);
			}
			return Enumerable.Empty<OutputController>().GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}
		#endregion

		//#region class Output
		//public class Output : IHasPostFilters, IHasOutputSources {
		//    private HashSet<IOutputStateSource> _sources;
		//    private PostFilterCollection _postFilters;
		//    private OutputIntentStateList _state;

		//    public Output() {
		//        Name = "Unnamed";
		//        _postFilters = new PostFilterCollection();
		//        _sources = new HashSet<IOutputStateSource>();
		//    }

		//    private ICommand _command;

		//    public ICommand Command {
		//        get { return _command; }
		//        set {
		//            if(_command != value) {
		//                _command = value;
		//                _FilterState();
		//            }
		//        }
		//    }

		//    // Completely independent; nothing is current dependent upon this value.
		//    public string Name { get; set; }

		//    public void AddSources(IEnumerable<IOutputStateSource> sources) {
		//        foreach(IOutputStateSource source in sources) {
		//            AddSource(source);
		//        }
		//    }

		//    public void AddSource(IOutputStateSource source) {
		//        _sources.Add(source);
		//    }

		//    public void RemoveSources(IEnumerable<IOutputStateSource> sources) {
		//        foreach(IOutputStateSource source in sources) {
		//            _sources.Remove(source);
		//        }
		//    }

		//    public void RemoveSource(IOutputStateSource source) {
		//        _sources.Remove(source);
		//    }

		//    public void ClearSources() {
		//        _sources.Clear();
		//    }

		//    public void AddPostFilter(IPostFilterModuleInstance filter) {
		//        _postFilters.Add(filter);
		//    }

		//    public void InsertPostFilter(int index, IPostFilterModuleInstance filter) {
		//        _postFilters.Insert(index, filter);
		//    }

		//    public void RemovePostFilter(IPostFilterModuleInstance filter) {
		//        _postFilters.Remove(filter);
		//    }

		//    public void ClearPostFilters() {
		//        _postFilters.Clear();
		//    }

		//    public PostFilterCollection PostFilters {
		//        get { return _postFilters; }
		//    }

		//    public void UpdateState() {
		//        _state = _GetOutputStateData();
		//    }

		//    private OutputIntentStateList _GetOutputStateData() {
		//        IEnumerable<IIntentState> intentStates = _sources.SelectMany(_GetSourceData).NotNull();
		//        IIntentState[] states = intentStates.ToArray();
		//        return new OutputIntentStateList(states);
		//    }

		//    private IIntentStateList _GetSourceData(IOutputStateSource source) {
		//        return source.State;
		//    }

		//    private void _FilterState() {
		//        if(VixenSystem.AllowFilterEvaluation && Command != null) {
		//            foreach(IPostFilterModuleInstance postFilter in PostFilters) {
		//                _command = postFilter.Affect(_command);
		//                if(_command == null) return;
		//            }
		//        }
		//    }

		//    public IIntentStateList State {
		//        get { return _state; }
		//    }

		//    //*** Not yet any way to set this for an output.
		//    //    It is intended to allow an output to override the controller's data policy.
		//    public OutputDataPolicy DataPolicy { get; set; }

		//}
		//#endregion

		#region class ChainEnumerator
		class ChainEnumerator : IEnumerator<OutputController> {
			private OutputController _root;
			private OutputController _current;
			private OutputController _next;

			public ChainEnumerator(OutputController root) {
				_root = root;
				Reset();
			}

			public OutputController Current {
				get { return _current; }
			}

			public void Dispose() { }

			object System.Collections.IEnumerator.Current {
				get { return _current; }
			}

			public bool MoveNext() {
				if(_next != null) {
					_current = _next;
					//_next = _current.Next;
					_next = VixenSystem.Controllers.GetNext(_current);
					return true;
				}
				return false;
			}

			public void Reset() {
				_current = null;
				_next = _root;
			}
		}
		#endregion
	}
}
