using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaClassClassLibrary;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, calculate area based on user input and display results.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CalculateButton_Click(object sender, EventArgs e)
		{
			double radius,
				   height,
				   area = 0D;

			float width,
				  length;
			// vars.

			if (CircleRadioButton.Checked && 
				Double.TryParse(RadiusTextBox.Text, out radius))
			{
				area = Calculator.CalculateArea(radius);
			}
			else if (RectangleRadioButton.Checked && 
					 float.TryParse(WidthTextBox.Text, out width) &&
					 float.TryParse(LengthTextBox.Text, out length))
			{
				area = Calculator.CalculateArea(width, length);
			}
			else if (CylinderRadioButton.Checked &&
					 Double.TryParse(RadiusTextBox.Text, out radius) &&
					 Double.TryParse(HeightTextBox.Text, out height))
			{
				area = Calculator.CalculateArea(radius, height);
			}
			// calculate area depending on radio button selection and input
			// validity.

			UpdateArea(area);
			// display results in area output field.
		}

		/// <summary>
		/// on click, clear form fields in prep for next calculation. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			RadiusTextBox.Clear();
			WidthTextBox.Clear();
			LengthTextBox.Clear();
			HeightTextBox.Clear();
			AreaOutputLabel.ResetText();
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

		/// <summary>
		/// if selected, enable radius input. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (CircleRadioButton.Checked)
			{
				RadiusTextBox.Enabled = true;
				WidthTextBox.Enabled = false;
				LengthTextBox.Enabled = false;
				HeightTextBox.Enabled = false;
			}
		}

		/// <summary>
		/// if selected, enable width & length input. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (RectangleRadioButton.Checked)
			{
				RadiusTextBox.Enabled = false;
				WidthTextBox.Enabled = true;
				LengthTextBox.Enabled = true;
				HeightTextBox.Enabled = false;
			}
		}

		/// <summary>
		/// if selected, enable radius & height input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CylinderRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (CylinderRadioButton.Checked)
			{
				RadiusTextBox.Enabled = true;
				WidthTextBox.Enabled = false;
				LengthTextBox.Enabled = false;
				HeightTextBox.Enabled = true;
			}
		}

		/// <summary>
		/// update area output field with desired number. ignores 0.
		/// </summary>
		/// <param name="input">number to display in field.</param>
		private void UpdateArea(double input)
		{
			if (input != 0D)
			{
				AreaOutputLabel.Text = input.ToString();
			}
		}
	}
}
