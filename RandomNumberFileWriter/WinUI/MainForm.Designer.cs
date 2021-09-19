
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
			this.NumberControlBox = new System.Windows.Forms.GroupBox();
			this.DecreaseNumberButton = new System.Windows.Forms.Button();
			this.IncreaseNumberButton = new System.Windows.Forms.Button();
			this.OutputNumberLabel = new System.Windows.Forms.Label();
			this.OutputFilePathLabel = new System.Windows.Forms.Label();
			this.FilePathLabel = new System.Windows.Forms.Label();
			this.FileButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SaveFile = new System.Windows.Forms.SaveFileDialog();
			this.NumberControlBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(80, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(137, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Random Number File Writer";
			// 
			// NumberControlBox
			// 
			this.NumberControlBox.Controls.Add(this.DecreaseNumberButton);
			this.NumberControlBox.Controls.Add(this.IncreaseNumberButton);
			this.NumberControlBox.Controls.Add(this.OutputNumberLabel);
			this.NumberControlBox.Location = new System.Drawing.Point(12, 25);
			this.NumberControlBox.Name = "NumberControlBox";
			this.NumberControlBox.Size = new System.Drawing.Size(274, 47);
			this.NumberControlBox.TabIndex = 1;
			this.NumberControlBox.TabStop = false;
			this.NumberControlBox.Text = "Numbers to Write:";
			// 
			// DecreaseNumberButton
			// 
			this.DecreaseNumberButton.Location = new System.Drawing.Point(193, 16);
			this.DecreaseNumberButton.Name = "DecreaseNumberButton";
			this.DecreaseNumberButton.Size = new System.Drawing.Size(75, 23);
			this.DecreaseNumberButton.TabIndex = 2;
			this.DecreaseNumberButton.Text = "-";
			this.DecreaseNumberButton.UseVisualStyleBackColor = true;
			this.DecreaseNumberButton.Click += new System.EventHandler(this.DecreaseNumberButton_Click);
			// 
			// IncreaseNumberButton
			// 
			this.IncreaseNumberButton.Location = new System.Drawing.Point(6, 16);
			this.IncreaseNumberButton.Name = "IncreaseNumberButton";
			this.IncreaseNumberButton.Size = new System.Drawing.Size(75, 23);
			this.IncreaseNumberButton.TabIndex = 1;
			this.IncreaseNumberButton.Text = "+";
			this.IncreaseNumberButton.UseVisualStyleBackColor = true;
			this.IncreaseNumberButton.Click += new System.EventHandler(this.IncreaseNumberButton_Click);
			// 
			// OutputNumberLabel
			// 
			this.OutputNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputNumberLabel.Location = new System.Drawing.Point(87, 16);
			this.OutputNumberLabel.Name = "OutputNumberLabel";
			this.OutputNumberLabel.Size = new System.Drawing.Size(100, 23);
			this.OutputNumberLabel.TabIndex = 0;
			this.OutputNumberLabel.Text = "1";
			this.OutputNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OutputFilePathLabel
			// 
			this.OutputFilePathLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputFilePathLabel.Location = new System.Drawing.Point(66, 75);
			this.OutputFilePathLabel.Name = "OutputFilePathLabel";
			this.OutputFilePathLabel.Size = new System.Drawing.Size(220, 23);
			this.OutputFilePathLabel.TabIndex = 2;
			this.OutputFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FilePathLabel
			// 
			this.FilePathLabel.AutoSize = true;
			this.FilePathLabel.Location = new System.Drawing.Point(9, 80);
			this.FilePathLabel.Name = "FilePathLabel";
			this.FilePathLabel.Size = new System.Drawing.Size(51, 13);
			this.FilePathLabel.TabIndex = 3;
			this.FilePathLabel.Text = "File Path:";
			// 
			// FileButton
			// 
			this.FileButton.Location = new System.Drawing.Point(12, 101);
			this.FileButton.Name = "FileButton";
			this.FileButton.Size = new System.Drawing.Size(63, 23);
			this.FileButton.TabIndex = 4;
			this.FileButton.Text = "File";
			this.FileButton.UseVisualStyleBackColor = true;
			this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(81, 101);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(63, 23);
			this.SaveButton.TabIndex = 5;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(154, 101);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(63, 23);
			this.ClearButton.TabIndex = 6;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(223, 101);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(63, 23);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 135);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.FileButton);
			this.Controls.Add(this.FilePathLabel);
			this.Controls.Add(this.OutputFilePathLabel);
			this.Controls.Add(this.NumberControlBox);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Random Number File Writer";
			this.NumberControlBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.GroupBox NumberControlBox;
		private System.Windows.Forms.Label OutputNumberLabel;
		private System.Windows.Forms.Button DecreaseNumberButton;
		private System.Windows.Forms.Button IncreaseNumberButton;
		private System.Windows.Forms.Label OutputFilePathLabel;
		private System.Windows.Forms.Label FilePathLabel;
		private System.Windows.Forms.Button FileButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.SaveFileDialog SaveFile;
	}
}

