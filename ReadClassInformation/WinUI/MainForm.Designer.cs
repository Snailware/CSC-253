
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
			this.FileDialog = new System.Windows.Forms.OpenFileDialog();
			this.Title = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.HairColorLabel = new System.Windows.Forms.Label();
			this.AgeLabel = new System.Windows.Forms.Label();
			this.OutputNameLabel = new System.Windows.Forms.Label();
			this.OutputHairColorLabel = new System.Windows.Forms.Label();
			this.OutputAgeLabel = new System.Windows.Forms.Label();
			this.ReadButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FileDialog
			// 
			this.FileDialog.FileName = "openFileDialog1";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(48, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(82, 13);
			this.Title.TabIndex = 0;
			this.Title.Text = "Read Class Info";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(12, 33);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(38, 13);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Name:";
			// 
			// HairColorLabel
			// 
			this.HairColorLabel.AutoSize = true;
			this.HairColorLabel.Location = new System.Drawing.Point(12, 62);
			this.HairColorLabel.Name = "HairColorLabel";
			this.HairColorLabel.Size = new System.Drawing.Size(56, 13);
			this.HairColorLabel.TabIndex = 2;
			this.HairColorLabel.Text = "Hair Color:";
			// 
			// AgeLabel
			// 
			this.AgeLabel.AutoSize = true;
			this.AgeLabel.Location = new System.Drawing.Point(12, 91);
			this.AgeLabel.Name = "AgeLabel";
			this.AgeLabel.Size = new System.Drawing.Size(29, 13);
			this.AgeLabel.TabIndex = 3;
			this.AgeLabel.Text = "Age:";
			// 
			// OutputNameLabel
			// 
			this.OutputNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputNameLabel.Location = new System.Drawing.Point(74, 28);
			this.OutputNameLabel.Margin = new System.Windows.Forms.Padding(3);
			this.OutputNameLabel.Name = "OutputNameLabel";
			this.OutputNameLabel.Size = new System.Drawing.Size(110, 23);
			this.OutputNameLabel.TabIndex = 4;
			this.OutputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OutputHairColorLabel
			// 
			this.OutputHairColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputHairColorLabel.Location = new System.Drawing.Point(74, 57);
			this.OutputHairColorLabel.Margin = new System.Windows.Forms.Padding(3);
			this.OutputHairColorLabel.Name = "OutputHairColorLabel";
			this.OutputHairColorLabel.Size = new System.Drawing.Size(110, 23);
			this.OutputHairColorLabel.TabIndex = 5;
			this.OutputHairColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OutputAgeLabel
			// 
			this.OutputAgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OutputAgeLabel.Location = new System.Drawing.Point(74, 86);
			this.OutputAgeLabel.Margin = new System.Windows.Forms.Padding(3);
			this.OutputAgeLabel.Name = "OutputAgeLabel";
			this.OutputAgeLabel.Size = new System.Drawing.Size(110, 23);
			this.OutputAgeLabel.TabIndex = 6;
			this.OutputAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ReadButton
			// 
			this.ReadButton.Location = new System.Drawing.Point(15, 115);
			this.ReadButton.Name = "ReadButton";
			this.ReadButton.Size = new System.Drawing.Size(169, 23);
			this.ReadButton.TabIndex = 7;
			this.ReadButton.Text = "Read File";
			this.ReadButton.UseVisualStyleBackColor = true;
			this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(15, 144);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(82, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(102, 144);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(82, 23);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 177);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ReadButton);
			this.Controls.Add(this.OutputAgeLabel);
			this.Controls.Add(this.OutputHairColorLabel);
			this.Controls.Add(this.OutputNameLabel);
			this.Controls.Add(this.AgeLabel);
			this.Controls.Add(this.HairColorLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Read Class Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog FileDialog;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label HairColorLabel;
		private System.Windows.Forms.Label AgeLabel;
		private System.Windows.Forms.Label OutputNameLabel;
		private System.Windows.Forms.Label OutputHairColorLabel;
		private System.Windows.Forms.Label OutputAgeLabel;
		private System.Windows.Forms.Button ReadButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
	}
}

