
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
			this.SortAscendingButton = new System.Windows.Forms.Button();
			this.SortDescendingButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personnelDataSet = new WinUI.PersonnelDataSet();
			this.employeeTableAdapter = new WinUI.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.PersonnelGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(168, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(89, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Hourly Pay Sorter";
			// 
			// PersonnelGridView
			// 
			this.PersonnelGridView.AutoGenerateColumns = false;
			this.PersonnelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PersonnelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.payrateDataGridViewTextBoxColumn});
			this.PersonnelGridView.DataSource = this.employeeBindingSource;
			this.PersonnelGridView.Location = new System.Drawing.Point(12, 25);
			this.PersonnelGridView.Name = "PersonnelGridView";
			this.PersonnelGridView.Size = new System.Drawing.Size(402, 161);
			this.PersonnelGridView.TabIndex = 1;
			// 
			// SortAscendingButton
			// 
			this.SortAscendingButton.Location = new System.Drawing.Point(12, 192);
			this.SortAscendingButton.Name = "SortAscendingButton";
			this.SortAscendingButton.Size = new System.Drawing.Size(130, 23);
			this.SortAscendingButton.TabIndex = 2;
			this.SortAscendingButton.Text = "Sort Ascending by Pay";
			this.SortAscendingButton.UseVisualStyleBackColor = true;
			this.SortAscendingButton.Click += new System.EventHandler(this.SortAscendingButton_Click);
			// 
			// SortDescendingButton
			// 
			this.SortDescendingButton.Location = new System.Drawing.Point(148, 192);
			this.SortDescendingButton.Name = "SortDescendingButton";
			this.SortDescendingButton.Size = new System.Drawing.Size(130, 23);
			this.SortDescendingButton.TabIndex = 3;
			this.SortDescendingButton.Text = "Sort Descending by Pay";
			this.SortDescendingButton.UseVisualStyleBackColor = true;
			this.SortDescendingButton.Click += new System.EventHandler(this.SortDescendingButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(284, 192);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(130, 23);
			this.CloseButton.TabIndex = 4;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// employeeidDataGridViewTextBoxColumn
			// 
			this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
			this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
			this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "position";
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			// 
			// payrateDataGridViewTextBoxColumn
			// 
			this.payrateDataGridViewTextBoxColumn.DataPropertyName = "pay_rate";
			this.payrateDataGridViewTextBoxColumn.HeaderText = "pay_rate";
			this.payrateDataGridViewTextBoxColumn.Name = "payrateDataGridViewTextBoxColumn";
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
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 235);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.SortDescendingButton);
			this.Controls.Add(this.SortAscendingButton);
			this.Controls.Add(this.PersonnelGridView);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Hourly Pay Sorter";
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
		private System.Windows.Forms.Button SortAscendingButton;
		private System.Windows.Forms.Button SortDescendingButton;
		private System.Windows.Forms.Button CloseButton;
		private PersonnelDataSet personnelDataSet;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn payrateDataGridViewTextBoxColumn;
	}
}

