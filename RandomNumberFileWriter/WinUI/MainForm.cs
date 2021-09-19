/**
* 9/19/21
* CSC 253
* Adam Lancaster
* Random Number File Writer
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
using RandomNumberFileWriterClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, increase amount of numbers to write to file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IncreaseNumberButton_Click(object sender, EventArgs e)
		{
			if (DataModel.NumberCount < int.MaxValue)
			{
				DataModel.NumberCount++;
			}
			// increment number if below limit.
			else
			{
				MessageBox.Show("Cannot write any more numbers!");
			}
			// alert user that limit is reached. 

			OutputNumberLabel.Text = DataModel.NumberCount.ToString();
			// update label.
		}

		/// <summary>
		/// on click, decrease amount of numbers to write to file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecreaseNumberButton_Click(object sender, EventArgs e)
		{
			if (DataModel.NumberCount > 1)
			{
				DataModel.NumberCount--;
			}
			// decrement number if above 1.
			else
			{
				MessageBox.Show("Must write atleast 1 number!");
			}
			// alert user that they must write atleast 1 number.

			OutputNumberLabel.Text = DataModel.NumberCount.ToString();
			// update label.
		}

		/// <summary>
		/// on click, display save dialog window and store results.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FileButton_Click(object sender, EventArgs e)
		{
			SaveFile.ShowDialog();
			// show save dialog box.

			OutputFilePathLabel.Text = SaveFile.FileName;
			// update file path label.

			DataModel.FilePath = SaveFile.FileName;
			// store path in data model.
		}

		/// <summary>
		/// on click, write desired amount of random numbers to file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (DataModel.FilePath != "")
			{
				FileOps.WriteRandomNumbers(DataModel.NumberCount, DataModel.FilePath);
			}
			// write numbers to file if path isnt blank.
			else
			{
				MessageBox.Show("Select [File] to enter a file path first!");
			}
			// prompt user to enter a file path.
		}

		/// <summary>
		/// on click, clear fields.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			OutputNumberLabel.ResetText();
			OutputFilePathLabel.ResetText();
			// reset UI.

			DataModel.NumberCount = 1;
			DataModel.FilePath = "";
			// reset data model.
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
