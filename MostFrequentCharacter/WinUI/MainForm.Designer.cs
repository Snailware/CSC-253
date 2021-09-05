
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
			this.GetMostFreqCharButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.MostFrequentLabel = new System.Windows.Forms.Label();
			this.OutputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(44, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(165, 17);
			this.Title.TabIndex = 0;
			this.Title.Text = "Most Frequent Character";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(12, 29);
			this.InputTextBox.Multiline = true;
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(234, 185);
			this.InputTextBox.TabIndex = 1;
			// 
			// GetMostFreqCharButton
			// 
			this.GetMostFreqCharButton.Location = new System.Drawing.Point(12, 243);
			this.GetMostFreqCharButton.Name = "GetMostFreqCharButton";
			this.GetMostFreqCharButton.Size = new System.Drawing.Size(234, 23);
			this.GetMostFreqCharButton.TabIndex = 2;
			this.GetMostFreqCharButton.Text = "Get Most Frequent Character";
			this.GetMostFreqCharButton.UseVisualStyleBackColor = true;
			this.GetMostFreqCharButton.Click += new System.EventHandler(this.GetMostFreqCharButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(12, 273);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(112, 23);
			this.ClearButton.TabIndex = 3;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(134, 273);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(112, 23);
			this.CloseButton.TabIndex = 4;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MostFrequentLabel
			// 
			this.MostFrequentLabel.AutoSize = true;
			this.MostFrequentLabel.Location = new System.Drawing.Point(12, 220);
			this.MostFrequentLabel.Name = "MostFrequentLabel";
			this.MostFrequentLabel.Size = new System.Drawing.Size(169, 17);
			this.MostFrequentLabel.TabIndex = 5;
			this.MostFrequentLabel.Text = "Most Frequent Character:";
			// 
			// OutputLabel
			// 
			this.OutputLabel.BackColor = System.Drawing.SystemColors.Window;
			this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputLabel.Location = new System.Drawing.Point(196, 217);
			this.OutputLabel.Name = "OutputLabel";
			this.OutputLabel.Size = new System.Drawing.Size(50, 23);
			this.OutputLabel.TabIndex = 6;
			this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 308);
			this.Controls.Add(this.OutputLabel);
			this.Controls.Add(this.MostFrequentLabel);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.GetMostFreqCharButton);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Most Frequent Character";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Button GetMostFreqCharButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label MostFrequentLabel;
		private System.Windows.Forms.Label OutputLabel;
	}
}