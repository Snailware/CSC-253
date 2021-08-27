
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
			this.AccelerateButton = new System.Windows.Forms.Button();
			this.BrakeButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.SpeedOutputLabel = new System.Windows.Forms.Label();
			this.SpeedLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AccelerateButton
			// 
			this.AccelerateButton.BackColor = System.Drawing.Color.LimeGreen;
			this.AccelerateButton.Location = new System.Drawing.Point(20, 76);
			this.AccelerateButton.Name = "AccelerateButton";
			this.AccelerateButton.Size = new System.Drawing.Size(75, 23);
			this.AccelerateButton.TabIndex = 0;
			this.AccelerateButton.Text = "Accelerate";
			this.AccelerateButton.UseVisualStyleBackColor = false;
			this.AccelerateButton.Click += new System.EventHandler(this.AccelerateButton_Click);
			// 
			// BrakeButton
			// 
			this.BrakeButton.BackColor = System.Drawing.Color.Red;
			this.BrakeButton.Location = new System.Drawing.Point(101, 76);
			this.BrakeButton.Name = "BrakeButton";
			this.BrakeButton.Size = new System.Drawing.Size(75, 23);
			this.BrakeButton.TabIndex = 1;
			this.BrakeButton.Text = "Brake";
			this.BrakeButton.UseVisualStyleBackColor = false;
			this.BrakeButton.Click += new System.EventHandler(this.BrakeButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(182, 76);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(113, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(51, 13);
			this.Title.TabIndex = 3;
			this.Title.Text = "Car Class";
			// 
			// SpeedOutputLabel
			// 
			this.SpeedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.SpeedOutputLabel.Location = new System.Drawing.Point(128, 38);
			this.SpeedOutputLabel.Name = "SpeedOutputLabel";
			this.SpeedOutputLabel.Size = new System.Drawing.Size(100, 23);
			this.SpeedOutputLabel.TabIndex = 4;
			this.SpeedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SpeedLabel
			// 
			this.SpeedLabel.AutoSize = true;
			this.SpeedLabel.Location = new System.Drawing.Point(51, 43);
			this.SpeedLabel.Name = "SpeedLabel";
			this.SpeedLabel.Size = new System.Drawing.Size(60, 13);
			this.SpeedLabel.TabIndex = 5;
			this.SpeedLabel.Text = "Car Speed:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 109);
			this.Controls.Add(this.SpeedLabel);
			this.Controls.Add(this.SpeedOutputLabel);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.BrakeButton);
			this.Controls.Add(this.AccelerateButton);
			this.Name = "Form1";
			this.Text = "Car Class";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AccelerateButton;
		private System.Windows.Forms.Button BrakeButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label SpeedOutputLabel;
		private System.Windows.Forms.Label SpeedLabel;
	}
}

