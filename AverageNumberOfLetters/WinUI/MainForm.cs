/**
* 9/5/21
* CSC 253
* Adam Lancaster
* Average Number of Letters
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
using AverageNumberOfLettersClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, count number of words entered in tex box, and average
		/// number of letters per word.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CountButton_Click(object sender, EventArgs e)
		{
			OutputWordCountLabel.Text = StringOps.CountWords(InputTextBox.Text).ToString();
			OutputAverageLettersLabel.Text = StringOps.AverageLetters().ToString();
		}

		/// <summary>
		/// on click, clear/reset all fields. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			InputTextBox.Clear();
			OutputWordCountLabel.ResetText();
			OutputAverageLettersLabel.ResetText();
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
