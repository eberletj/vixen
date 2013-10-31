﻿using System.Windows.Forms;

namespace VixenApplication.Setup
{
	partial class SetupPatchingSimple
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
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxElements = new System.Windows.Forms.GroupBox();
			this.labelFilterCount = new System.Windows.Forms.Label();
			this.labelElementCount = new System.Windows.Forms.Label();
			this.labelGroupCount = new System.Windows.Forms.Label();
			this.labelItemCount = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelUnconnectedPatchPointCount = new System.Windows.Forms.Label();
			this.labelConnectedPatchPointCount = new System.Windows.Forms.Label();
			this.labelPatchPointCount = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBoxControllers = new System.Windows.Forms.GroupBox();
			this.labelUnpatchedOutputCount = new System.Windows.Forms.Label();
			this.labelPatchedOutputCount = new System.Windows.Forms.Label();
			this.labelOutputCount = new System.Windows.Forms.Label();
			this.labelControllerCount = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBoxPatching = new System.Windows.Forms.GroupBox();
			this.labelPatchWarning = new System.Windows.Forms.Label();
			this.labelPatchSummary = new System.Windows.Forms.Label();
			this.groupBoxOutputOptions = new System.Windows.Forms.GroupBox();
			this.radioButtonAllOutputs = new System.Windows.Forms.RadioButton();
			this.radioButtonUnpatchedOutputsOnly = new System.Windows.Forms.RadioButton();
			this.groupBoxElementOptions = new System.Windows.Forms.GroupBox();
			this.radioButtonAllAvailablePatchPoints = new System.Windows.Forms.RadioButton();
			this.radioButtonUnconnectedPatchPointsOnly = new System.Windows.Forms.RadioButton();
			this.buttonDoPatching = new System.Windows.Forms.Button();
			this.groupBoxElements.SuspendLayout();
			this.groupBoxControllers.SuspendLayout();
			this.groupBoxPatching.SuspendLayout();
			this.groupBoxOutputOptions.SuspendLayout();
			this.groupBoxElementOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxElements
			// 
			this.groupBoxElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBoxElements.Controls.Add(this.labelFilterCount);
			this.groupBoxElements.Controls.Add(this.labelElementCount);
			this.groupBoxElements.Controls.Add(this.labelGroupCount);
			this.groupBoxElements.Controls.Add(this.labelItemCount);
			this.groupBoxElements.Controls.Add(this.label4);
			this.groupBoxElements.Controls.Add(this.label3);
			this.groupBoxElements.Controls.Add(this.label2);
			this.groupBoxElements.Controls.Add(this.label1);
			this.groupBoxElements.Controls.Add(this.labelUnconnectedPatchPointCount);
			this.groupBoxElements.Controls.Add(this.labelConnectedPatchPointCount);
			this.groupBoxElements.Controls.Add(this.labelPatchPointCount);
			this.groupBoxElements.Controls.Add(this.label7);
			this.groupBoxElements.Controls.Add(this.label6);
			this.groupBoxElements.Controls.Add(this.label5);
			this.groupBoxElements.Location = new System.Drawing.Point(3, 3);
			this.groupBoxElements.Name = "groupBoxElements";
			this.groupBoxElements.Size = new System.Drawing.Size(220, 241);
			this.groupBoxElements.TabIndex = 0;
			this.groupBoxElements.TabStop = false;
			this.groupBoxElements.Text = "Selected Elements";
			// 
			// labelFilterCount
			// 
			this.labelFilterCount.AutoSize = true;
			this.labelFilterCount.Location = new System.Drawing.Point(93, 179);
			this.labelFilterCount.Name = "labelFilterCount";
			this.labelFilterCount.Size = new System.Drawing.Size(13, 13);
			this.labelFilterCount.TabIndex = 21;
			this.labelFilterCount.Text = "0";
			// 
			// labelElementCount
			// 
			this.labelElementCount.AutoSize = true;
			this.labelElementCount.Location = new System.Drawing.Point(93, 157);
			this.labelElementCount.Name = "labelElementCount";
			this.labelElementCount.Size = new System.Drawing.Size(13, 13);
			this.labelElementCount.TabIndex = 20;
			this.labelElementCount.Text = "0";
			// 
			// labelGroupCount
			// 
			this.labelGroupCount.AutoSize = true;
			this.labelGroupCount.Location = new System.Drawing.Point(93, 135);
			this.labelGroupCount.Name = "labelGroupCount";
			this.labelGroupCount.Size = new System.Drawing.Size(13, 13);
			this.labelGroupCount.TabIndex = 19;
			this.labelGroupCount.Text = "0";
			// 
			// labelItemCount
			// 
			this.labelItemCount.AutoSize = true;
			this.labelItemCount.Location = new System.Drawing.Point(93, 113);
			this.labelItemCount.Name = "labelItemCount";
			this.labelItemCount.Size = new System.Drawing.Size(13, 13);
			this.labelItemCount.TabIndex = 18;
			this.labelItemCount.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Filters:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Elements:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Groups:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Items:";
			// 
			// labelUnconnectedPatchPointCount
			// 
			this.labelUnconnectedPatchPointCount.AutoSize = true;
			this.labelUnconnectedPatchPointCount.Location = new System.Drawing.Point(137, 75);
			this.labelUnconnectedPatchPointCount.Name = "labelUnconnectedPatchPointCount";
			this.labelUnconnectedPatchPointCount.Size = new System.Drawing.Size(13, 13);
			this.labelUnconnectedPatchPointCount.TabIndex = 13;
			this.labelUnconnectedPatchPointCount.Text = "0";
			// 
			// labelConnectedPatchPointCount
			// 
			this.labelConnectedPatchPointCount.AutoSize = true;
			this.labelConnectedPatchPointCount.Location = new System.Drawing.Point(137, 55);
			this.labelConnectedPatchPointCount.Name = "labelConnectedPatchPointCount";
			this.labelConnectedPatchPointCount.Size = new System.Drawing.Size(13, 13);
			this.labelConnectedPatchPointCount.TabIndex = 12;
			this.labelConnectedPatchPointCount.Text = "0";
			// 
			// labelPatchPointCount
			// 
			this.labelPatchPointCount.AutoSize = true;
			this.labelPatchPointCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPatchPointCount.Location = new System.Drawing.Point(137, 35);
			this.labelPatchPointCount.Name = "labelPatchPointCount";
			this.labelPatchPointCount.Size = new System.Drawing.Size(14, 13);
			this.labelPatchPointCount.TabIndex = 11;
			this.labelPatchPointCount.Text = "0";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Unconnected:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Connected:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Total Patch Points:";
			// 
			// groupBoxControllers
			// 
			this.groupBoxControllers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBoxControllers.Controls.Add(this.labelUnpatchedOutputCount);
			this.groupBoxControllers.Controls.Add(this.labelPatchedOutputCount);
			this.groupBoxControllers.Controls.Add(this.labelOutputCount);
			this.groupBoxControllers.Controls.Add(this.labelControllerCount);
			this.groupBoxControllers.Controls.Add(this.label15);
			this.groupBoxControllers.Controls.Add(this.label16);
			this.groupBoxControllers.Controls.Add(this.label20);
			this.groupBoxControllers.Controls.Add(this.label21);
			this.groupBoxControllers.Location = new System.Drawing.Point(227, 3);
			this.groupBoxControllers.Name = "groupBoxControllers";
			this.groupBoxControllers.Size = new System.Drawing.Size(220, 241);
			this.groupBoxControllers.TabIndex = 1;
			this.groupBoxControllers.TabStop = false;
			this.groupBoxControllers.Text = "Selected Controllers";
			// 
			// labelUnpatchedOutputCount
			// 
			this.labelUnpatchedOutputCount.AutoSize = true;
			this.labelUnpatchedOutputCount.Location = new System.Drawing.Point(116, 75);
			this.labelUnpatchedOutputCount.Name = "labelUnpatchedOutputCount";
			this.labelUnpatchedOutputCount.Size = new System.Drawing.Size(13, 13);
			this.labelUnpatchedOutputCount.TabIndex = 27;
			this.labelUnpatchedOutputCount.Text = "0";
			// 
			// labelPatchedOutputCount
			// 
			this.labelPatchedOutputCount.AutoSize = true;
			this.labelPatchedOutputCount.Location = new System.Drawing.Point(116, 55);
			this.labelPatchedOutputCount.Name = "labelPatchedOutputCount";
			this.labelPatchedOutputCount.Size = new System.Drawing.Size(13, 13);
			this.labelPatchedOutputCount.TabIndex = 26;
			this.labelPatchedOutputCount.Text = "0";
			// 
			// labelOutputCount
			// 
			this.labelOutputCount.AutoSize = true;
			this.labelOutputCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOutputCount.Location = new System.Drawing.Point(116, 35);
			this.labelOutputCount.Name = "labelOutputCount";
			this.labelOutputCount.Size = new System.Drawing.Size(14, 13);
			this.labelOutputCount.TabIndex = 22;
			this.labelOutputCount.Text = "0";
			// 
			// labelControllerCount
			// 
			this.labelControllerCount.AutoSize = true;
			this.labelControllerCount.Location = new System.Drawing.Point(99, 113);
			this.labelControllerCount.Name = "labelControllerCount";
			this.labelControllerCount.Size = new System.Drawing.Size(13, 13);
			this.labelControllerCount.TabIndex = 21;
			this.labelControllerCount.Text = "0";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(40, 75);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(63, 13);
			this.label15.TabIndex = 20;
			this.label15.Text = "Unpatched:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(40, 55);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(50, 13);
			this.label16.TabIndex = 19;
			this.label16.Text = "Patched:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(20, 35);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(55, 13);
			this.label20.TabIndex = 15;
			this.label20.Text = "Outputs:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(20, 113);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(59, 13);
			this.label21.TabIndex = 14;
			this.label21.Text = "Controllers:";
			// 
			// groupBoxPatching
			// 
			this.groupBoxPatching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBoxPatching.Controls.Add(this.labelPatchWarning);
			this.groupBoxPatching.Controls.Add(this.labelPatchSummary);
			this.groupBoxPatching.Controls.Add(this.groupBoxOutputOptions);
			this.groupBoxPatching.Controls.Add(this.groupBoxElementOptions);
			this.groupBoxPatching.Controls.Add(this.buttonDoPatching);
			this.groupBoxPatching.Location = new System.Drawing.Point(3, 250);
			this.groupBoxPatching.Name = "groupBoxPatching";
			this.groupBoxPatching.Size = new System.Drawing.Size(444, 224);
			this.groupBoxPatching.TabIndex = 2;
			this.groupBoxPatching.TabStop = false;
			this.groupBoxPatching.Text = "Patching";
			// 
			// labelPatchWarning
			// 
			this.labelPatchWarning.AutoSize = true;
			this.labelPatchWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
			this.labelPatchWarning.Location = new System.Drawing.Point(14, 127);
			this.labelPatchWarning.Name = "labelPatchWarning";
			this.labelPatchWarning.Size = new System.Drawing.Size(307, 13);
			this.labelPatchWarning.TabIndex = 4;
			this.labelPatchWarning.Text = "Warning: too many selected elements, some will not be patched";
			// 
			// labelPatchSummary
			// 
			this.labelPatchSummary.AutoSize = true;
			this.labelPatchSummary.Location = new System.Drawing.Point(14, 104);
			this.labelPatchSummary.Name = "labelPatchSummary";
			this.labelPatchSummary.Size = new System.Drawing.Size(298, 13);
			this.labelPatchSummary.TabIndex = 3;
			this.labelPatchSummary.Text = "This will patch 9999 element points to 9999 controller outputs.";
			// 
			// groupBoxOutputOptions
			// 
			this.groupBoxOutputOptions.Controls.Add(this.radioButtonAllOutputs);
			this.groupBoxOutputOptions.Controls.Add(this.radioButtonUnpatchedOutputsOnly);
			this.groupBoxOutputOptions.Location = new System.Drawing.Point(224, 14);
			this.groupBoxOutputOptions.Name = "groupBoxOutputOptions";
			this.groupBoxOutputOptions.Size = new System.Drawing.Size(214, 75);
			this.groupBoxOutputOptions.TabIndex = 2;
			this.groupBoxOutputOptions.TabStop = false;
			// 
			// radioButtonAllOutputs
			// 
			this.radioButtonAllOutputs.AutoSize = true;
			this.radioButtonAllOutputs.Location = new System.Drawing.Point(8, 42);
			this.radioButtonAllOutputs.Name = "radioButtonAllOutputs";
			this.radioButtonAllOutputs.Size = new System.Drawing.Size(184, 17);
			this.radioButtonAllOutputs.TabIndex = 3;
			this.radioButtonAllOutputs.Text = "Use all selected controller outputs";
			this.radioButtonAllOutputs.UseVisualStyleBackColor = true;
			this.radioButtonAllOutputs.CheckedChanged += new System.EventHandler(this.radioButtonPatching_CheckedChanged);
			// 
			// radioButtonUnpatchedOutputsOnly
			// 
			this.radioButtonUnpatchedOutputsOnly.AutoSize = true;
			this.radioButtonUnpatchedOutputsOnly.Checked = true;
			this.radioButtonUnpatchedOutputsOnly.Location = new System.Drawing.Point(8, 19);
			this.radioButtonUnpatchedOutputsOnly.Name = "radioButtonUnpatchedOutputsOnly";
			this.radioButtonUnpatchedOutputsOnly.Size = new System.Drawing.Size(158, 17);
			this.radioButtonUnpatchedOutputsOnly.TabIndex = 2;
			this.radioButtonUnpatchedOutputsOnly.TabStop = true;
			this.radioButtonUnpatchedOutputsOnly.Text = "Only use unpatched outputs";
			this.radioButtonUnpatchedOutputsOnly.UseVisualStyleBackColor = true;
			this.radioButtonUnpatchedOutputsOnly.CheckedChanged += new System.EventHandler(this.radioButtonPatching_CheckedChanged);
			// 
			// groupBoxElementOptions
			// 
			this.groupBoxElementOptions.Controls.Add(this.radioButtonAllAvailablePatchPoints);
			this.groupBoxElementOptions.Controls.Add(this.radioButtonUnconnectedPatchPointsOnly);
			this.groupBoxElementOptions.Location = new System.Drawing.Point(6, 14);
			this.groupBoxElementOptions.Name = "groupBoxElementOptions";
			this.groupBoxElementOptions.Size = new System.Drawing.Size(214, 75);
			this.groupBoxElementOptions.TabIndex = 1;
			this.groupBoxElementOptions.TabStop = false;
			// 
			// radioButtonAllAvailablePatchPoints
			// 
			this.radioButtonAllAvailablePatchPoints.AutoSize = true;
			this.radioButtonAllAvailablePatchPoints.Location = new System.Drawing.Point(8, 42);
			this.radioButtonAllAvailablePatchPoints.Name = "radioButtonAllAvailablePatchPoints";
			this.radioButtonAllAvailablePatchPoints.Size = new System.Drawing.Size(163, 17);
			this.radioButtonAllAvailablePatchPoints.TabIndex = 1;
			this.radioButtonAllAvailablePatchPoints.Text = "Use all available patch points";
			this.radioButtonAllAvailablePatchPoints.UseVisualStyleBackColor = true;
			this.radioButtonAllAvailablePatchPoints.CheckedChanged += new System.EventHandler(this.radioButtonPatching_CheckedChanged);
			// 
			// radioButtonUnconnectedPatchPointsOnly
			// 
			this.radioButtonUnconnectedPatchPointsOnly.AutoSize = true;
			this.radioButtonUnconnectedPatchPointsOnly.Checked = true;
			this.radioButtonUnconnectedPatchPointsOnly.Location = new System.Drawing.Point(8, 19);
			this.radioButtonUnconnectedPatchPointsOnly.Name = "radioButtonUnconnectedPatchPointsOnly";
			this.radioButtonUnconnectedPatchPointsOnly.Size = new System.Drawing.Size(193, 17);
			this.radioButtonUnconnectedPatchPointsOnly.TabIndex = 0;
			this.radioButtonUnconnectedPatchPointsOnly.TabStop = true;
			this.radioButtonUnconnectedPatchPointsOnly.Text = "Use unconnected patch points only";
			this.radioButtonUnconnectedPatchPointsOnly.UseVisualStyleBackColor = true;
			this.radioButtonUnconnectedPatchPointsOnly.CheckedChanged += new System.EventHandler(this.radioButtonPatching_CheckedChanged);
			// 
			// buttonDoPatching
			// 
			this.buttonDoPatching.Location = new System.Drawing.Point(161, 160);
			this.buttonDoPatching.Name = "buttonDoPatching";
			this.buttonDoPatching.Size = new System.Drawing.Size(125, 40);
			this.buttonDoPatching.TabIndex = 0;
			this.buttonDoPatching.Text = "Patch Elements to Controllers";
			this.buttonDoPatching.UseVisualStyleBackColor = true;
			this.buttonDoPatching.Click += new System.EventHandler(this.buttonDoPatching_Click);
			// 
			// SetupPatchingSimple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxPatching);
			this.Controls.Add(this.groupBoxControllers);
			this.Controls.Add(this.groupBoxElements);
			this.DoubleBuffered = true;
			this.Name = "SetupPatchingSimple";
			this.Size = new System.Drawing.Size(450, 550);
			this.Load += new System.EventHandler(this.SetupPatchingSimple_Load);
			this.groupBoxElements.ResumeLayout(false);
			this.groupBoxElements.PerformLayout();
			this.groupBoxControllers.ResumeLayout(false);
			this.groupBoxControllers.PerformLayout();
			this.groupBoxPatching.ResumeLayout(false);
			this.groupBoxPatching.PerformLayout();
			this.groupBoxOutputOptions.ResumeLayout(false);
			this.groupBoxOutputOptions.PerformLayout();
			this.groupBoxElementOptions.ResumeLayout(false);
			this.groupBoxElementOptions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBoxElements;
		private Label labelUnconnectedPatchPointCount;
		private Label labelConnectedPatchPointCount;
		private Label labelPatchPointCount;
		private Label label7;
		private Label label6;
		private Label label5;
		private GroupBox groupBoxControllers;
		private Label labelUnpatchedOutputCount;
		private Label labelPatchedOutputCount;
		private Label labelOutputCount;
		private Label labelControllerCount;
		private Label label15;
		private Label label16;
		private Label label20;
		private Label label21;
		private GroupBox groupBoxPatching;
		private Label labelFilterCount;
		private Label labelElementCount;
		private Label labelGroupCount;
		private Label labelItemCount;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button buttonDoPatching;
		private GroupBox groupBoxOutputOptions;
		private RadioButton radioButtonAllOutputs;
		private RadioButton radioButtonUnpatchedOutputsOnly;
		private GroupBox groupBoxElementOptions;
		private RadioButton radioButtonAllAvailablePatchPoints;
		private RadioButton radioButtonUnconnectedPatchPointsOnly;
		private Label labelPatchWarning;
		private Label labelPatchSummary;
	}
}
