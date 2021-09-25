/**
* 9/19/21
* CSC 253
* Adam Lancaster
* Random Number File Reader
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
using RandomNumberFileReaderClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, open file dialog window & get input for file name.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FileButton_Click(object sender, EventArgs e)
		{
			if (OpenFile.ShowDialog() == DialogResult.OK)
			{
				DataModel.FileName = OpenFile.FileName;
				OutputFilePathLabel.Text = DataModel.FileName;
			}
		}

		/// <summary>
		/// read numbers from file and display results.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReadButton_Click(object sender, EventArgs e)
		{
			if (DataModel.FileName != "")
			{
				DataModel.Numbers.Clear();
				OutputNumbersListBox.Items.Clear();
				// clear list of previous entries. this prevents overfilling 
				// list via repeated read presses.

				string status = FileOps.ReadNumbers(DataModel.FileName, out List<int> numbers);
				if (status == "FILE READ SUCCESSFULLY!") 
				{
					DataModel.Numbers = numbers;
					foreach (int number in DataModel.Numbers)
					{
						OutputNumbersListBox.Items.Add(number);
					}
					// read numbers from file and add to list box.

					DataModel.Sum = DataModel.Numbers.Sum();
					OutputSumLabel.Text = DataModel.Sum.ToString();
					// calculate sum of numbers and display.

					DataModel.Count = DataModel.Numbers.Count;
					OutputNumberCountLabel.Text = DataModel.Count.ToString();
					// count numbers read and display.
				}
				else
				{
					MessageBox.Show(status);
				}

			}
			// read file and display data if file name is specified.
			else
			{
				MessageBox.Show("You must select a file first!");
			}
			// display message box prompting user to select file.
		}

		/// <summary>
		/// on click, clear fields & data.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			OutputFilePathLabel.ResetText();
			OutputSumLabel.ResetText();
			OutputNumberCountLabel.ResetText();
			OutputNumbersListBox.Items.Clear();
			// reset UI.

			DataModel.FileName = "";
			DataModel.Sum = 0;
			DataModel.Count = 0;
			DataModel.Numbers.Clear();
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
