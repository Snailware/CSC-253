/**
* 10/17/21
* CSC 253
* Adam Lancaster
* Population Database
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


namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
			this.cityTableAdapter.Fill(this.populationDBDataSet.City);

		}

		/// <summary>
		/// on click, sort population by ascending order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortAscendingPopulationButton_Click(object sender, EventArgs e)
		{
			this.cityTableAdapter.SortAscendingPopulation(this.populationDBDataSet.City);
		}

		/// <summary>
		/// on click, sort population by descending order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortDescendingPopulationButton_Click(object sender, EventArgs e)
		{
			this.cityTableAdapter.SortDescendingPopulation(this.populationDBDataSet.City);
		}

		/// <summary>
		/// on click, sort cities by name.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortNameCityButton_Click(object sender, EventArgs e)
		{
			this.cityTableAdapter.SortByName(this.populationDBDataSet.City);
		}

		/// <summary>
		/// on click, get and display total population.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TotalPopulationButton_Click(object sender, EventArgs e)
		{
			OutputTotalPopulationLabel.Text = this.cityTableAdapter.GetTotalPopulation().ToString();
		}

		/// <summary>
		/// on click, get and display average population.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AveragePopulationButton_Click(object sender, EventArgs e)
		{
			OutputAveragePopulationLabel.Text = this.cityTableAdapter.GetAveragePopulation().ToString();
		}

		/// <summary>
		/// on click, gget and display highest population.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HightestPopulationButton_Click(object sender, EventArgs e)
		{
			OutputHighestPopulationLabel.Text = this.cityTableAdapter.GetHighestPopulation().ToString();
		}

		/// <summary>
		/// on click, get and display the lowest population.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LowestPopulationButton_Click(object sender, EventArgs e)
		{
			OutputLowestPopulationLabel.Text = this.cityTableAdapter.GetLowestPopulation().ToString();
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
