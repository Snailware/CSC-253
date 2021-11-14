
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
			this.OutputListBox = new System.Windows.Forms.ListBox();
			this.Title = new System.Windows.Forms.Label();
			this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.StartingAmountTextBox = new System.Windows.Forms.TextBox();
			this.RateOfIncreaseTextBox = new System.Windows.Forms.TextBox();
			this.NumberOfYearsTextBox = new System.Windows.Forms.TextBox();
			this.LabelStartingAmount = new System.Windows.Forms.Label();
			this.LabelRateOfIncrease = new System.Windows.Forms.Label();
			this.LabelNumberOfYears = new System.Windows.Forms.Label();
			this.ControlsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// OutputListBox
			// 
			this.OutputListBox.FormattingEnabled = true;
			this.OutputListBox.Location = new System.Drawing.Point(12, 163);
			this.OutputListBox.Name = "OutputListBox";
			this.OutputListBox.Size = new System.Drawing.Size(237, 69);
			this.OutputListBox.TabIndex = 0;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(61, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(133, 13);
			this.Title.TabIndex = 1;
			this.Title.Text = "Tuition Increase Calculator";
			// 
			// ControlsGroupBox
			// 
			this.ControlsGroupBox.Controls.Add(this.LabelNumberOfYears);
			this.ControlsGroupBox.Controls.Add(this.LabelRateOfIncrease);
			this.ControlsGroupBox.Controls.Add(this.LabelStartingAmount);
			this.ControlsGroupBox.Controls.Add(this.NumberOfYearsTextBox);
			this.ControlsGroupBox.Controls.Add(this.RateOfIncreaseTextBox);
			this.ControlsGroupBox.Controls.Add(this.StartingAmountTextBox);
			this.ControlsGroupBox.Location = new System.Drawing.Point(12, 25);
			this.ControlsGroupBox.Name = "ControlsGroupBox";
			this.ControlsGroupBox.Size = new System.Drawing.Size(237, 103);
			this.ControlsGroupBox.TabIndex = 2;
			this.ControlsGroupBox.TabStop = false;
			this.ControlsGroupBox.Text = "Input";
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(12, 134);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(75, 23);
			this.CalculateButton.TabIndex = 3;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(93, 134);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 4;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(174, 134);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 5;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// StartingAmountTextBox
			// 
			this.StartingAmountTextBox.Location = new System.Drawing.Point(131, 19);
			this.StartingAmountTextBox.Name = "StartingAmountTextBox";
			this.StartingAmountTextBox.Size = new System.Drawing.Size(100, 20);
			this.StartingAmountTextBox.TabIndex = 0;
			// 
			// RateOfIncreaseTextBox
			// 
			this.RateOfIncreaseTextBox.Location = new System.Drawing.Point(131, 45);
			this.RateOfIncreaseTextBox.Name = "RateOfIncreaseTextBox";
			this.RateOfIncreaseTextBox.Size = new System.Drawing.Size(100, 20);
			this.RateOfIncreaseTextBox.TabIndex = 1;
			// 
			// NumberOfYearsTextBox
			// 
			this.NumberOfYearsTextBox.Location = new System.Drawing.Point(131, 71);
			this.NumberOfYearsTextBox.Name = "NumberOfYearsTextBox";
			this.NumberOfYearsTextBox.Size = new System.Drawing.Size(100, 20);
			this.NumberOfYearsTextBox.TabIndex = 2;
			// 
			// LabelStartingAmount
			// 
			this.LabelStartingAmount.AutoSize = true;
			this.LabelStartingAmount.Location = new System.Drawing.Point(6, 22);
			this.LabelStartingAmount.Name = "LabelStartingAmount";
			this.LabelStartingAmount.Size = new System.Drawing.Size(85, 13);
			this.LabelStartingAmount.TabIndex = 3;
			this.LabelStartingAmount.Text = "Starting Amount:";
			// 
			// LabelRateOfIncrease
			// 
			this.LabelRateOfIncrease.AutoSize = true;
			this.LabelRateOfIncrease.Location = new System.Drawing.Point(6, 48);
			this.LabelRateOfIncrease.Name = "LabelRateOfIncrease";
			this.LabelRateOfIncrease.Size = new System.Drawing.Size(89, 13);
			this.LabelRateOfIncrease.TabIndex = 4;
			this.LabelRateOfIncrease.Text = "Rate of Increase:";
			// 
			// LabelNumberOfYears
			// 
			this.LabelNumberOfYears.AutoSize = true;
			this.LabelNumberOfYears.Location = new System.Drawing.Point(6, 74);
			this.LabelNumberOfYears.Name = "LabelNumberOfYears";
			this.LabelNumberOfYears.Size = new System.Drawing.Size(89, 13);
			this.LabelNumberOfYears.TabIndex = 5;
			this.LabelNumberOfYears.Text = "Number of Years:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 243);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.ControlsGroupBox);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.OutputListBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Tuition Increase Calculator";
			this.ControlsGroupBox.ResumeLayout(false);
			this.ControlsGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox OutputListBox;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.GroupBox ControlsGroupBox;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.TextBox NumberOfYearsTextBox;
		private System.Windows.Forms.TextBox RateOfIncreaseTextBox;
		private System.Windows.Forms.TextBox StartingAmountTextBox;
		private System.Windows.Forms.Label LabelRateOfIncrease;
		private System.Windows.Forms.Label LabelStartingAmount;
		private System.Windows.Forms.Label LabelNumberOfYears;
	}
}

