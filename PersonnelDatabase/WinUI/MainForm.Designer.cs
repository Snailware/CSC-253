
namespace WinUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Title = new System.Windows.Forms.Label();
			this.PersonnelGridView = new System.Windows.Forms.DataGridView();
			this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hourlypayrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personnelDataSet = new WinUI.PersonnelDataSet();
			this.CloseButton = new System.Windows.Forms.Button();
			this.employeeTableAdapter = new WinUI.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.PersonnelGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(189, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(103, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Personnel Database";
			// 
			// PersonnelGridView
			// 
			this.PersonnelGridView.AutoGenerateColumns = false;
			this.PersonnelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PersonnelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.hourlypayrateDataGridViewTextBoxColumn});
			this.PersonnelGridView.DataSource = this.employeeBindingSource;
			this.PersonnelGridView.Location = new System.Drawing.Point(12, 25);
			this.PersonnelGridView.Name = "PersonnelGridView";
			this.PersonnelGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.PersonnelGridView.Size = new System.Drawing.Size(446, 166);
			this.PersonnelGridView.TabIndex = 1;
			// 
			// employeeidDataGridViewTextBoxColumn
			// 
			this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
			this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
			this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
			this.employeeidDataGridViewTextBoxColumn.Width = 101;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 101;
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "position";
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			// 
			// hourlypayrateDataGridViewTextBoxColumn
			// 
			this.hourlypayrateDataGridViewTextBoxColumn.DataPropertyName = "hourly_pay_rate";
			this.hourlypayrateDataGridViewTextBoxColumn.HeaderText = "hourly_pay_rate";
			this.hourlypayrateDataGridViewTextBoxColumn.Name = "hourlypayrateDataGridViewTextBoxColumn";
			this.hourlypayrateDataGridViewTextBoxColumn.Width = 101;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataMember = "Employee";
			this.employeeBindingSource.DataSource = this.personnelDataSet;
			// 
			// personnelDataSet
			// 
			this.personnelDataSet.DataSetName = "PersonnelDataSet";
			this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(12, 197);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(446, 23);
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 227);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.PersonnelGridView);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Personnel Database";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PersonnelGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.DataGridView PersonnelGridView;
		private System.Windows.Forms.Button CloseButton;
		private PersonnelDataSet personnelDataSet;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hourlypayrateDataGridViewTextBoxColumn;
	}
}

