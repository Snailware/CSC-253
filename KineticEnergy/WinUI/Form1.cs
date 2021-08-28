/**
* 8/22/21
* CSC 253
* Adam Lancaster
* Kinetic Energy Calculator
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
using KineticEnergyClassLibrary;

namespace WinUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// calculate kinetic energy on button click. displays error message 
		/// if inputs are invalid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CalculateButton_Click(object sender, EventArgs e)
		{
			if (double.TryParse(MassInputTextBox.Text, out double mass) &&
				double.TryParse(VelocityInputTextBox.Text, out double velocity))
			{
				EnergyOutputLabel.Text = Calculator.KineticEnergy(mass, velocity).ToString();
			}
			// calculate and display kinetic energy if inputs are valid.

			else
			{
				MessageBox.Show("invalid entries. mass and velocity must be numbers.");
				MassInputTextBox.Clear();
				VelocityInputTextBox.Clear();
			}
			// display error messageBox to user and clear text fields for reentry.
		}

		/// <summary>
		/// clear all fields on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			MassInputTextBox.Clear();
			VelocityInputTextBox.Clear();
			EnergyOutputLabel.ResetText();
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
