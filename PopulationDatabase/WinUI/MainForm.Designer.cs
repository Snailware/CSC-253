
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.SortAscendingPopulationButton = new System.Windows.Forms.Button();
			this.SortDescendingPopulationButton = new System.Windows.Forms.Button();
			this.SortNameCityButton = new System.Windows.Forms.Button();
			this.TotalPopulationButton = new System.Windows.Forms.Button();
			this.AveragePopulationButton = new System.Windows.Forms.Button();
			this.HightestPopulationButton = new System.Windows.Forms.Button();
			this.LowestPopulationButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.populationDBDataSet = new WinUI.PopulationDBDataSet();
			this.cityTableAdapter = new WinUI.PopulationDBDataSetTableAdapters.CityTableAdapter();
			this.OutputTotalPopulationLabel = new System.Windows.Forms.Label();
			this.OutputAveragePopulationLabel = new System.Windows.Forms.Label();
			this.OutputHighestPopulationLabel = new System.Windows.Forms.Label();
			this.OutputLowestPopulationLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(79, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(106, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Population Database";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.cityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(244, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// SortAscendingPopulationButton
			// 
			this.SortAscendingPopulationButton.Location = new System.Drawing.Point(12, 181);
			this.SortAscendingPopulationButton.Name = "SortAscendingPopulationButton";
			this.SortAscendingPopulationButton.Size = new System.Drawing.Size(244, 23);
			this.SortAscendingPopulationButton.TabIndex = 2;
			this.SortAscendingPopulationButton.Text = "Sort Ascending by Population";
			this.SortAscendingPopulationButton.UseVisualStyleBackColor = true;
			this.SortAscendingPopulationButton.Click += new System.EventHandler(this.SortAscendingPopulationButton_Click);
			// 
			// SortDescendingPopulationButton
			// 
			this.SortDescendingPopulationButton.Location = new System.Drawing.Point(12, 210);
			this.SortDescendingPopulationButton.Name = "SortDescendingPopulationButton";
			this.SortDescendingPopulationButton.Size = new System.Drawing.Size(244, 23);
			this.SortDescendingPopulationButton.TabIndex = 3;
			this.SortDescendingPopulationButton.Text = "Sort Descending by Population";
			this.SortDescendingPopulationButton.UseVisualStyleBackColor = true;
			this.SortDescendingPopulationButton.Click += new System.EventHandler(this.SortDescendingPopulationButton_Click);
			// 
			// SortNameCityButton
			// 
			this.SortNameCityButton.Location = new System.Drawing.Point(12, 239);
			this.SortNameCityButton.Name = "SortNameCityButton";
			this.SortNameCityButton.Size = new System.Drawing.Size(244, 23);
			this.SortNameCityButton.TabIndex = 4;
			this.SortNameCityButton.Text = "Sort Cities by Name";
			this.SortNameCityButton.UseVisualStyleBackColor = true;
			this.SortNameCityButton.Click += new System.EventHandler(this.SortNameCityButton_Click);
			// 
			// TotalPopulationButton
			// 
			this.TotalPopulationButton.Location = new System.Drawing.Point(12, 268);
			this.TotalPopulationButton.Name = "TotalPopulationButton";
			this.TotalPopulationButton.Size = new System.Drawing.Size(130, 23);
			this.TotalPopulationButton.TabIndex = 5;
			this.TotalPopulationButton.Text = "Get Total Population";
			this.TotalPopulationButton.UseVisualStyleBackColor = true;
			this.TotalPopulationButton.Click += new System.EventHandler(this.TotalPopulationButton_Click);
			// 
			// AveragePopulationButton
			// 
			this.AveragePopulationButton.Location = new System.Drawing.Point(12, 297);
			this.AveragePopulationButton.Name = "AveragePopulationButton";
			this.AveragePopulationButton.Size = new System.Drawing.Size(130, 23);
			this.AveragePopulationButton.TabIndex = 6;
			this.AveragePopulationButton.Text = "Get Average Population";
			this.AveragePopulationButton.UseVisualStyleBackColor = true;
			this.AveragePopulationButton.Click += new System.EventHandler(this.AveragePopulationButton_Click);
			// 
			// HightestPopulationButton
			// 
			this.HightestPopulationButton.Location = new System.Drawing.Point(12, 326);
			this.HightestPopulationButton.Name = "HightestPopulationButton";
			this.HightestPopulationButton.Size = new System.Drawing.Size(130, 23);
			this.HightestPopulationButton.TabIndex = 7;
			this.HightestPopulationButton.Text = "Get Highest Population";
			this.HightestPopulationButton.UseVisualStyleBackColor = true;
			this.HightestPopulationButton.Click += new System.EventHandler(this.HightestPopulationButton_Click);
			// 
			// LowestPopulationButton
			// 
			this.LowestPopulationButton.Location = new System.Drawing.Point(12, 355);
			this.LowestPopulationButton.Name = "LowestPopulationButton";
			this.LowestPopulationButton.Size = new System.Drawing.Size(130, 23);
			this.LowestPopulationButton.TabIndex = 8;
			this.LowestPopulationButton.Text = "Get Lowest Population";
			this.LowestPopulationButton.UseVisualStyleBackColor = true;
			this.LowestPopulationButton.Click += new System.EventHandler(this.LowestPopulationButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(12, 384);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(244, 23);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
			this.cityDataGridViewTextBoxColumn.HeaderText = "City";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			// 
			// populationDataGridViewTextBoxColumn
			// 
			this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
			this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
			this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataMember = "City";
			this.cityBindingSource.DataSource = this.populationDBDataSet;
			// 
			// populationDBDataSet
			// 
			this.populationDBDataSet.DataSetName = "PopulationDBDataSet";
			this.populationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cityTableAdapter
			// 
			this.cityTableAdapter.ClearBeforeFill = true;
			// 
			// OutputTotalPopulationLabel
			// 
			this.OutputTotalPopulationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputTotalPopulationLabel.Location = new System.Drawing.Point(148, 268);
			this.OutputTotalPopulationLabel.Name = "OutputTotalPopulationLabel";
			this.OutputTotalPopulationLabel.Size = new System.Drawing.Size(108, 23);
			this.OutputTotalPopulationLabel.TabIndex = 10;
			this.OutputTotalPopulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OutputAveragePopulationLabel
			// 
			this.OutputAveragePopulationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputAveragePopulationLabel.Location = new System.Drawing.Point(148, 297);
			this.OutputAveragePopulationLabel.Name = "OutputAveragePopulationLabel";
			this.OutputAveragePopulationLabel.Size = new System.Drawing.Size(108, 23);
			this.OutputAveragePopulationLabel.TabIndex = 11;
			this.OutputAveragePopulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OutputHighestPopulationLabel
			// 
			this.OutputHighestPopulationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputHighestPopulationLabel.Location = new System.Drawing.Point(148, 326);
			this.OutputHighestPopulationLabel.Name = "OutputHighestPopulationLabel";
			this.OutputHighestPopulationLabel.Size = new System.Drawing.Size(108, 23);
			this.OutputHighestPopulationLabel.TabIndex = 12;
			this.OutputHighestPopulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OutputLowestPopulationLabel
			// 
			this.OutputLowestPopulationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputLowestPopulationLabel.Location = new System.Drawing.Point(148, 355);
			this.OutputLowestPopulationLabel.Name = "OutputLowestPopulationLabel";
			this.OutputLowestPopulationLabel.Size = new System.Drawing.Size(108, 23);
			this.OutputLowestPopulationLabel.TabIndex = 13;
			this.OutputLowestPopulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 417);
			this.Controls.Add(this.OutputLowestPopulationLabel);
			this.Controls.Add(this.OutputHighestPopulationLabel);
			this.Controls.Add(this.OutputAveragePopulationLabel);
			this.Controls.Add(this.OutputTotalPopulationLabel);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.LowestPopulationButton);
			this.Controls.Add(this.HightestPopulationButton);
			this.Controls.Add(this.AveragePopulationButton);
			this.Controls.Add(this.TotalPopulationButton);
			this.Controls.Add(this.SortNameCityButton);
			this.Controls.Add(this.SortDescendingPopulationButton);
			this.Controls.Add(this.SortAscendingPopulationButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Population Database";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PopulationDBDataSet populationDBDataSet;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button SortAscendingPopulationButton;
		private System.Windows.Forms.Button SortDescendingPopulationButton;
		private System.Windows.Forms.Button SortNameCityButton;
		private System.Windows.Forms.Button TotalPopulationButton;
		private System.Windows.Forms.Button AveragePopulationButton;
		private System.Windows.Forms.Button HightestPopulationButton;
		private System.Windows.Forms.Button LowestPopulationButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label OutputTotalPopulationLabel;
		private System.Windows.Forms.Label OutputAveragePopulationLabel;
		private System.Windows.Forms.Label OutputHighestPopulationLabel;
		private System.Windows.Forms.Label OutputLowestPopulationLabel;
	}
}

