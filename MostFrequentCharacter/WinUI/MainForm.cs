/**
* 9/1/21
* CSC 253
* Adam Lancaster
* Most Frequent Character
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MostFrequentCharacterClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, check input for most frequently used character & display
		/// results.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GetMostFreqCharButton_Click(object sender, EventArgs e)
		{
			OutputLabel.Text = CharOps.MostFrequent(InputTextBox.Text).ToString();
		}

		/// <summary>
		/// on click, clear all fields in prep for next entry.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			InputTextBox.ResetText();
			OutputLabel.ResetText();
		}

		/// <summary>
		/// on click, close program.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
