﻿/*
 * Copyright © 2010, Denys Vuika
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Windows.Input;

namespace VixenModules.Editor.EffectEditor.Input
{
	/// <summary>
	///Provides a standard set of property editor related commands.
	/// </summary>
	public static class PropertyEditorCommands
	{
		private static readonly Type ThisType = typeof (PropertyEditorCommands);

		private static readonly RoutedUICommand _ShowDialogEditor = new RoutedUICommand("Show Dialog Editor",
			"ShowDialogEditorCommand", ThisType);

		private static readonly RoutedUICommand _AddCollectionItem = new RoutedUICommand("Add Collection Item",
			"AddCollectionItemCommand", ThisType);

		private static readonly RoutedUICommand _RemoveCollectionItem = new RoutedUICommand("Remove Collection Item",
			"RemoveCollectionItemCommand", ThisType);

		private static readonly RoutedUICommand _ShowExtendedEditor = new RoutedUICommand("Show Extended Editor",
			"ShowExtendedEditorCommand", ThisType);

		private static readonly RoutedUICommand _ShowGradientLevelCurveEditor = new RoutedUICommand("Show Gradient Level Curve Editor",
			"ShowGradientLevelCurveEditorCommand", ThisType);

		private static readonly RoutedUICommand _ShowGradientLevelGradientEditor = new RoutedUICommand("Show Gradient Level Gradient Editor",
			"ShowGradientLevelGradientEditorCommand", ThisType);

		/// <summary>
		/// Defines a command to show dialog editor for a property.
		/// </summary>    
		public static RoutedUICommand ShowDialogEditor
		{
			get { return _ShowDialogEditor; }
		}

		/// <summary>
		/// Defines a command to show dialog editor for a GradientLevelPair property.
		/// </summary>    
		public static RoutedUICommand ShowGradientLevelCurveEditor
		{
			get { return _ShowGradientLevelCurveEditor; }
		}

		/// <summary>
		/// Defines a command to show dialog editor for a GradientLevelPair property.
		/// </summary>    
		public static RoutedUICommand ShowGradientLevelGradientEditor
		{
			get { return _ShowGradientLevelGradientEditor; }
		}

		/// <summary>
		/// Defines a command to add a itme to a collection property.
		/// </summary>    
		public static RoutedUICommand AddCollectionItem
		{
			get { return _AddCollectionItem; }
		}

		/// <summary>
		/// Defines a command to add a itme to a collection property.
		/// </summary>    
		public static RoutedUICommand RemoveCollectionItem
		{
			get { return _RemoveCollectionItem; }
		}

		/// <summary>
		/// Defines a command to show extended editor for a property.
		/// </summary>
		public static RoutedUICommand ShowExtendedEditor
		{
			get { return _ShowExtendedEditor; }
		}
	}
}