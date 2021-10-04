/**
* 10/3/21
* CSC 253
* Adam Lancaster
* Hourly Pay Sorter
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

		/// <summary>
		/// on click, sort database by pay in ascending order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortAscendingButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.employeeTableAdapter.FillByPayAscending(this.personnelDataSet.Employee);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// on click, sort database by pay in descending order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortDescendingButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.employeeTableAdapter.FillByPayDescending(this.personnelDataSet.Employee);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
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

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
			this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

		}
	}
}
