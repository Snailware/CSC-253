
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
			this.InputNameTextBox = new System.Windows.Forms.TextBox();
			this.InputAgeTextBox = new System.Windows.Forms.TextBox();
			this.InputHairColorTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.AgeLabel = new System.Windows.Forms.Label();
			this.HairColorLabel = new System.Windows.Forms.Label();
			this.WriteButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(49, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(81, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Write Class Info";
			// 
			// InputNameTextBox
			// 
			this.InputNameTextBox.Location = new System.Drawing.Point(72, 25);
			this.InputNameTextBox.Name = "InputNameTextBox";
			this.InputNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.InputNameTextBox.TabIndex = 1;
			// 
			// InputAgeTextBox
			// 
			this.InputAgeTextBox.Location = new System.Drawing.Point(72, 51);
			this.InputAgeTextBox.Name = "InputAgeTextBox";
			this.InputAgeTextBox.Size = new System.Drawing.Size(100, 20);
			this.InputAgeTextBox.TabIndex = 2;
			// 
			// InputHairColorTextBox
			// 
			this.InputHairColorTextBox.Location = new System.Drawing.Point(72, 77);
			this.InputHairColorTextBox.Name = "InputHairColorTextBox";
			this.InputHairColorTextBox.Size = new System.Drawing.Size(100, 20);
			this.InputHairColorTextBox.TabIndex = 3;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(12, 28);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(38, 13);
			this.NameLabel.TabIndex = 4;
			this.NameLabel.Text = "Name:";
			// 
			// AgeLabel
			// 
			this.AgeLabel.AutoSize = true;
			this.AgeLabel.Location = new System.Drawing.Point(12, 54);
			this.AgeLabel.Name = "AgeLabel";
			this.AgeLabel.Size = new System.Drawing.Size(29, 13);
			this.AgeLabel.TabIndex = 5;
			this.AgeLabel.Text = "Age:";
			// 
			// HairColorLabel
			// 
			this.HairColorLabel.AutoSize = true;
			this.HairColorLabel.Location = new System.Drawing.Point(12, 80);
			this.HairColorLabel.Name = "HairColorLabel";
			this.HairColorLabel.Size = new System.Drawing.Size(56, 13);
			this.HairColorLabel.TabIndex = 6;
			this.HairColorLabel.Text = "Hair Color:";
			// 
			// WriteButton
			// 
			this.WriteButton.Location = new System.Drawing.Point(15, 103);
			this.WriteButton.Name = "WriteButton";
			this.WriteButton.Size = new System.Drawing.Size(157, 23);
			this.WriteButton.TabIndex = 7;
			this.WriteButton.Text = "Write File";
			this.WriteButton.UseVisualStyleBackColor = true;
			this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(15, 132);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(97, 132);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 164);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.WriteButton);
			this.Controls.Add(this.HairColorLabel);
			this.Controls.Add(this.AgeLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.InputHairColorTextBox);
			this.Controls.Add(this.InputAgeTextBox);
			this.Controls.Add(this.InputNameTextBox);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Write Class Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox InputNameTextBox;
		private System.Windows.Forms.TextBox InputAgeTextBox;
		private System.Windows.Forms.TextBox InputHairColorTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label AgeLabel;
		private System.Windows.Forms.Label HairColorLabel;
		private System.Windows.Forms.Button WriteButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
	}
}

