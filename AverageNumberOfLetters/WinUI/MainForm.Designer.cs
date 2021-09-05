
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
			this.AverageLettersLabel = new System.Windows.Forms.Label();
			this.OutputAverageLettersLabel = new System.Windows.Forms.Label();
			this.WordCountLabel = new System.Windows.Forms.Label();
			this.OutputWordCountLabel = new System.Windows.Forms.Label();
			this.CountButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(71, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(179, 17);
			this.Title.TabIndex = 0;
			this.Title.Text = "Average Number of Letters";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(12, 29);
			this.InputTextBox.Multiline = true;
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(295, 240);
			this.InputTextBox.TabIndex = 1;
			// 
			// AverageLettersLabel
			// 
			this.AverageLettersLabel.AutoSize = true;
			this.AverageLettersLabel.Location = new System.Drawing.Point(9, 323);
			this.AverageLettersLabel.Name = "AverageLettersLabel";
			this.AverageLettersLabel.Size = new System.Drawing.Size(183, 17);
			this.AverageLettersLabel.TabIndex = 2;
			this.AverageLettersLabel.Text = "Average Number of Letters:";
			// 
			// OutputAverageLettersLabel
			// 
			this.OutputAverageLettersLabel.BackColor = System.Drawing.SystemColors.Window;
			this.OutputAverageLettersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputAverageLettersLabel.Location = new System.Drawing.Point(207, 320);
			this.OutputAverageLettersLabel.Name = "OutputAverageLettersLabel";
			this.OutputAverageLettersLabel.Size = new System.Drawing.Size(100, 23);
			this.OutputAverageLettersLabel.TabIndex = 3;
			this.OutputAverageLettersLabel.Text = "0";
			this.OutputAverageLettersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// WordCountLabel
			// 
			this.WordCountLabel.AutoSize = true;
			this.WordCountLabel.Location = new System.Drawing.Point(9, 284);
			this.WordCountLabel.Name = "WordCountLabel";
			this.WordCountLabel.Size = new System.Drawing.Size(123, 17);
			this.WordCountLabel.TabIndex = 4;
			this.WordCountLabel.Text = "Number of Words:";
			// 
			// OutputWordCountLabel
			// 
			this.OutputWordCountLabel.BackColor = System.Drawing.SystemColors.Window;
			this.OutputWordCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputWordCountLabel.Location = new System.Drawing.Point(207, 281);
			this.OutputWordCountLabel.Name = "OutputWordCountLabel";
			this.OutputWordCountLabel.Size = new System.Drawing.Size(100, 23);
			this.OutputWordCountLabel.TabIndex = 5;
			this.OutputWordCountLabel.Text = "0";
			this.OutputWordCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CountButton
			// 
			this.CountButton.Location = new System.Drawing.Point(12, 363);
			this.CountButton.Name = "CountButton";
			this.CountButton.Size = new System.Drawing.Size(94, 23);
			this.CountButton.TabIndex = 6;
			this.CountButton.Text = "Count";
			this.CountButton.UseVisualStyleBackColor = true;
			this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(113, 363);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(94, 23);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(213, 363);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(94, 23);
			this.CloseButton.TabIndex = 8;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 404);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CountButton);
			this.Controls.Add(this.OutputWordCountLabel);
			this.Controls.Add(this.WordCountLabel);
			this.Controls.Add(this.OutputAverageLettersLabel);
			this.Controls.Add(this.AverageLettersLabel);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Average Number Of Letters";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Label AverageLettersLabel;
		private System.Windows.Forms.Label OutputAverageLettersLabel;
		private System.Windows.Forms.Label WordCountLabel;
		private System.Windows.Forms.Label OutputWordCountLabel;
		private System.Windows.Forms.Button CountButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
	}
}

