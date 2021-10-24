
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
			this.EmployeeGridView = new System.Windows.Forms.DataGridView();
			this.Title = new System.Windows.Forms.Label();
			this.InputNameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personnelDataSet = new WinUI.PersonnelDataSet();
			this.employeeTableAdapter = new WinUI.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// EmployeeGridView
			// 
			this.EmployeeGridView.AutoGenerateColumns = false;
			this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.payrateDataGridViewTextBoxColumn});
			this.EmployeeGridView.DataSource = this.employeeBindingSource;
			this.EmployeeGridView.Location = new System.Drawing.Point(18, 29);
			this.EmployeeGridView.Name = "EmployeeGridView";
			this.EmployeeGridView.RowHeadersWidth = 51;
			this.EmployeeGridView.RowTemplate.Height = 24;
			this.EmployeeGridView.Size = new System.Drawing.Size(405, 150);
			this.EmployeeGridView.TabIndex = 0;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(156, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(119, 17);
			this.Title.TabIndex = 1;
			this.Title.Text = "Employee Search";
			// 
			// InputNameTextBox
			// 
			this.InputNameTextBox.Location = new System.Drawing.Point(154, 185);
			this.InputNameTextBox.Name = "InputNameTextBox";
			this.InputNameTextBox.Size = new System.Drawing.Size(269, 22);
			this.InputNameTextBox.TabIndex = 2;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(15, 188);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(133, 17);
			this.NameLabel.TabIndex = 3;
			this.NameLabel.Text = "Name to search for:";
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(18, 213);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(197, 23);
			this.SearchButton.TabIndex = 4;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(226, 213);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(197, 23);
			this.CloseButton.TabIndex = 5;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 125;
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "position";
			this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			this.positionDataGridViewTextBoxColumn.Width = 125;
			// 
			// payrateDataGridViewTextBoxColumn
			// 
			this.payrateDataGridViewTextBoxColumn.DataPropertyName = "pay_rate";
			this.payrateDataGridViewTextBoxColumn.HeaderText = "pay_rate";
			this.payrateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.payrateDataGridViewTextBoxColumn.Name = "payrateDataGridViewTextBoxColumn";
			this.payrateDataGridViewTextBoxColumn.Width = 125;
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 256);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.InputNameTextBox);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.EmployeeGridView);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Employee Search";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView EmployeeGridView;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox InputNameTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Button CloseButton;
		private PersonnelDataSet personnelDataSet;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn payrateDataGridViewTextBoxColumn;
	}
}

