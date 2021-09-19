
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
			this.FilePathLabel = new System.Windows.Forms.Label();
			this.OutputFilePathLabel = new System.Windows.Forms.Label();
			this.OutputNumbersListBox = new System.Windows.Forms.ListBox();
			this.NumbersListLabel = new System.Windows.Forms.Label();
			this.SumLabel = new System.Windows.Forms.Label();
			this.OutputSumLabel = new System.Windows.Forms.Label();
			this.NumbersReadLabel = new System.Windows.Forms.Label();
			this.OutputNumberCountLabel = new System.Windows.Forms.Label();
			this.FileButton = new System.Windows.Forms.Button();
			this.ReadButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(114, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(144, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Random Number File Reader";
			// 
			// FilePathLabel
			// 
			this.FilePathLabel.AutoSize = true;
			this.FilePathLabel.Location = new System.Drawing.Point(12, 33);
			this.FilePathLabel.Name = "FilePathLabel";
			this.FilePathLabel.Size = new System.Drawing.Size(51, 13);
			this.FilePathLabel.TabIndex = 1;
			this.FilePathLabel.Text = "File Path:";
			// 
			// OutputFilePathLabel
			// 
			this.OutputFilePathLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputFilePathLabel.Location = new System.Drawing.Point(69, 28);
			this.OutputFilePathLabel.Name = "OutputFilePathLabel";
			this.OutputFilePathLabel.Size = new System.Drawing.Size(280, 23);
			this.OutputFilePathLabel.TabIndex = 2;
			this.OutputFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OutputNumbersListBox
			// 
			this.OutputNumbersListBox.FormattingEnabled = true;
			this.OutputNumbersListBox.Location = new System.Drawing.Point(15, 76);
			this.OutputNumbersListBox.Name = "OutputNumbersListBox";
			this.OutputNumbersListBox.Size = new System.Drawing.Size(120, 82);
			this.OutputNumbersListBox.TabIndex = 3;
			// 
			// NumbersListLabel
			// 
			this.NumbersListLabel.AutoSize = true;
			this.NumbersListLabel.Location = new System.Drawing.Point(33, 60);
			this.NumbersListLabel.Name = "NumbersListLabel";
			this.NumbersListLabel.Size = new System.Drawing.Size(82, 13);
			this.NumbersListLabel.TabIndex = 4;
			this.NumbersListLabel.Text = "Numbers in File:";
			// 
			// SumLabel
			// 
			this.SumLabel.AutoSize = true;
			this.SumLabel.Location = new System.Drawing.Point(147, 60);
			this.SumLabel.Name = "SumLabel";
			this.SumLabel.Size = new System.Drawing.Size(88, 13);
			this.SumLabel.TabIndex = 5;
			this.SumLabel.Text = "Sum of Numbers:";
			// 
			// OutputSumLabel
			// 
			this.OutputSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputSumLabel.Location = new System.Drawing.Point(141, 76);
			this.OutputSumLabel.Name = "OutputSumLabel";
			this.OutputSumLabel.Size = new System.Drawing.Size(100, 23);
			this.OutputSumLabel.TabIndex = 6;
			this.OutputSumLabel.Text = "0";
			this.OutputSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NumbersReadLabel
			// 
			this.NumbersReadLabel.AutoSize = true;
			this.NumbersReadLabel.Location = new System.Drawing.Point(258, 60);
			this.NumbersReadLabel.Name = "NumbersReadLabel";
			this.NumbersReadLabel.Size = new System.Drawing.Size(81, 13);
			this.NumbersReadLabel.TabIndex = 7;
			this.NumbersReadLabel.Text = "Numbers Read:";
			// 
			// OutputNumberCountLabel
			// 
			this.OutputNumberCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputNumberCountLabel.Location = new System.Drawing.Point(249, 76);
			this.OutputNumberCountLabel.Name = "OutputNumberCountLabel";
			this.OutputNumberCountLabel.Size = new System.Drawing.Size(100, 23);
			this.OutputNumberCountLabel.TabIndex = 8;
			this.OutputNumberCountLabel.Text = "0";
			this.OutputNumberCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FileButton
			// 
			this.FileButton.Location = new System.Drawing.Point(15, 164);
			this.FileButton.Name = "FileButton";
			this.FileButton.Size = new System.Drawing.Size(80, 23);
			this.FileButton.TabIndex = 9;
			this.FileButton.Text = "File";
			this.FileButton.UseVisualStyleBackColor = true;
			this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
			// 
			// ReadButton
			// 
			this.ReadButton.Location = new System.Drawing.Point(101, 164);
			this.ReadButton.Name = "ReadButton";
			this.ReadButton.Size = new System.Drawing.Size(80, 23);
			this.ReadButton.TabIndex = 10;
			this.ReadButton.Text = "Read";
			this.ReadButton.UseVisualStyleBackColor = true;
			this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(188, 164);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(80, 23);
			this.ClearButton.TabIndex = 11;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(274, 164);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(80, 23);
			this.ExitButton.TabIndex = 12;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 202);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ReadButton);
			this.Controls.Add(this.FileButton);
			this.Controls.Add(this.OutputNumberCountLabel);
			this.Controls.Add(this.NumbersReadLabel);
			this.Controls.Add(this.OutputSumLabel);
			this.Controls.Add(this.SumLabel);
			this.Controls.Add(this.NumbersListLabel);
			this.Controls.Add(this.OutputNumbersListBox);
			this.Controls.Add(this.OutputFilePathLabel);
			this.Controls.Add(this.FilePathLabel);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Random Number File Reader";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label FilePathLabel;
		private System.Windows.Forms.Label OutputFilePathLabel;
		private System.Windows.Forms.ListBox OutputNumbersListBox;
		private System.Windows.Forms.Label NumbersListLabel;
		private System.Windows.Forms.Label SumLabel;
		private System.Windows.Forms.Label OutputSumLabel;
		private System.Windows.Forms.Label NumbersReadLabel;
		private System.Windows.Forms.Label OutputNumberCountLabel;
		private System.Windows.Forms.Button FileButton;
		private System.Windows.Forms.Button ReadButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.OpenFileDialog OpenFile;
	}
}

