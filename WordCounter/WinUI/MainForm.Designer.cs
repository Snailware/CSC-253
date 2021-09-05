
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
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.WordCountLabel = new System.Windows.Forms.Label();
			this.OutputLabel = new System.Windows.Forms.Label();
			this.CountButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(73, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(73, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Word Counter";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(12, 25);
			this.InputTextBox.Multiline = true;
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(204, 148);
			this.InputTextBox.TabIndex = 1;
			// 
			// WordCountLabel
			// 
			this.WordCountLabel.AutoSize = true;
			this.WordCountLabel.Location = new System.Drawing.Point(9, 190);
			this.WordCountLabel.Name = "WordCountLabel";
			this.WordCountLabel.Size = new System.Drawing.Size(67, 13);
			this.WordCountLabel.TabIndex = 2;
			this.WordCountLabel.Text = "Word Count:";
			// 
			// OutputLabel
			// 
			this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputLabel.Location = new System.Drawing.Point(116, 185);
			this.OutputLabel.Name = "OutputLabel";
			this.OutputLabel.Size = new System.Drawing.Size(100, 23);
			this.OutputLabel.TabIndex = 3;
			this.OutputLabel.Text = "0";
			this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CountButton
			// 
			this.CountButton.Location = new System.Drawing.Point(12, 220);
			this.CountButton.Name = "CountButton";
			this.CountButton.Size = new System.Drawing.Size(204, 23);
			this.CountButton.TabIndex = 4;
			this.CountButton.Text = "Count Words";
			this.CountButton.UseVisualStyleBackColor = true;
			this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(12, 249);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(98, 23);
			this.ClearButton.TabIndex = 5;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(118, 249);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(98, 23);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(228, 282);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CountButton);
			this.Controls.Add(this.OutputLabel);
			this.Controls.Add(this.WordCountLabel);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Word Counter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Label WordCountLabel;
		private System.Windows.Forms.Label OutputLabel;
		private System.Windows.Forms.Button CountButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
	}
}

