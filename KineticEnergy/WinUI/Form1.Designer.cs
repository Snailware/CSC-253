
namespace WinUI
{
	partial class Form1
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
			this.MassLabel = new System.Windows.Forms.Label();
			this.VelocityLabel = new System.Windows.Forms.Label();
			this.EnergyLabel = new System.Windows.Forms.Label();
			this.EnergyOutputLabel = new System.Windows.Forms.Label();
			this.MassInputTextBox = new System.Windows.Forms.TextBox();
			this.VelocityInputTextBox = new System.Windows.Forms.TextBox();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(38, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(125, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Kinetic Energy Calculator";
			// 
			// MassLabel
			// 
			this.MassLabel.AutoSize = true;
			this.MassLabel.Location = new System.Drawing.Point(12, 31);
			this.MassLabel.Name = "MassLabel";
			this.MassLabel.Size = new System.Drawing.Size(57, 13);
			this.MassLabel.TabIndex = 1;
			this.MassLabel.Text = "Obj. Mass:";
			// 
			// VelocityLabel
			// 
			this.VelocityLabel.AutoSize = true;
			this.VelocityLabel.Location = new System.Drawing.Point(12, 57);
			this.VelocityLabel.Name = "VelocityLabel";
			this.VelocityLabel.Size = new System.Drawing.Size(69, 13);
			this.VelocityLabel.TabIndex = 2;
			this.VelocityLabel.Text = "Obj. Velocity:";
			// 
			// EnergyLabel
			// 
			this.EnergyLabel.AutoSize = true;
			this.EnergyLabel.Location = new System.Drawing.Point(12, 85);
			this.EnergyLabel.Name = "EnergyLabel";
			this.EnergyLabel.Size = new System.Drawing.Size(65, 13);
			this.EnergyLabel.TabIndex = 3;
			this.EnergyLabel.Text = "Obj. Energy:";
			// 
			// EnergyOutputLabel
			// 
			this.EnergyOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.EnergyOutputLabel.Location = new System.Drawing.Point(89, 81);
			this.EnergyOutputLabel.Name = "EnergyOutputLabel";
			this.EnergyOutputLabel.Size = new System.Drawing.Size(100, 20);
			this.EnergyOutputLabel.TabIndex = 4;
			this.EnergyOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MassInputTextBox
			// 
			this.MassInputTextBox.Location = new System.Drawing.Point(89, 28);
			this.MassInputTextBox.Name = "MassInputTextBox";
			this.MassInputTextBox.Size = new System.Drawing.Size(100, 20);
			this.MassInputTextBox.TabIndex = 5;
			this.MassInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// VelocityInputTextBox
			// 
			this.VelocityInputTextBox.Location = new System.Drawing.Point(89, 54);
			this.VelocityInputTextBox.Name = "VelocityInputTextBox";
			this.VelocityInputTextBox.Size = new System.Drawing.Size(100, 20);
			this.VelocityInputTextBox.TabIndex = 6;
			this.VelocityInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(15, 133);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(83, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(106, 133);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(83, 23);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(15, 104);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(174, 23);
			this.CalculateButton.TabIndex = 7;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(203, 165);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.VelocityInputTextBox);
			this.Controls.Add(this.MassInputTextBox);
			this.Controls.Add(this.EnergyOutputLabel);
			this.Controls.Add(this.EnergyLabel);
			this.Controls.Add(this.VelocityLabel);
			this.Controls.Add(this.MassLabel);
			this.Controls.Add(this.Title);
			this.Name = "Form1";
			this.Text = "Energy Calc.";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label MassLabel;
		private System.Windows.Forms.Label VelocityLabel;
		private System.Windows.Forms.Label EnergyLabel;
		private System.Windows.Forms.Label EnergyOutputLabel;
		private System.Windows.Forms.TextBox MassInputTextBox;
		private System.Windows.Forms.TextBox VelocityInputTextBox;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button CalculateButton;
	}
}

