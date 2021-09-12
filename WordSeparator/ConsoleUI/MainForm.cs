/**
* 9/12/21
* CSC 253
* Adam Lancaster
* Word Separator
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
using WordSeparatorClassLibrary;

namespace ConsoleUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, parse pascal case and display results.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SeparateButton_Click(object sender, EventArgs e)
		{
			WordsIOTextBox.Text = WordOps.ParsePascalCase(WordsIOTextBox.Text);
		}

		/// <summary>
		/// on click, clear text field.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			WordsIOTextBox.Clear();
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
