/**
* 9/26/21
* CSC 253
* Adam Lancaster
* write class info to file.
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
using WriteClassInformationClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, write create person obj from user input and write obj to file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WriteButton_Click(object sender, EventArgs e)
		{
			if (int.TryParse(InputAgeTextBox.Text, out int age))
			{
				Person person = new Person(InputNameTextBox.Text,
										   InputHairColorTextBox.Text,
										   age);
				// create person obj.

				MessageBox.Show(FileOps.WritePersonToFile(person, "UserInformation.json"));
				// attempt to write to file and show message box with status or
				// error message. 
			}
			// if values are valid, create person and save to file. 
			else
			{
				MessageBox.Show("age field must contain a number!");
			}
			// tell user to enter number. 
		}

		/// <summary>
		/// clear all fields.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			InputNameTextBox.Clear();
			InputAgeTextBox.Clear();
			InputHairColorTextBox.Clear();
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
