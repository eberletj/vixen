﻿namespace VixenModules.Editor.TimedSequenceEditor
{
	partial class MarkManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();

			}
			if (_audio != null)
			{
				_audio.DetectFrequeniesEnabled = false;
				_audio.FrequencyDetected -= _audio_FrequencyDetected;
				_audio = null;
			}
			if (audioDetectionSettings != null && disposing)
				audioDetectionSettings.Dispose();

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkManager));
			this.groupBoxMarkCollections = new System.Windows.Forms.GroupBox();
			this.buttonExportBeatMarks = new System.Windows.Forms.Button();
			this.buttonImportAudacity = new System.Windows.Forms.Button();
			this.buttonRemoveCollection = new System.Windows.Forms.Button();
			this.buttonAddCollection = new System.Windows.Forms.Button();
			this.listViewMarkCollections = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonOK = new System.Windows.Forms.Button();
			this.groupBoxSelectedMarkCollection = new System.Windows.Forms.GroupBox();
			this.groupBoxDetails = new System.Windows.Forms.GroupBox();
			this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panelColor = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.textBoxCollectionName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxOperations = new System.Windows.Forms.GroupBox();
			this.groupBoxSelectedMarks = new System.Windows.Forms.GroupBox();
			this.buttonIncreaseSelectedMarks = new System.Windows.Forms.Button();
			this.buttonDecreaseSelectedMarks = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTimeIncrement = new System.Windows.Forms.TextBox();
			this.generateGrid = new System.Windows.Forms.Button();
			this.buttonGenerateBeatMarks = new System.Windows.Forms.Button();
			this.buttonCopyAndOffsetMarks = new System.Windows.Forms.Button();
			this.buttonPasteEffectsToMarks = new System.Windows.Forms.Button();
			this.buttonOffsetMarks = new System.Windows.Forms.Button();
			this.buttonGenerateSubmarks = new System.Windows.Forms.Button();
			this.buttonEvenlySpaceMarks = new System.Windows.Forms.Button();
			this.groupBoxMarks = new System.Windows.Forms.GroupBox();
			this.listViewMarks = new System.Windows.Forms.ListView();
			this.Times = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAddOrUpdateMark = new System.Windows.Forms.Button();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.buttonSelectAllMarks = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBoxPlayback = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCreateCollections = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.radioSelected = new System.Windows.Forms.RadioButton();
			this.radioAll = new System.Windows.Forms.RadioButton();
			this.btnAutoDetectionSettings = new System.Windows.Forms.Button();
			this.ChkAutoTapper = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numHighPass = new System.Windows.Forms.NumericUpDown();
			this.numLowPass = new System.Windows.Forms.NumericUpDown();
			this.chkHighPass = new System.Windows.Forms.CheckBox();
			this.chkLowPass = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.trackBarPlayBack = new System.Windows.Forms.TrackBar();
			this.textBoxTimingSpeed = new System.Windows.Forms.TextBox();
			this.labelTapperInstructions = new System.Windows.Forms.Label();
			this.buttonIncreasePlaybackSpeed = new System.Windows.Forms.Button();
			this.textBoxPosition = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panelMarkView = new System.Windows.Forms.Panel();
			this.buttonDecreasePlaySpeed = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.textBoxCurrentMark = new System.Windows.Forms.TextBox();
			this.buttonStop = new System.Windows.Forms.Button();
			this.groupBoxMode = new System.Windows.Forms.GroupBox();
			this.radioButtonPlayback = new System.Windows.Forms.RadioButton();
			this.radioButtonTapper = new System.Windows.Forms.RadioButton();
			this.timerPlayback = new System.Windows.Forms.Timer(this.components);
			this.timerMarkHit = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.groupBoxMarkCollections.SuspendLayout();
			this.groupBoxSelectedMarkCollection.SuspendLayout();
			this.groupBoxDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			this.groupBoxOperations.SuspendLayout();
			this.groupBoxSelectedMarks.SuspendLayout();
			this.groupBoxMarks.SuspendLayout();
			this.groupBoxPlayback.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHighPass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLowPass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarPlayBack)).BeginInit();
			this.groupBoxMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxMarkCollections
			// 
			this.groupBoxMarkCollections.Controls.Add(this.buttonExportBeatMarks);
			this.groupBoxMarkCollections.Controls.Add(this.buttonImportAudacity);
			this.groupBoxMarkCollections.Controls.Add(this.buttonRemoveCollection);
			this.groupBoxMarkCollections.Controls.Add(this.buttonAddCollection);
			this.groupBoxMarkCollections.Controls.Add(this.listViewMarkCollections);
			this.groupBoxMarkCollections.Location = new System.Drawing.Point(18, 18);
			this.groupBoxMarkCollections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxMarkCollections.Name = "groupBoxMarkCollections";
			this.groupBoxMarkCollections.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxMarkCollections.Size = new System.Drawing.Size(357, 505);
			this.groupBoxMarkCollections.TabIndex = 0;
			this.groupBoxMarkCollections.TabStop = false;
			this.groupBoxMarkCollections.Text = "Mark Collections";
			// 
			// buttonExportBeatMarks
			// 
			this.buttonExportBeatMarks.Location = new System.Drawing.Point(9, 449);
			this.buttonExportBeatMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonExportBeatMarks.Name = "buttonExportBeatMarks";
			this.buttonExportBeatMarks.Size = new System.Drawing.Size(339, 35);
			this.buttonExportBeatMarks.TabIndex = 4;
			this.buttonExportBeatMarks.Text = "Export Beat Marks";
			this.buttonExportBeatMarks.UseVisualStyleBackColor = true;
			this.buttonExportBeatMarks.Click += new System.EventHandler(this.buttonExportBeatMarks_Click);
			// 
			// buttonImportAudacity
			// 
			this.buttonImportAudacity.Location = new System.Drawing.Point(9, 405);
			this.buttonImportAudacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonImportAudacity.Name = "buttonImportAudacity";
			this.buttonImportAudacity.Size = new System.Drawing.Size(339, 35);
			this.buttonImportAudacity.TabIndex = 3;
			this.buttonImportAudacity.Text = "Import Beat Marks";
			this.buttonImportAudacity.UseVisualStyleBackColor = true;
			this.buttonImportAudacity.Click += new System.EventHandler(this.buttonImportAudacity_Click);
			// 
			// buttonRemoveCollection
			// 
			this.buttonRemoveCollection.Enabled = false;
			this.buttonRemoveCollection.Location = new System.Drawing.Point(183, 357);
			this.buttonRemoveCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonRemoveCollection.Name = "buttonRemoveCollection";
			this.buttonRemoveCollection.Size = new System.Drawing.Size(165, 38);
			this.buttonRemoveCollection.TabIndex = 2;
			this.buttonRemoveCollection.Text = "Remove Collection";
			this.buttonRemoveCollection.UseVisualStyleBackColor = true;
			this.buttonRemoveCollection.Click += new System.EventHandler(this.buttonRemoveCollection_Click);
			// 
			// buttonAddCollection
			// 
			this.buttonAddCollection.Location = new System.Drawing.Point(9, 357);
			this.buttonAddCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAddCollection.Name = "buttonAddCollection";
			this.buttonAddCollection.Size = new System.Drawing.Size(165, 38);
			this.buttonAddCollection.TabIndex = 1;
			this.buttonAddCollection.Text = "Add Collection";
			this.buttonAddCollection.UseVisualStyleBackColor = true;
			this.buttonAddCollection.Click += new System.EventHandler(this.buttonAddCollection_Click);
			// 
			// listViewMarkCollections
			// 
			this.listViewMarkCollections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader3,
			this.columnHeader2});
			this.listViewMarkCollections.FullRowSelect = true;
			this.listViewMarkCollections.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewMarkCollections.HideSelection = false;
			this.listViewMarkCollections.Location = new System.Drawing.Point(9, 29);
			this.listViewMarkCollections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewMarkCollections.MultiSelect = false;
			this.listViewMarkCollections.Name = "listViewMarkCollections";
			this.listViewMarkCollections.Size = new System.Drawing.Size(337, 316);
			this.listViewMarkCollections.TabIndex = 0;
			this.listViewMarkCollections.UseCompatibleStateImageBehavior = false;
			this.listViewMarkCollections.View = System.Windows.Forms.View.Details;
			this.listViewMarkCollections.SelectedIndexChanged += new System.EventHandler(this.listViewMarkCollections_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 114;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Weight";
			this.columnHeader3.Width = 48;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Marks";
			this.columnHeader2.Width = 43;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(829, 894);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(120, 38);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// groupBoxSelectedMarkCollection
			// 
			this.groupBoxSelectedMarkCollection.Controls.Add(this.groupBoxDetails);
			this.groupBoxSelectedMarkCollection.Controls.Add(this.groupBoxOperations);
			this.groupBoxSelectedMarkCollection.Controls.Add(this.groupBoxMarks);
			this.groupBoxSelectedMarkCollection.Location = new System.Drawing.Point(384, 18);
			this.groupBoxSelectedMarkCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxSelectedMarkCollection.Name = "groupBoxSelectedMarkCollection";
			this.groupBoxSelectedMarkCollection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxSelectedMarkCollection.Size = new System.Drawing.Size(710, 506);
			this.groupBoxSelectedMarkCollection.TabIndex = 1;
			this.groupBoxSelectedMarkCollection.TabStop = false;
			this.groupBoxSelectedMarkCollection.Text = "Selected Collection";
			// 
			// groupBoxDetails
			// 
			this.groupBoxDetails.Controls.Add(this.checkBoxEnabled);
			this.groupBoxDetails.Controls.Add(this.label3);
			this.groupBoxDetails.Controls.Add(this.panelColor);
			this.groupBoxDetails.Controls.Add(this.label2);
			this.groupBoxDetails.Controls.Add(this.numericUpDownWeight);
			this.groupBoxDetails.Controls.Add(this.textBoxCollectionName);
			this.groupBoxDetails.Controls.Add(this.label1);
			this.groupBoxDetails.Location = new System.Drawing.Point(9, 29);
			this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxDetails.Name = "groupBoxDetails";
			this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxDetails.Size = new System.Drawing.Size(231, 235);
			this.groupBoxDetails.TabIndex = 0;
			this.groupBoxDetails.TabStop = false;
			this.groupBoxDetails.Text = "Details";
			// 
			// checkBoxEnabled
			// 
			this.checkBoxEnabled.AutoSize = true;
			this.checkBoxEnabled.Location = new System.Drawing.Point(26, 42);
			this.checkBoxEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxEnabled.Name = "checkBoxEnabled";
			this.checkBoxEnabled.Size = new System.Drawing.Size(94, 24);
			this.checkBoxEnabled.TabIndex = 0;
			this.checkBoxEnabled.Text = "Enabled";
			this.checkBoxEnabled.UseVisualStyleBackColor = true;
			this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 175);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "Color:";
			// 
			// panelColor
			// 
			this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColor.Location = new System.Drawing.Point(87, 168);
			this.panelColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(89, 37);
			this.panelColor.TabIndex = 3;
			this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 131);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Weight:";
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(87, 128);
			this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(69, 26);
			this.numericUpDownWeight.TabIndex = 2;
			this.numericUpDownWeight.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownWeight.ValueChanged += new System.EventHandler(this.numericUpDownWeight_ValueChanged);
			// 
			// textBoxCollectionName
			// 
			this.textBoxCollectionName.Location = new System.Drawing.Point(87, 88);
			this.textBoxCollectionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxCollectionName.Name = "textBoxCollectionName";
			this.textBoxCollectionName.Size = new System.Drawing.Size(128, 26);
			this.textBoxCollectionName.TabIndex = 1;
			this.textBoxCollectionName.TextChanged += new System.EventHandler(this.textBoxCollectionName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 92);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name:";
			// 
			// groupBoxOperations
			// 
			this.groupBoxOperations.Controls.Add(this.groupBoxSelectedMarks);
			this.groupBoxOperations.Controls.Add(this.generateGrid);
			this.groupBoxOperations.Controls.Add(this.buttonGenerateBeatMarks);
			this.groupBoxOperations.Controls.Add(this.buttonCopyAndOffsetMarks);
			this.groupBoxOperations.Controls.Add(this.buttonPasteEffectsToMarks);
			this.groupBoxOperations.Controls.Add(this.buttonOffsetMarks);
			this.groupBoxOperations.Controls.Add(this.buttonGenerateSubmarks);
			this.groupBoxOperations.Controls.Add(this.buttonEvenlySpaceMarks);
			this.groupBoxOperations.Location = new System.Drawing.Point(452, 29);
			this.groupBoxOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxOperations.Name = "groupBoxOperations";
			this.groupBoxOperations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxOperations.Size = new System.Drawing.Size(246, 455);
			this.groupBoxOperations.TabIndex = 2;
			this.groupBoxOperations.TabStop = false;
			this.groupBoxOperations.Text = "Operations";
			// 
			// groupBoxSelectedMarks
			// 
			this.groupBoxSelectedMarks.Controls.Add(this.buttonIncreaseSelectedMarks);
			this.groupBoxSelectedMarks.Controls.Add(this.buttonDecreaseSelectedMarks);
			this.groupBoxSelectedMarks.Controls.Add(this.label7);
			this.groupBoxSelectedMarks.Controls.Add(this.textBoxTimeIncrement);
			this.groupBoxSelectedMarks.Location = new System.Drawing.Point(12, 360);
			this.groupBoxSelectedMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxSelectedMarks.Name = "groupBoxSelectedMarks";
			this.groupBoxSelectedMarks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxSelectedMarks.Size = new System.Drawing.Size(226, 77);
			this.groupBoxSelectedMarks.TabIndex = 7;
			this.groupBoxSelectedMarks.TabStop = false;
			this.groupBoxSelectedMarks.Text = "SelectedMarks";
			// 
			// buttonIncreaseSelectedMarks
			// 
			this.buttonIncreaseSelectedMarks.Location = new System.Drawing.Point(122, 20);
			this.buttonIncreaseSelectedMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonIncreaseSelectedMarks.Name = "buttonIncreaseSelectedMarks";
			this.buttonIncreaseSelectedMarks.Size = new System.Drawing.Size(48, 49);
			this.buttonIncreaseSelectedMarks.TabIndex = 1;
			this.buttonIncreaseSelectedMarks.Text = "+";
			this.buttonIncreaseSelectedMarks.UseVisualStyleBackColor = true;
			this.buttonIncreaseSelectedMarks.Click += new System.EventHandler(this.buttonIncreaseSelectedMarks_Click);
			// 
			// buttonDecreaseSelectedMarks
			// 
			this.buttonDecreaseSelectedMarks.Location = new System.Drawing.Point(174, 20);
			this.buttonDecreaseSelectedMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDecreaseSelectedMarks.Name = "buttonDecreaseSelectedMarks";
			this.buttonDecreaseSelectedMarks.Size = new System.Drawing.Size(48, 49);
			this.buttonDecreaseSelectedMarks.TabIndex = 2;
			this.buttonDecreaseSelectedMarks.Text = "-";
			this.buttonDecreaseSelectedMarks.UseVisualStyleBackColor = true;
			this.buttonDecreaseSelectedMarks.Click += new System.EventHandler(this.buttonDecreaseSelectedMarks_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(88, 49);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "ms";
			// 
			// textBoxTimeIncrement
			// 
			this.textBoxTimeIncrement.Location = new System.Drawing.Point(28, 38);
			this.textBoxTimeIncrement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTimeIncrement.Name = "textBoxTimeIncrement";
			this.textBoxTimeIncrement.Size = new System.Drawing.Size(56, 26);
			this.textBoxTimeIncrement.TabIndex = 0;
			this.textBoxTimeIncrement.Text = "10";
			// 
			// generateGrid
			// 
			this.generateGrid.Location = new System.Drawing.Point(12, 312);
			this.generateGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.generateGrid.Name = "generateGrid";
			this.generateGrid.Size = new System.Drawing.Size(226, 38);
			this.generateGrid.TabIndex = 6;
			this.generateGrid.Text = "Generate Grid";
			this.toolTip1.SetToolTip(this.generateGrid, "Generate a \'grid\' of equally space marks across the sequence.");
			this.generateGrid.UseVisualStyleBackColor = true;
			this.generateGrid.Click += new System.EventHandler(this.buttonGenerateGrid_Click);
			// 
			// buttonGenerateBeatMarks
			// 
			this.buttonGenerateBeatMarks.Location = new System.Drawing.Point(10, 265);
			this.buttonGenerateBeatMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonGenerateBeatMarks.Name = "buttonGenerateBeatMarks";
			this.buttonGenerateBeatMarks.Size = new System.Drawing.Size(226, 38);
			this.buttonGenerateBeatMarks.TabIndex = 5;
			this.buttonGenerateBeatMarks.Text = "Generate beat marks";
			this.toolTip1.SetToolTip(this.buttonGenerateBeatMarks, "Generate more marks based on the frequency of the selected marks.");
			this.buttonGenerateBeatMarks.UseVisualStyleBackColor = true;
			this.buttonGenerateBeatMarks.Click += new System.EventHandler(this.buttonGenerateBeatMarks_Click);
			// 
			// buttonCopyAndOffsetMarks
			// 
			this.buttonCopyAndOffsetMarks.Location = new System.Drawing.Point(10, 217);
			this.buttonCopyAndOffsetMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCopyAndOffsetMarks.Name = "buttonCopyAndOffsetMarks";
			this.buttonCopyAndOffsetMarks.Size = new System.Drawing.Size(226, 38);
			this.buttonCopyAndOffsetMarks.TabIndex = 4;
			this.buttonCopyAndOffsetMarks.Text = "Copy && offset marks";
			this.toolTip1.SetToolTip(this.buttonCopyAndOffsetMarks, "Duplicate the selected marks, offsetting the new ones by a fixed amount of time.");
			this.buttonCopyAndOffsetMarks.UseVisualStyleBackColor = true;
			this.buttonCopyAndOffsetMarks.Click += new System.EventHandler(this.buttonCopyAndOffsetMarks_Click);
			// 
			// buttonPasteEffectsToMarks
			// 
			this.buttonPasteEffectsToMarks.Location = new System.Drawing.Point(10, 172);
			this.buttonPasteEffectsToMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPasteEffectsToMarks.Name = "buttonPasteEffectsToMarks";
			this.buttonPasteEffectsToMarks.Size = new System.Drawing.Size(226, 38);
			this.buttonPasteEffectsToMarks.TabIndex = 3;
			this.buttonPasteEffectsToMarks.Text = "Paste effect to marks";
			this.toolTip1.SetToolTip(this.buttonPasteEffectsToMarks, "Place a copy of the effect currently in the paste buffer to begin at each selecte" +
		"d mark.");
			this.buttonPasteEffectsToMarks.UseVisualStyleBackColor = true;
			this.buttonPasteEffectsToMarks.Click += new System.EventHandler(this.buttonPasteEffectsToMarks_Click);
			// 
			// buttonOffsetMarks
			// 
			this.buttonOffsetMarks.Location = new System.Drawing.Point(10, 29);
			this.buttonOffsetMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOffsetMarks.Name = "buttonOffsetMarks";
			this.buttonOffsetMarks.Size = new System.Drawing.Size(226, 38);
			this.buttonOffsetMarks.TabIndex = 0;
			this.buttonOffsetMarks.Text = "Offset marks";
			this.toolTip1.SetToolTip(this.buttonOffsetMarks, "Adjust selected marks left or right a fixed amount of time.");
			this.buttonOffsetMarks.UseVisualStyleBackColor = true;
			this.buttonOffsetMarks.Click += new System.EventHandler(this.buttonOffsetMarks_Click);
			// 
			// buttonGenerateSubmarks
			// 
			this.buttonGenerateSubmarks.Location = new System.Drawing.Point(10, 125);
			this.buttonGenerateSubmarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonGenerateSubmarks.Name = "buttonGenerateSubmarks";
			this.buttonGenerateSubmarks.Size = new System.Drawing.Size(226, 38);
			this.buttonGenerateSubmarks.TabIndex = 2;
			this.buttonGenerateSubmarks.Text = "Generate submarks";
			this.toolTip1.SetToolTip(this.buttonGenerateSubmarks, "Create new marks by subdividing regions of other marks (select at least 2).");
			this.buttonGenerateSubmarks.UseVisualStyleBackColor = true;
			this.buttonGenerateSubmarks.Click += new System.EventHandler(this.buttonGenerateSubmarks_Click);
			// 
			// buttonEvenlySpaceMarks
			// 
			this.buttonEvenlySpaceMarks.Location = new System.Drawing.Point(10, 77);
			this.buttonEvenlySpaceMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonEvenlySpaceMarks.Name = "buttonEvenlySpaceMarks";
			this.buttonEvenlySpaceMarks.Size = new System.Drawing.Size(226, 38);
			this.buttonEvenlySpaceMarks.TabIndex = 1;
			this.buttonEvenlySpaceMarks.Text = "Evenly space marks";
			this.toolTip1.SetToolTip(this.buttonEvenlySpaceMarks, "Evenly space out the selected marks (choose at least 3 marks).");
			this.buttonEvenlySpaceMarks.UseVisualStyleBackColor = true;
			this.buttonEvenlySpaceMarks.Click += new System.EventHandler(this.buttonEvenlySpaceMarks_Click);
			// 
			// groupBoxMarks
			// 
			this.groupBoxMarks.Controls.Add(this.listViewMarks);
			this.groupBoxMarks.Controls.Add(this.buttonAddOrUpdateMark);
			this.groupBoxMarks.Controls.Add(this.textBoxTime);
			this.groupBoxMarks.Controls.Add(this.buttonSelectAllMarks);
			this.groupBoxMarks.Location = new System.Drawing.Point(249, 29);
			this.groupBoxMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxMarks.Name = "groupBoxMarks";
			this.groupBoxMarks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxMarks.Size = new System.Drawing.Size(194, 455);
			this.groupBoxMarks.TabIndex = 1;
			this.groupBoxMarks.TabStop = false;
			this.groupBoxMarks.Text = "Marks";
			// 
			// listViewMarks
			// 
			this.listViewMarks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.Times});
			this.listViewMarks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewMarks.HideSelection = false;
			this.listViewMarks.Location = new System.Drawing.Point(9, 29);
			this.listViewMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewMarks.Name = "listViewMarks";
			this.listViewMarks.Size = new System.Drawing.Size(172, 310);
			this.listViewMarks.TabIndex = 0;
			this.listViewMarks.UseCompatibleStateImageBehavior = false;
			this.listViewMarks.View = System.Windows.Forms.View.Details;
			this.listViewMarks.SelectedIndexChanged += new System.EventHandler(this.listViewMarks_SelectedIndexChanged);
			this.listViewMarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMarks_KeyDown);
			// 
			// Times
			// 
			this.Times.Width = 90;
			// 
			// buttonAddOrUpdateMark
			// 
			this.buttonAddOrUpdateMark.Location = new System.Drawing.Point(108, 351);
			this.buttonAddOrUpdateMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAddOrUpdateMark.Name = "buttonAddOrUpdateMark";
			this.buttonAddOrUpdateMark.Size = new System.Drawing.Size(75, 38);
			this.buttonAddOrUpdateMark.TabIndex = 2;
			this.buttonAddOrUpdateMark.Text = "Add";
			this.buttonAddOrUpdateMark.UseVisualStyleBackColor = true;
			this.buttonAddOrUpdateMark.Click += new System.EventHandler(this.buttonAddOrUpdateMark_Click);
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(9, 355);
			this.textBoxTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(88, 26);
			this.textBoxTime.TabIndex = 1;
			// 
			// buttonSelectAllMarks
			// 
			this.buttonSelectAllMarks.Location = new System.Drawing.Point(9, 398);
			this.buttonSelectAllMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSelectAllMarks.Name = "buttonSelectAllMarks";
			this.buttonSelectAllMarks.Size = new System.Drawing.Size(174, 38);
			this.buttonSelectAllMarks.TabIndex = 3;
			this.buttonSelectAllMarks.Text = "Select All";
			this.buttonSelectAllMarks.UseVisualStyleBackColor = true;
			this.buttonSelectAllMarks.Click += new System.EventHandler(this.buttonSelectAllMarks_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(959, 894);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(120, 38);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// groupBoxPlayback
			// 
			this.groupBoxPlayback.Controls.Add(this.groupBox2);
			this.groupBoxPlayback.Controls.Add(this.groupBox1);
			this.groupBoxPlayback.Controls.Add(this.label6);
			this.groupBoxPlayback.Controls.Add(this.trackBarPlayBack);
			this.groupBoxPlayback.Controls.Add(this.textBoxTimingSpeed);
			this.groupBoxPlayback.Controls.Add(this.labelTapperInstructions);
			this.groupBoxPlayback.Controls.Add(this.buttonIncreasePlaybackSpeed);
			this.groupBoxPlayback.Controls.Add(this.textBoxPosition);
			this.groupBoxPlayback.Controls.Add(this.label5);
			this.groupBoxPlayback.Controls.Add(this.panelMarkView);
			this.groupBoxPlayback.Controls.Add(this.buttonDecreasePlaySpeed);
			this.groupBoxPlayback.Controls.Add(this.label4);
			this.groupBoxPlayback.Controls.Add(this.buttonPlay);
			this.groupBoxPlayback.Controls.Add(this.textBoxCurrentMark);
			this.groupBoxPlayback.Controls.Add(this.buttonStop);
			this.groupBoxPlayback.Controls.Add(this.groupBoxMode);
			this.groupBoxPlayback.Location = new System.Drawing.Point(18, 532);
			this.groupBoxPlayback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxPlayback.Name = "groupBoxPlayback";
			this.groupBoxPlayback.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxPlayback.Size = new System.Drawing.Size(1076, 352);
			this.groupBoxPlayback.TabIndex = 2;
			this.groupBoxPlayback.TabStop = false;
			this.groupBoxPlayback.Text = "Playback";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCreateCollections);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.radioSelected);
			this.groupBox2.Controls.Add(this.radioAll);
			this.groupBox2.Controls.Add(this.btnAutoDetectionSettings);
			this.groupBox2.Controls.Add(this.ChkAutoTapper);
			this.groupBox2.Location = new System.Drawing.Point(447, 155);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(256, 182);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Automatic Frequency Detection";
			// 
			// btnCreateCollections
			// 
			this.btnCreateCollections.Location = new System.Drawing.Point(135, 137);
			this.btnCreateCollections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCreateCollections.Name = "btnCreateCollections";
			this.btnCreateCollections.Size = new System.Drawing.Size(112, 35);
			this.btnCreateCollections.TabIndex = 4;
			this.btnCreateCollections.Text = "Create";
			this.btnCreateCollections.UseVisualStyleBackColor = true;
			this.btnCreateCollections.Click += new System.EventHandler(this.btnCreateCollections_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 80);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(180, 20);
			this.label9.TabIndex = 22;
			this.label9.Text = "Create Collection(s) For:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 60);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(25, 20);
			this.label8.TabIndex = 18;
			this.label8.Text = "	";
			// 
			// radioSelected
			// 
			this.radioSelected.AutoSize = true;
			this.radioSelected.Location = new System.Drawing.Point(78, 111);
			this.radioSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioSelected.Name = "radioSelected";
			this.radioSelected.Size = new System.Drawing.Size(97, 24);
			this.radioSelected.TabIndex = 3;
			this.radioSelected.Text = "Selected";
			this.radioSelected.UseVisualStyleBackColor = true;
			// 
			// radioAll
			// 
			this.radioAll.AutoSize = true;
			this.radioAll.Checked = true;
			this.radioAll.Location = new System.Drawing.Point(15, 111);
			this.radioAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioAll.Name = "radioAll";
			this.radioAll.Size = new System.Drawing.Size(51, 24);
			this.radioAll.TabIndex = 2;
			this.radioAll.TabStop = true;
			this.radioAll.Text = "All";
			this.radioAll.UseVisualStyleBackColor = true;
			// 
			// btnAutoDetectionSettings
			// 
			this.btnAutoDetectionSettings.Location = new System.Drawing.Point(135, 31);
			this.btnAutoDetectionSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAutoDetectionSettings.Name = "btnAutoDetectionSettings";
			this.btnAutoDetectionSettings.Size = new System.Drawing.Size(112, 35);
			this.btnAutoDetectionSettings.TabIndex = 1;
			this.btnAutoDetectionSettings.Text = "Settings";
			this.btnAutoDetectionSettings.UseVisualStyleBackColor = true;
			this.btnAutoDetectionSettings.Click += new System.EventHandler(this.btnAutoDetectionSettings_Click);
			// 
			// ChkAutoTapper
			// 
			this.ChkAutoTapper.AutoSize = true;
			this.ChkAutoTapper.Location = new System.Drawing.Point(15, 40);
			this.ChkAutoTapper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ChkAutoTapper.Name = "ChkAutoTapper";
			this.ChkAutoTapper.Size = new System.Drawing.Size(94, 24);
			this.ChkAutoTapper.TabIndex = 0;
			this.ChkAutoTapper.Text = "Enabled";
			this.ChkAutoTapper.UseVisualStyleBackColor = true;
			this.ChkAutoTapper.CheckedChanged += new System.EventHandler(this.ChkAutoTapper_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numHighPass);
			this.groupBox1.Controls.Add(this.numLowPass);
			this.groupBox1.Controls.Add(this.chkHighPass);
			this.groupBox1.Controls.Add(this.chkLowPass);
			this.groupBox1.Location = new System.Drawing.Point(712, 155);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(344, 115);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Audio Filter";
			// 
			// numHighPass
			// 
			this.numHighPass.Location = new System.Drawing.Point(142, 69);
			this.numHighPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numHighPass.Maximum = new decimal(new int[] {
			22000,
			0,
			0,
			0});
			this.numHighPass.Minimum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numHighPass.Name = "numHighPass";
			this.numHighPass.Size = new System.Drawing.Size(180, 26);
			this.numHighPass.TabIndex = 3;
			this.numHighPass.Value = new decimal(new int[] {
			5000,
			0,
			0,
			0});
			this.numHighPass.ValueChanged += new System.EventHandler(this.numHighPass_ValueChanged);
			// 
			// numLowPass
			// 
			this.numLowPass.Location = new System.Drawing.Point(142, 29);
			this.numLowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numLowPass.Maximum = new decimal(new int[] {
			22000,
			0,
			0,
			0});
			this.numLowPass.Name = "numLowPass";
			this.numLowPass.Size = new System.Drawing.Size(180, 26);
			this.numLowPass.TabIndex = 1;
			this.numLowPass.Value = new decimal(new int[] {
			5000,
			0,
			0,
			0});
			this.numLowPass.ValueChanged += new System.EventHandler(this.numLowPass_ValueChanged);
			// 
			// chkHighPass
			// 
			this.chkHighPass.AutoSize = true;
			this.chkHighPass.Location = new System.Drawing.Point(22, 71);
			this.chkHighPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkHighPass.Name = "chkHighPass";
			this.chkHighPass.Size = new System.Drawing.Size(107, 24);
			this.chkHighPass.TabIndex = 2;
			this.chkHighPass.Text = "High Pass";
			this.chkHighPass.UseVisualStyleBackColor = true;
			this.chkHighPass.CheckedChanged += new System.EventHandler(this.chkHighPass_CheckedChanged);
			// 
			// chkLowPass
			// 
			this.chkLowPass.AutoSize = true;
			this.chkLowPass.Location = new System.Drawing.Point(22, 29);
			this.chkLowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkLowPass.Name = "chkLowPass";
			this.chkLowPass.Size = new System.Drawing.Size(103, 24);
			this.chkLowPass.TabIndex = 0;
			this.chkLowPass.Text = "Low Pass";
			this.chkLowPass.UseVisualStyleBackColor = true;
			this.chkLowPass.CheckedChanged += new System.EventHandler(this.chkLowPass_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(332, 46);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Timing Speed:";
			// 
			// trackBarPlayBack
			// 
			this.trackBarPlayBack.Location = new System.Drawing.Point(9, 100);
			this.trackBarPlayBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.trackBarPlayBack.Name = "trackBarPlayBack";
			this.trackBarPlayBack.Size = new System.Drawing.Size(1054, 69);
			this.trackBarPlayBack.TabIndex = 2;
			this.trackBarPlayBack.Scroll += new System.EventHandler(this.trackBarPlayBack_Scroll);
			this.trackBarPlayBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarPlayBack_MouseDown);
			this.trackBarPlayBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarPlayBack_MouseUp);
			// 
			// textBoxTimingSpeed
			// 
			this.textBoxTimingSpeed.Location = new System.Drawing.Point(465, 43);
			this.textBoxTimingSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTimingSpeed.Name = "textBoxTimingSpeed";
			this.textBoxTimingSpeed.Size = new System.Drawing.Size(85, 26);
			this.textBoxTimingSpeed.TabIndex = 3;
			// 
			// labelTapperInstructions
			// 
			this.labelTapperInstructions.AutoSize = true;
			this.labelTapperInstructions.Location = new System.Drawing.Point(28, 309);
			this.labelTapperInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTapperInstructions.Name = "labelTapperInstructions";
			this.labelTapperInstructions.Size = new System.Drawing.Size(366, 20);
			this.labelTapperInstructions.TabIndex = 14;
			this.labelTapperInstructions.Text = "Click the box or use the spacebar to create a mark.";
			// 
			// buttonIncreasePlaybackSpeed
			// 
			this.buttonIncreasePlaybackSpeed.Location = new System.Drawing.Point(562, 32);
			this.buttonIncreasePlaybackSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonIncreasePlaybackSpeed.Name = "buttonIncreasePlaybackSpeed";
			this.buttonIncreasePlaybackSpeed.Size = new System.Drawing.Size(48, 49);
			this.buttonIncreasePlaybackSpeed.TabIndex = 4;
			this.buttonIncreasePlaybackSpeed.Text = "+";
			this.buttonIncreasePlaybackSpeed.UseVisualStyleBackColor = true;
			this.buttonIncreasePlaybackSpeed.Click += new System.EventHandler(this.buttonIncreasePlaySpeed_Click);
			// 
			// textBoxPosition
			// 
			this.textBoxPosition.Location = new System.Drawing.Point(896, 43);
			this.textBoxPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPosition.Name = "textBoxPosition";
			this.textBoxPosition.ReadOnly = true;
			this.textBoxPosition.Size = new System.Drawing.Size(132, 26);
			this.textBoxPosition.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(760, 48);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Current Position:";
			// 
			// panelMarkView
			// 
			this.panelMarkView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMarkView.Location = new System.Drawing.Point(165, 178);
			this.panelMarkView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelMarkView.Name = "panelMarkView";
			this.panelMarkView.Size = new System.Drawing.Size(220, 111);
			this.panelMarkView.TabIndex = 8;
			this.panelMarkView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMarkView_MouseDown);
			// 
			// buttonDecreasePlaySpeed
			// 
			this.buttonDecreasePlaySpeed.Location = new System.Drawing.Point(615, 32);
			this.buttonDecreasePlaySpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDecreasePlaySpeed.Name = "buttonDecreasePlaySpeed";
			this.buttonDecreasePlaySpeed.Size = new System.Drawing.Size(48, 49);
			this.buttonDecreasePlaySpeed.TabIndex = 5;
			this.buttonDecreasePlaySpeed.Text = "-";
			this.buttonDecreasePlaySpeed.UseVisualStyleBackColor = true;
			this.buttonDecreasePlaySpeed.Click += new System.EventHandler(this.buttonDecreasePlaySpeed_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(760, 309);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Last Mark Hit:";
			// 
			// buttonPlay
			// 
			this.buttonPlay.Location = new System.Drawing.Point(30, 35);
			this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(48, 49);
			this.buttonPlay.TabIndex = 0;
			this.buttonPlay.Text = "Play";
			this.buttonPlay.UseVisualStyleBackColor = true;
			this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
			// 
			// textBoxCurrentMark
			// 
			this.textBoxCurrentMark.Location = new System.Drawing.Point(879, 305);
			this.textBoxCurrentMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxCurrentMark.Name = "textBoxCurrentMark";
			this.textBoxCurrentMark.ReadOnly = true;
			this.textBoxCurrentMark.Size = new System.Drawing.Size(133, 26);
			this.textBoxCurrentMark.TabIndex = 10;
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(82, 35);
			this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(48, 49);
			this.buttonStop.TabIndex = 1;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// groupBoxMode
			// 
			this.groupBoxMode.Controls.Add(this.radioButtonPlayback);
			this.groupBoxMode.Controls.Add(this.radioButtonTapper);
			this.groupBoxMode.Location = new System.Drawing.Point(24, 165);
			this.groupBoxMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxMode.Name = "groupBoxMode";
			this.groupBoxMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxMode.Size = new System.Drawing.Size(132, 105);
			this.groupBoxMode.TabIndex = 7;
			this.groupBoxMode.TabStop = false;
			this.groupBoxMode.Text = "Mode";
			// 
			// radioButtonPlayback
			// 
			this.radioButtonPlayback.AutoSize = true;
			this.radioButtonPlayback.Checked = true;
			this.radioButtonPlayback.Location = new System.Drawing.Point(9, 29);
			this.radioButtonPlayback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonPlayback.Name = "radioButtonPlayback";
			this.radioButtonPlayback.Size = new System.Drawing.Size(97, 24);
			this.radioButtonPlayback.TabIndex = 1;
			this.radioButtonPlayback.TabStop = true;
			this.radioButtonPlayback.Text = "Playback";
			this.radioButtonPlayback.UseVisualStyleBackColor = true;
			// 
			// radioButtonTapper
			// 
			this.radioButtonTapper.AutoSize = true;
			this.radioButtonTapper.Enabled = false;
			this.radioButtonTapper.Location = new System.Drawing.Point(9, 65);
			this.radioButtonTapper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonTapper.Name = "radioButtonTapper";
			this.radioButtonTapper.Size = new System.Drawing.Size(84, 24);
			this.radioButtonTapper.TabIndex = 0;
			this.radioButtonTapper.Text = "Tapper";
			this.radioButtonTapper.UseVisualStyleBackColor = true;
			this.radioButtonTapper.CheckedChanged += new System.EventHandler(this.radioButtonTapper_CheckedChanged);
			// 
			// timerPlayback
			// 
			this.timerPlayback.Interval = 1;
			this.timerPlayback.Tick += new System.EventHandler(this.timerPlayback_Tick);
			// 
			// timerMarkHit
			// 
			this.timerMarkHit.Interval = 40;
			this.timerMarkHit.Tick += new System.EventHandler(this.timerMarkHit_Tick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// MarkManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 944);
			this.Controls.Add(this.groupBoxPlayback);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxSelectedMarkCollection);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBoxMarkCollections);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1114, 1000);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1114, 1000);
			this.Name = "MarkManager";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mark Collections Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MarkManager_FormClosing);
			this.Load += new System.EventHandler(this.MarkManager_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MarkManager_KeyDown);
			this.groupBoxMarkCollections.ResumeLayout(false);
			this.groupBoxSelectedMarkCollection.ResumeLayout(false);
			this.groupBoxDetails.ResumeLayout(false);
			this.groupBoxDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			this.groupBoxOperations.ResumeLayout(false);
			this.groupBoxSelectedMarks.ResumeLayout(false);
			this.groupBoxSelectedMarks.PerformLayout();
			this.groupBoxMarks.ResumeLayout(false);
			this.groupBoxMarks.PerformLayout();
			this.groupBoxPlayback.ResumeLayout(false);
			this.groupBoxPlayback.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHighPass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLowPass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarPlayBack)).EndInit();
			this.groupBoxMode.ResumeLayout(false);
			this.groupBoxMode.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMarkCollections;
		private System.Windows.Forms.Button buttonRemoveCollection;
		private System.Windows.Forms.Button buttonAddCollection;
		private System.Windows.Forms.ListView listViewMarkCollections;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.GroupBox groupBoxSelectedMarkCollection;
		private System.Windows.Forms.GroupBox groupBoxMarks;
		private System.Windows.Forms.Button buttonSelectAllMarks;
		private System.Windows.Forms.GroupBox groupBoxOperations;
		private System.Windows.Forms.Button buttonAddOrUpdateMark;
		private System.Windows.Forms.TextBox textBoxTime;
		private System.Windows.Forms.Button buttonOffsetMarks;
		private System.Windows.Forms.Button buttonGenerateSubmarks;
		private System.Windows.Forms.Button buttonEvenlySpaceMarks;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ListView listViewMarks;
		private System.Windows.Forms.ColumnHeader Times;
		private System.Windows.Forms.GroupBox groupBoxDetails;
		private System.Windows.Forms.CheckBox checkBoxEnabled;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelColor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.TextBox textBoxCollectionName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPasteEffectsToMarks;
		private System.Windows.Forms.Button buttonCopyAndOffsetMarks;
		private System.Windows.Forms.Button buttonGenerateBeatMarks;
		private System.Windows.Forms.Button generateGrid;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox groupBoxPlayback;
		private System.Windows.Forms.GroupBox groupBoxMode;
		private System.Windows.Forms.RadioButton radioButtonTapper;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTimingSpeed;
		private System.Windows.Forms.Button buttonIncreasePlaybackSpeed;
		private System.Windows.Forms.Button buttonDecreasePlaySpeed;
		private System.Windows.Forms.Panel panelMarkView;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxPosition;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCurrentMark;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.RadioButton radioButtonPlayback;
		private System.Windows.Forms.Timer timerPlayback;
		private System.Windows.Forms.Timer timerMarkHit;
		private System.Windows.Forms.GroupBox groupBoxSelectedMarks;
		private System.Windows.Forms.Button buttonIncreaseSelectedMarks;
		private System.Windows.Forms.Button buttonDecreaseSelectedMarks;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxTimeIncrement;
		private System.Windows.Forms.Label labelTapperInstructions;
		private System.Windows.Forms.TrackBar trackBarPlayBack;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numHighPass;
		private System.Windows.Forms.NumericUpDown numLowPass;
		private System.Windows.Forms.CheckBox chkHighPass;
		private System.Windows.Forms.CheckBox chkLowPass;
		private System.Windows.Forms.CheckBox ChkAutoTapper;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAutoDetectionSettings;
		private System.Windows.Forms.Button btnCreateCollections;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton radioSelected;
		private System.Windows.Forms.RadioButton radioAll;
		private System.Windows.Forms.Button buttonImportAudacity;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonExportBeatMarks;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;

	}
}