/**
* 10/24/21
* CSC 253
* Adam Lancaster
* Class Practice
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
using EmpAndProdWorkerLib;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, save entered data to data model.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				Controller.SaveWorker(name: NameTextBox.Text,
									  number: int.Parse(NumberTextBox.Text),
									  shiftNumber: int.Parse(ShiftNumberTextBox.Text),
									  hourlyPayRate: double.Parse(HourlyPayRateTextBox.Text),
									  bonusAmount: double.Parse(BonusAmountTextBox.Text),
									  requiredTrainingHours: int.Parse(ReqTrainingHoursTextBox.Text),
									  completedTrainingHours: int.Parse(CompTrainingHoursTextBox.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// on click, load data from data model.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadButton_Click(object sender, EventArgs e)
		{
			TeamLeader worker = Controller.LoadWorker();
			if (worker is null)
			{
				MessageBox.Show("No worker has been entered to display.");
			}
			else
			{
				NameTextBox.Text = worker.Name;
				NumberTextBox.Text = worker.Number.ToString();
				ShiftNumberTextBox.Text = worker.ShiftNumber.ToString();
				HourlyPayRateTextBox.Text = worker.HourlyPayRate.ToString("c");
				BonusAmountTextBox.Text = worker.BonusAmount.ToString("c");
				ReqTrainingHoursTextBox.Text = worker.RequiredTrainingHours.ToString();
				CompTrainingHoursTextBox.Text = worker.CompletedTrainingHours.ToString();
			}
		}

		/// <summary>
		/// on click, clear fields and data model.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			Controller.ClearWorker();

			NameTextBox.Clear();
			NumberTextBox.Clear();
			ShiftNumberTextBox.Clear();
			HourlyPayRateTextBox.Clear();
			BonusAmountTextBox.Clear();
			ReqTrainingHoursTextBox.Clear();
			CompTrainingHoursTextBox.Clear();
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
