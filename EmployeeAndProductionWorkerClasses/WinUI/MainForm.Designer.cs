
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
			this.Title = new System.Windows.Forms.Label();
			this.LabelName = new System.Windows.Forms.Label();
			this.LabelNumber = new System.Windows.Forms.Label();
			this.LabelShiftNumber = new System.Windows.Forms.Label();
			this.LabelHourlyPayRate = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NumberTextBox = new System.Windows.Forms.TextBox();
			this.ShiftNumberTextBox = new System.Windows.Forms.TextBox();
			this.HourlyPayRateTextBox = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.LoadButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(26, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(273, 17);
			this.Title.TabIndex = 0;
			this.Title.Text = "Employee and Production Worker Classes";
			// 
			// LabelName
			// 
			this.LabelName.AutoSize = true;
			this.LabelName.Location = new System.Drawing.Point(12, 32);
			this.LabelName.Name = "LabelName";
			this.LabelName.Size = new System.Drawing.Size(49, 17);
			this.LabelName.TabIndex = 1;
			this.LabelName.Text = "Name:";
			// 
			// LabelNumber
			// 
			this.LabelNumber.AutoSize = true;
			this.LabelNumber.Location = new System.Drawing.Point(12, 60);
			this.LabelNumber.Name = "LabelNumber";
			this.LabelNumber.Size = new System.Drawing.Size(62, 17);
			this.LabelNumber.TabIndex = 2;
			this.LabelNumber.Text = "Number:";
			// 
			// LabelShiftNumber
			// 
			this.LabelShiftNumber.AutoSize = true;
			this.LabelShiftNumber.Location = new System.Drawing.Point(12, 88);
			this.LabelShiftNumber.Name = "LabelShiftNumber";
			this.LabelShiftNumber.Size = new System.Drawing.Size(94, 17);
			this.LabelShiftNumber.TabIndex = 3;
			this.LabelShiftNumber.Text = "Shift Number:";
			// 
			// LabelHourlyPayRate
			// 
			this.LabelHourlyPayRate.AutoSize = true;
			this.LabelHourlyPayRate.Location = new System.Drawing.Point(12, 116);
			this.LabelHourlyPayRate.Name = "LabelHourlyPayRate";
			this.LabelHourlyPayRate.Size = new System.Drawing.Size(70, 17);
			this.LabelHourlyPayRate.TabIndex = 4;
			this.LabelHourlyPayRate.Text = "Pay Rate:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(67, 29);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(243, 22);
			this.NameTextBox.TabIndex = 5;
			// 
			// NumberTextBox
			// 
			this.NumberTextBox.Location = new System.Drawing.Point(80, 57);
			this.NumberTextBox.Name = "NumberTextBox";
			this.NumberTextBox.Size = new System.Drawing.Size(230, 22);
			this.NumberTextBox.TabIndex = 6;
			// 
			// ShiftNumberTextBox
			// 
			this.ShiftNumberTextBox.Location = new System.Drawing.Point(112, 85);
			this.ShiftNumberTextBox.Name = "ShiftNumberTextBox";
			this.ShiftNumberTextBox.Size = new System.Drawing.Size(198, 22);
			this.ShiftNumberTextBox.TabIndex = 7;
			// 
			// HourlyPayRateTextBox
			// 
			this.HourlyPayRateTextBox.Location = new System.Drawing.Point(88, 113);
			this.HourlyPayRateTextBox.Name = "HourlyPayRateTextBox";
			this.HourlyPayRateTextBox.Size = new System.Drawing.Size(222, 22);
			this.HourlyPayRateTextBox.TabIndex = 8;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(12, 141);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(145, 23);
			this.SaveButton.TabIndex = 9;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// LoadButton
			// 
			this.LoadButton.Location = new System.Drawing.Point(165, 141);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(145, 23);
			this.LoadButton.TabIndex = 10;
			this.LoadButton.Text = "Load";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(12, 170);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(145, 23);
			this.ClearButton.TabIndex = 11;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(165, 170);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(145, 23);
			this.CloseButton.TabIndex = 12;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 203);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.HourlyPayRateTextBox);
			this.Controls.Add(this.ShiftNumberTextBox);
			this.Controls.Add(this.NumberTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.LabelHourlyPayRate);
			this.Controls.Add(this.LabelShiftNumber);
			this.Controls.Add(this.LabelNumber);
			this.Controls.Add(this.LabelName);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Employee and Production Worker Classes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label LabelName;
		private System.Windows.Forms.Label LabelNumber;
		private System.Windows.Forms.Label LabelShiftNumber;
		private System.Windows.Forms.Label LabelHourlyPayRate;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox NumberTextBox;
		private System.Windows.Forms.TextBox ShiftNumberTextBox;
		private System.Windows.Forms.TextBox HourlyPayRateTextBox;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
	}
}

