/**
* 10/31/2021
* CSC 253
* Adam Lancaster
* String Extension Methods
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
using StringExtensionMethodsLib;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void StringToCharArrayButton_Click(object sender, EventArgs e)
		{
			try
			{
				InputTextBox.Text = new string(InputTextBox.Text.StringToCharArray());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DateToStringArrayButton_Click(object sender, EventArgs e)
		{
			try
			{
				InputTextBox.Text = string.Join(", ", InputTextBox.Text.DateToStringArray());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void StringToPhoneNumberButton_Click(object sender, EventArgs e)
		{
			try
			{
				InputTextBox.Text = InputTextBox.Text.StringToPhoneNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ReverseStringButton_Click(object sender, EventArgs e)
		{
			try
			{
				InputTextBox.Text = InputTextBox.Text.ReverseString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CountWordsButton_Click(object sender, EventArgs e)
		{
			try
			{
				InputTextBox.Text = InputTextBox.Text.CountWords().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			InputTextBox.Clear();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
