﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Resources.Properties;

namespace Common.Controls
{
	public partial class MessageBoxForm : Form
	{
		public MessageBoxForm(string messageBoxData, string messageBoxTitle, bool buttonNoVisible, bool buttonCancelVisible)
		{
			InitializeComponent();
			buttonOk.BackgroundImage = Resources.Properties.Resources.HeadingBackgroundImage;
			buttonNo.BackgroundImage = Resources.Properties.Resources.HeadingBackgroundImage;
			buttonCancel.BackgroundImage = Resources.Properties.Resources.HeadingBackgroundImage;
			labelPrompt.Text = messageBoxData;
			this.Text = messageBoxTitle;
			buttonNo.Visible = buttonNoVisible;
			buttonCancel.Visible = buttonCancelVisible;
			if (!buttonCancelVisible & !buttonNoVisible)
			{
				buttonOk.Location = buttonCancel.Location;
			}
			else
			{
				buttonOk.Text = "YES";
			}
		}

		private void buttonBackground_MouseHover(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.BackgroundImage = Resources.Properties.Resources.HeadingBackgroundImageHover;
		}

		private void buttonBackground_MouseLeave(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.BackgroundImage = Resources.Properties.Resources.HeadingBackgroundImage;
		}
	}
}