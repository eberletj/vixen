﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vixen.Rule;
using VixenApplication.Setup;
using VixenApplication.Setup.ElementTemplates;

namespace VixenApplication
{
	public partial class DisplaySetup : Form
	{
		private SetupElementsTree _setupElementsTree;
		private SetupElementsPreview _setupElementsPreview;

		private SetupPatchingSimple _setupPatchingSimple;
		private SetupPatchingGraphical _setupPatchingGraphical;

		private SetupControllersSimple _setupControllersSimple;

		private ISetupElementsControl _currentElementControl;
		private ISetupPatchingControl _currentPatchingControl;
		private ISetupControllersControl _currentControllersControl;

		private IElementTemplate[] _elementTemplates;
		private IElementSetupHelper[] _elementSetupHelpers;

		public DisplaySetup()
		{
			InitializeComponent();

			Icon = Common.Resources.Properties.Resources.Icon_Vixen3;

			_elementTemplates = Vixen.Services.ApplicationServices.GetAllElementTemplates();
			_elementSetupHelpers = Vixen.Services.ApplicationServices.GetAllElementSetupHelpers();
		}

		private void DisplaySetup_Load(object sender, EventArgs e)
		{
			_setupElementsTree = new SetupElementsTree(_elementTemplates, _elementSetupHelpers);
			_setupElementsTree.Dock = DockStyle.Fill;
			_setupElementsPreview = new SetupElementsPreview();
			_setupElementsPreview.Dock = DockStyle.Fill;

			_setupPatchingSimple = new SetupPatchingSimple();
			_setupPatchingSimple.Dock = DockStyle.Fill;
			_setupPatchingGraphical = new SetupPatchingGraphical();
			_setupPatchingGraphical.Dock = DockStyle.Fill;

			_setupControllersSimple = new SetupControllersSimple();
			_setupControllersSimple.Dock = DockStyle.Fill;

			radioButtonElementTree.Checked = true;
			radioButtonPatchingSimple.Checked = true;
			radioButtonControllersStandard.Checked = true;
		}


		/// <summary>
		/// A collection of all the Element Templates that are available to be used (eg. megatree, pixel grid, normal group, etc.)
		/// TODO: are instances the best option?  Should it be an array of types or something similar?
		/// </summary>
		public IEnumerable<IElementTemplate> ElementTemplates =
			new List<IElementTemplate>
				{
					new Megatree(),
					new PixelGrid(),
					new NumberedGroup(),
				};


		/// <summary>
		/// A collection of all the Element Setup Helpers that are available to be used.
		/// TODO: are instances the best option?  Should it be an array of types or something similar?
		/// </summary>
		public IEnumerable<IElementSetupHelper> ElementSetupHelpers =
			new List<IElementSetupHelper>
				{
				};



		private void activateElementControl(ISetupElementsControl control)
		{
			if (_currentElementControl != null) {
				_currentElementControl.ElementSelectionChanged -=  control_ElementSelectionChanged;
				_currentElementControl.ElementsChanged -= control_ElementsChanged;
			}

			_currentElementControl = control;

			control.ElementSelectionChanged +=  control_ElementSelectionChanged;
			control.ElementsChanged += control_ElementsChanged;

			control.UpdatePatching();

			tableLayoutPanelElementSetup.Controls.Clear();
			tableLayoutPanelElementSetup.Controls.Add(control.SetupElementsControl);
		}

		void control_ElementsChanged(object sender, EventArgs e)
		{
			if (_currentPatchingControl != null) {
				_currentPatchingControl.UpdateElementDetails(_currentElementControl.SelectedElements);
			}
		}

		void control_ElementSelectionChanged(object sender, ElementNodesEventArgs e)
		{
			if (_currentPatchingControl != null) {
				_currentPatchingControl.UpdateElementSelection(e.ElementNodes);
			}
		}



		private void activatePatchingControl(ISetupPatchingControl control)
		{
			if (_currentPatchingControl != null) {
				_currentPatchingControl.FiltersAdded-=  control_FiltersAdded;
				_currentPatchingControl.PatchingUpdated -= control_PatchingUpdated;
			}

			_currentPatchingControl = control;

			control.FiltersAdded += control_FiltersAdded;
			control.PatchingUpdated += control_PatchingUpdated;

			if (_currentControllersControl == null) {
				control.UpdateControllerSelection(new ControllersAndOutputsSet());
			} else {
				control.UpdateControllerSelection(_currentControllersControl.SelectedControllersAndOutputs);				
			}
			if (_currentElementControl == null) {
				control.UpdateElementSelection(Enumerable.Empty<Vixen.Sys.ElementNode>());
			} else {
				control.UpdateElementSelection(_currentElementControl.SelectedElements);				
			}

			tableLayoutPanelPatchingSetup.Controls.Clear();
			tableLayoutPanelPatchingSetup.Controls.Add(control.SetupPatchingControl);
		}

		void control_PatchingUpdated(object sender, EventArgs e)
		{
			if (_currentElementControl != null) {
				_currentElementControl.UpdatePatching();
			}

			if (_currentControllersControl != null) {
				_currentControllersControl.UpdatePatching();
			}
		}

		void control_FiltersAdded(object sender, FiltersEventArgs e)
		{
		}



		private void activateControllersControl(ISetupControllersControl control)
		{
			if (_currentControllersControl != null) {
				_currentControllersControl.ControllerSelectionChanged -=  control_ControllerSelectionChanged;
				_currentControllersControl.ControllersChanged -= control_ControllersChanged;
			}

			_currentControllersControl = control;

			control.ControllerSelectionChanged += control_ControllerSelectionChanged;
			control.ControllersChanged += control_ControllersChanged;

			control.UpdatePatching();

			tableLayoutPanelControllerSetup.Controls.Clear();
			tableLayoutPanelControllerSetup.Controls.Add(control.SetupControllersControl);
		}

		void control_ControllersChanged(object sender, EventArgs e)
		{
			if (_currentPatchingControl != null) {
				_currentPatchingControl.UpdateControllerDetails();
			}
		}

		void control_ControllerSelectionChanged(object sender, ControllerSelectionEventArgs e)
		{
			if (_currentPatchingControl != null) {
				_currentPatchingControl.UpdateControllerSelection(e.ControllersAndOutputs);
			}
		}






		private void radioButtonElementTree_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
				activateElementControl(_setupElementsTree);
		}

		private void radioButtonElementPreview_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
				activateElementControl(_setupElementsPreview);
		}

		private void radioButtonPatchingSimple_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
				activatePatchingControl(_setupPatchingSimple);
		}

		private void radioButtonPatchingGraphical_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
				activatePatchingControl(_setupPatchingGraphical);
		}

		private void radioButtonControllersStandard_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
				activateControllersControl(_setupControllersSimple);
		}


	}
}
