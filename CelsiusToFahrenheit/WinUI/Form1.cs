/**
* 8/22/21
* CSC 253
* Adam Lancaster
* Celsius to Fahrenheit Converter.
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
using CelsiusToFahrenheitClassLibrary;

namespace WinUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// if empty, fill TempListBox with temps on click. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConvertButton_Click(object sender, EventArgs e)
		{
			if(TempListBox.Items.Count == 0)
			{
				for (int i = 0; i <= 20; i++)
				{
					TempListBox.Items.Add($"{i} celsius ================ {Converter.CelsToFahr(i)} fahrenheit");
				}
			}
		}

		/// <summary>
		/// clear TempListBox entries on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			TempListBox.Items.Clear();
		}

		/// <summary>
		/// close program on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
