﻿using System;
using System.Collections.Generic;
using Vixen.Interpolator;
using Vixen.Sys;

namespace Vixen.Intent {
	class FloatTransitionIntentState : Dispatchable<FloatTransitionIntentState>, IIntentState<float> {
		private FloatTransitionIntent _intent;
		private FloatInterpolator _interpolator;

		public FloatTransitionIntentState(FloatTransitionIntent intent, TimeSpan intentRelativeTime) {
			_intent = intent;
			RelativeTime = intentRelativeTime;
			_interpolator = new FloatInterpolator();
			FilterStates = new List<IFilterState>();
			SubordinateIntentStates = new List<SubordinateIntentState>();
		}

		public TimeSpan RelativeTime { get; private set; }

		public List<IFilterState> FilterStates { get; private set; }

		public float GetValue() {
			float value;
			_interpolator.Interpolate(RelativeTime, _intent.TimeSpan, _intent.StartValue, _intent.EndValue, out value);
			return SubordinateIntentState.Aggregate(value, SubordinateIntentStates);
		}

		public List<SubordinateIntentState> SubordinateIntentStates { get; private set; }

		public IIntentState Clone() {
			FloatTransitionIntentState newState = new FloatTransitionIntentState(_intent, RelativeTime);
			newState.FilterStates.AddRange(FilterStates);
			newState.SubordinateIntentStates.AddRange(SubordinateIntentStates);
			return newState;
		}
	}
}
