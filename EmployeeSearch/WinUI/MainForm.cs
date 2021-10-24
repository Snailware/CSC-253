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
			// TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
			this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			employeeTableAdapter.SearchName(this.personnelDataSet.Employee, InputNameTextBox.Text);
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
