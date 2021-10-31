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
				Controller.SaveSupervisor(name: NameTextBox.Text,
										  number: int.Parse(NumberTextBox.Text),
										  salary: double.Parse(SalaryTextBox.Text),
										  bonus: double.Parse(BonusTextBox.Text));
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
			ShiftSupervisor supervisor = Controller.LoadSupervisor();
			if (supervisor is null)
			{
				MessageBox.Show("No supervisor has been entered to display.");
			}
			else
			{
				NameTextBox.Text = supervisor.Name;
				NumberTextBox.Text = supervisor.Number.ToString();
				SalaryTextBox.Text = supervisor.Salary.ToString("c");
				BonusTextBox.Text = supervisor.Bonus.ToString("c");
			}
		}

		/// <summary>
		/// on click, clear fields and data model.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			Controller.ClearSupervisor();

			NameTextBox.Clear();
			NumberTextBox.Clear();
			SalaryTextBox.Clear();
			BonusTextBox.Clear();
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
