
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
			this.ConvertButton = new System.Windows.Forms.Button();
			this.TempListBox = new System.Windows.Forms.ListBox();
			this.Title = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ConvertButton
			// 
			this.ConvertButton.Location = new System.Drawing.Point(12, 319);
			this.ConvertButton.Name = "ConvertButton";
			this.ConvertButton.Size = new System.Drawing.Size(75, 23);
			this.ConvertButton.TabIndex = 0;
			this.ConvertButton.Text = "Convert";
			this.ConvertButton.UseVisualStyleBackColor = true;
			this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
			// 
			// TempListBox
			// 
			this.TempListBox.FormattingEnabled = true;
			this.TempListBox.Location = new System.Drawing.Point(12, 25);
			this.TempListBox.Name = "TempListBox";
			this.TempListBox.Size = new System.Drawing.Size(237, 277);
			this.TempListBox.TabIndex = 1;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(53, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(158, 13);
			this.Title.TabIndex = 2;
			this.Title.Text = "Celsius To Fahrenheit Converter";
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(93, 319);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 3;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(174, 319);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 4;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 358);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.TempListBox);
			this.Controls.Add(this.ConvertButton);
			this.Name = "Form1";
			this.Text = "CelsiusToFahrenheit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.ListBox TempListBox;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
	}
}

