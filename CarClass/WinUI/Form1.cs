/**
* 8/28/21
* CSC 253
* Adam Lancaster
* Car Class Practice
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
using CarClassClassLibrary;

namespace WinUI
{
	public partial class Form1 : Form
	{
		Car myCar = new Car(2016, "Jeep");

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, accelerate car and display new speed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AccelerateButton_Click(object sender, EventArgs e)
		{
			myCar.Accelerate();
			UpdateSpeedOutput();
		}

		/// <summary>
		/// on click, brake car and display new speed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrakeButton_Click(object sender, EventArgs e)
		{
			myCar.Brake();
			UpdateSpeedOutput();
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
		/// update speeed output according to car objs speed.
		/// </summary>
		private void UpdateSpeedOutput()
		{
			SpeedOutputLabel.Text = myCar.Speed.ToString();
		}
	}
}
