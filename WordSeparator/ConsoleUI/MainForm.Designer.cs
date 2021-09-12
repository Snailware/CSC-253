
namespace ConsoleUI
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
			this.WordsIOTextBox = new System.Windows.Forms.TextBox();
			this.Title = new System.Windows.Forms.Label();
			this.SeparateButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// WordsIOTextBox
			// 
			this.WordsIOTextBox.Location = new System.Drawing.Point(12, 25);
			this.WordsIOTextBox.Multiline = true;
			this.WordsIOTextBox.Name = "WordsIOTextBox";
			this.WordsIOTextBox.Size = new System.Drawing.Size(241, 185);
			this.WordsIOTextBox.TabIndex = 0;
			this.WordsIOTextBox.Text = "EnterSomePascalCaseTextHere!";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(92, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(82, 13);
			this.Title.TabIndex = 1;
			this.Title.Text = "Word Separator";
			// 
			// SeparateButton
			// 
			this.SeparateButton.Location = new System.Drawing.Point(12, 216);
			this.SeparateButton.Name = "SeparateButton";
			this.SeparateButton.Size = new System.Drawing.Size(75, 23);
			this.SeparateButton.TabIndex = 2;
			this.SeparateButton.Text = "Separate";
			this.SeparateButton.UseVisualStyleBackColor = true;
			this.SeparateButton.Click += new System.EventHandler(this.SeparateButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(95, 216);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 3;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(178, 216);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 4;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 248);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.SeparateButton);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.WordsIOTextBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Word Separator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox WordsIOTextBox;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button SeparateButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
	}
}

