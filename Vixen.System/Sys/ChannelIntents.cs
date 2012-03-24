﻿using System;
using System.Collections.Generic;
using System.Linq;
using Vixen.Sys.CombinationOperation;

namespace Vixen.Sys {
	public class ChannelIntents : Dictionary<Guid,IntentNode> {
		// For better storytelling.
		public IEnumerable<Guid> ChannelIds {
			get { return Keys; }
		}

		public void AddIntentNodeToChannel(Guid channelId, IntentNode intentNode, ICombinationOperation combinationOperation) {
			if(intentNode == null) return;

			if(!ContainsKey(channelId)) {
				_AddRootIntentNode(channelId, intentNode);
			} else {
				_AddSubordinateIntentNode(channelId, intentNode, combinationOperation);
			}
		}

		public void AddIntentNodesToChannels(ChannelIntents channelIntents, ICombinationOperation combinationOperation) {
			foreach(Guid channelId in channelIntents.ChannelIds) {
				IntentNode intentNode = channelIntents[channelId];
				AddIntentNodeToChannel(channelId, intentNode, combinationOperation);
			}
		}

		private void _AddRootIntentNode(Guid channelId, IntentNode intentNode) {
			this[channelId] = intentNode;
		}

		private void _AddSubordinateIntentNode(Guid channelId, IntentNode intentNode, ICombinationOperation combinationOperation) {
			IntentNode rootNode = _GetRootNode(channelId);
			rootNode.SubordinateIntents.Add(new SubordinateIntent(intentNode, combinationOperation));
		}

		private IntentNode _GetRootNode(Guid channelId) {
			return this[channelId];
		}
	}
}
