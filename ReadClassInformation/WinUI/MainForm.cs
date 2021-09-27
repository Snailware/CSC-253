using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadClassInformationClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, read person object from file and display. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReadButton_Click(object sender, EventArgs e)
		{
			if (FileDialog.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show(FileOps.ReadPersonFromFile(FileDialog.FileName, out Person person));
				if (person != null)
				{
					OutputNameLabel.Text = person.Name;
					OutputHairColorLabel.Text = person.HairColor;
					OutputAgeLabel.Text = person.Age.ToString();
				}
			}
		}

		/// <summary>
		/// on click, clear all fields.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			OutputNameLabel.ResetText();
			OutputHairColorLabel.ResetText();
			OutputAgeLabel.ResetText();
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
