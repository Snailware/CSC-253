/**
* 11/14/21
* CSC 253
* Adam Lancaster
* Tuition Increase
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
using TuitionIncreaseLib;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, calculate & display future tuition rates based on user 
		/// input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CalculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				Controller.StoreValues(startingAmount: double.Parse(StartingAmountTextBox.Text),
									   rateOfIncrease: double.Parse(RateOfIncreaseTextBox.Text),
									   numberOfYears: int.Parse(NumberOfYearsTextBox.Text));

				Controller.CalculateTuitionRate();

				PopulateOutput(Controller.GetResults());
			} 
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// on click, clear all fields from UI and data from data model.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			ClearFields();
			Controller.ClearModel();
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
		/// clear all UI fields.
		/// </summary>
		private void ClearFields()
		{
			StartingAmountTextBox.Clear();
			RateOfIncreaseTextBox.Clear();
			NumberOfYearsTextBox.Clear();
			OutputListBox.Items.Clear();
		}

		/// <summary>
		/// populate output list box with data from list.
		/// </summary>
		/// <param name="entries">list to be displayed.</param>
		private void PopulateOutput(List<string> entries)
		{
			foreach (string entry in entries)
			{
				OutputListBox.Items.Add(entry);
			}
		}
	}
}
