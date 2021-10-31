
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
			this.LabelString = new System.Windows.Forms.Label();
			this.StringToCharArrayButton = new System.Windows.Forms.Button();
			this.DateToStringArrayButton = new System.Windows.Forms.Button();
			this.StringToPhoneNumberButton = new System.Windows.Forms.Button();
			this.ReverseStringButton = new System.Windows.Forms.Button();
			this.CountWordsButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(58, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(168, 17);
			this.Title.TabIndex = 0;
			this.Title.Text = "String Extension Methods";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(61, 29);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(209, 22);
			this.InputTextBox.TabIndex = 1;
			// 
			// LabelString
			// 
			this.LabelString.AutoSize = true;
			this.LabelString.Location = new System.Drawing.Point(12, 32);
			this.LabelString.Name = "LabelString";
			this.LabelString.Size = new System.Drawing.Size(49, 17);
			this.LabelString.TabIndex = 2;
			this.LabelString.Text = "String:";
			// 
			// StringToCharArrayButton
			// 
			this.StringToCharArrayButton.Location = new System.Drawing.Point(15, 57);
			this.StringToCharArrayButton.Name = "StringToCharArrayButton";
			this.StringToCharArrayButton.Size = new System.Drawing.Size(255, 23);
			this.StringToCharArrayButton.TabIndex = 3;
			this.StringToCharArrayButton.Text = "String to Char Array";
			this.StringToCharArrayButton.UseVisualStyleBackColor = true;
			this.StringToCharArrayButton.Click += new System.EventHandler(this.StringToCharArrayButton_Click);
			// 
			// DateToStringArrayButton
			// 
			this.DateToStringArrayButton.Location = new System.Drawing.Point(15, 86);
			this.DateToStringArrayButton.Name = "DateToStringArrayButton";
			this.DateToStringArrayButton.Size = new System.Drawing.Size(255, 23);
			this.DateToStringArrayButton.TabIndex = 4;
			this.DateToStringArrayButton.Text = "Date to String Array";
			this.DateToStringArrayButton.UseVisualStyleBackColor = true;
			this.DateToStringArrayButton.Click += new System.EventHandler(this.DateToStringArrayButton_Click);
			// 
			// StringToPhoneNumberButton
			// 
			this.StringToPhoneNumberButton.Location = new System.Drawing.Point(15, 115);
			this.StringToPhoneNumberButton.Name = "StringToPhoneNumberButton";
			this.StringToPhoneNumberButton.Size = new System.Drawing.Size(255, 23);
			this.StringToPhoneNumberButton.TabIndex = 5;
			this.StringToPhoneNumberButton.Text = "String to Phone Number";
			this.StringToPhoneNumberButton.UseVisualStyleBackColor = true;
			this.StringToPhoneNumberButton.Click += new System.EventHandler(this.StringToPhoneNumberButton_Click);
			// 
			// ReverseStringButton
			// 
			this.ReverseStringButton.Location = new System.Drawing.Point(15, 144);
			this.ReverseStringButton.Name = "ReverseStringButton";
			this.ReverseStringButton.Size = new System.Drawing.Size(255, 23);
			this.ReverseStringButton.TabIndex = 6;
			this.ReverseStringButton.Text = "Reverse String";
			this.ReverseStringButton.UseVisualStyleBackColor = true;
			this.ReverseStringButton.Click += new System.EventHandler(this.ReverseStringButton_Click);
			// 
			// CountWordsButton
			// 
			this.CountWordsButton.Location = new System.Drawing.Point(15, 173);
			this.CountWordsButton.Name = "CountWordsButton";
			this.CountWordsButton.Size = new System.Drawing.Size(255, 23);
			this.CountWordsButton.TabIndex = 7;
			this.CountWordsButton.Text = "Count Words";
			this.CountWordsButton.UseVisualStyleBackColor = true;
			this.CountWordsButton.Click += new System.EventHandler(this.CountWordsButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(15, 202);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(255, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(15, 231);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(255, 23);
			this.CloseButton.TabIndex = 9;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 268);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CountWordsButton);
			this.Controls.Add(this.ReverseStringButton);
			this.Controls.Add(this.StringToPhoneNumberButton);
			this.Controls.Add(this.DateToStringArrayButton);
			this.Controls.Add(this.StringToCharArrayButton);
			this.Controls.Add(this.LabelString);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.Title);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "String Extension Methods";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Label LabelString;
		private System.Windows.Forms.Button StringToCharArrayButton;
		private System.Windows.Forms.Button DateToStringArrayButton;
		private System.Windows.Forms.Button StringToPhoneNumberButton;
		private System.Windows.Forms.Button ReverseStringButton;
		private System.Windows.Forms.Button CountWordsButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
	}
}

