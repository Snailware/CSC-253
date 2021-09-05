/**
* 9/5/21
* CSC 253
* Adam Lancaster
* Word Counter
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
using WordCounterClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, count number of word entered into input text box &
		/// display results in output label.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CountButton_Click(object sender, EventArgs e)
		{
			OutputLabel.Text = Counter.CountWords(InputTextBox.Text).ToString();
		}

		/// <summary>
		/// on click, clear input text box and reset output label in prep for 
		/// next entry. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			InputTextBox.Clear();
			OutputLabel.ResetText();
		}

		/// <summary>
		/// on click, close program.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
