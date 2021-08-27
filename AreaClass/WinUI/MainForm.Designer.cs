
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
			this.ShapeSelectBox = new System.Windows.Forms.GroupBox();
			this.CylinderRadioButton = new System.Windows.Forms.RadioButton();
			this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
			this.CircleRadioButton = new System.Windows.Forms.RadioButton();
			this.Title = new System.Windows.Forms.Label();
			this.RadiusLabel = new System.Windows.Forms.Label();
			this.WidthLabel = new System.Windows.Forms.Label();
			this.LengthLabel = new System.Windows.Forms.Label();
			this.HeightLabel = new System.Windows.Forms.Label();
			this.AreaLabel = new System.Windows.Forms.Label();
			this.InputBox = new System.Windows.Forms.GroupBox();
			this.HeightTextBox = new System.Windows.Forms.TextBox();
			this.LengthTextBox = new System.Windows.Forms.TextBox();
			this.WidthTextBox = new System.Windows.Forms.TextBox();
			this.RadiusTextBox = new System.Windows.Forms.TextBox();
			this.OutputBox = new System.Windows.Forms.GroupBox();
			this.AreaOutputLabel = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.ShapeSelectBox.SuspendLayout();
			this.InputBox.SuspendLayout();
			this.OutputBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// ShapeSelectBox
			// 
			this.ShapeSelectBox.Controls.Add(this.CylinderRadioButton);
			this.ShapeSelectBox.Controls.Add(this.RectangleRadioButton);
			this.ShapeSelectBox.Controls.Add(this.CircleRadioButton);
			this.ShapeSelectBox.Location = new System.Drawing.Point(23, 25);
			this.ShapeSelectBox.Name = "ShapeSelectBox";
			this.ShapeSelectBox.Size = new System.Drawing.Size(222, 44);
			this.ShapeSelectBox.TabIndex = 0;
			this.ShapeSelectBox.TabStop = false;
			this.ShapeSelectBox.Text = "Choose a Shape";
			// 
			// CylinderRadioButton
			// 
			this.CylinderRadioButton.AutoSize = true;
			this.CylinderRadioButton.Location = new System.Drawing.Point(151, 19);
			this.CylinderRadioButton.Name = "CylinderRadioButton";
			this.CylinderRadioButton.Size = new System.Drawing.Size(62, 17);
			this.CylinderRadioButton.TabIndex = 2;
			this.CylinderRadioButton.TabStop = true;
			this.CylinderRadioButton.Text = "Cylinder";
			this.CylinderRadioButton.UseVisualStyleBackColor = true;
			this.CylinderRadioButton.CheckedChanged += new System.EventHandler(this.CylinderRadioButton_CheckedChanged);
			// 
			// RectangleRadioButton
			// 
			this.RectangleRadioButton.AutoSize = true;
			this.RectangleRadioButton.Location = new System.Drawing.Point(71, 19);
			this.RectangleRadioButton.Name = "RectangleRadioButton";
			this.RectangleRadioButton.Size = new System.Drawing.Size(74, 17);
			this.RectangleRadioButton.TabIndex = 1;
			this.RectangleRadioButton.TabStop = true;
			this.RectangleRadioButton.Text = "Rectangle";
			this.RectangleRadioButton.UseVisualStyleBackColor = true;
			this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
			// 
			// CircleRadioButton
			// 
			this.CircleRadioButton.AutoSize = true;
			this.CircleRadioButton.Location = new System.Drawing.Point(14, 19);
			this.CircleRadioButton.Name = "CircleRadioButton";
			this.CircleRadioButton.Size = new System.Drawing.Size(51, 17);
			this.CircleRadioButton.TabIndex = 0;
			this.CircleRadioButton.TabStop = true;
			this.CircleRadioButton.Text = "Circle";
			this.CircleRadioButton.UseVisualStyleBackColor = true;
			this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.CircleRadioButton_CheckedChanged);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(89, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(79, 13);
			this.Title.TabIndex = 1;
			this.Title.Text = "Area Calculator";
			// 
			// RadiusLabel
			// 
			this.RadiusLabel.AutoSize = true;
			this.RadiusLabel.Location = new System.Drawing.Point(6, 25);
			this.RadiusLabel.Name = "RadiusLabel";
			this.RadiusLabel.Size = new System.Drawing.Size(43, 13);
			this.RadiusLabel.TabIndex = 2;
			this.RadiusLabel.Text = "Radius:";
			// 
			// WidthLabel
			// 
			this.WidthLabel.AutoSize = true;
			this.WidthLabel.Location = new System.Drawing.Point(11, 50);
			this.WidthLabel.Name = "WidthLabel";
			this.WidthLabel.Size = new System.Drawing.Size(38, 13);
			this.WidthLabel.TabIndex = 3;
			this.WidthLabel.Text = "Width:";
			// 
			// LengthLabel
			// 
			this.LengthLabel.AutoSize = true;
			this.LengthLabel.Location = new System.Drawing.Point(6, 75);
			this.LengthLabel.Name = "LengthLabel";
			this.LengthLabel.Size = new System.Drawing.Size(43, 13);
			this.LengthLabel.TabIndex = 4;
			this.LengthLabel.Text = "Length:";
			// 
			// HeightLabel
			// 
			this.HeightLabel.AutoSize = true;
			this.HeightLabel.Location = new System.Drawing.Point(8, 99);
			this.HeightLabel.Name = "HeightLabel";
			this.HeightLabel.Size = new System.Drawing.Size(41, 13);
			this.HeightLabel.TabIndex = 5;
			this.HeightLabel.Text = "Height:";
			// 
			// AreaLabel
			// 
			this.AreaLabel.AutoSize = true;
			this.AreaLabel.Location = new System.Drawing.Point(17, 16);
			this.AreaLabel.Name = "AreaLabel";
			this.AreaLabel.Size = new System.Drawing.Size(32, 13);
			this.AreaLabel.TabIndex = 6;
			this.AreaLabel.Text = "Area:";
			// 
			// InputBox
			// 
			this.InputBox.Controls.Add(this.HeightTextBox);
			this.InputBox.Controls.Add(this.LengthTextBox);
			this.InputBox.Controls.Add(this.WidthTextBox);
			this.InputBox.Controls.Add(this.RadiusTextBox);
			this.InputBox.Controls.Add(this.RadiusLabel);
			this.InputBox.Controls.Add(this.WidthLabel);
			this.InputBox.Controls.Add(this.HeightLabel);
			this.InputBox.Controls.Add(this.LengthLabel);
			this.InputBox.Location = new System.Drawing.Point(23, 75);
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(222, 123);
			this.InputBox.TabIndex = 7;
			this.InputBox.TabStop = false;
			this.InputBox.Text = "Input Dimensions";
			// 
			// HeightTextBox
			// 
			this.HeightTextBox.Enabled = false;
			this.HeightTextBox.Location = new System.Drawing.Point(116, 96);
			this.HeightTextBox.Name = "HeightTextBox";
			this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
			this.HeightTextBox.TabIndex = 9;
			this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// LengthTextBox
			// 
			this.LengthTextBox.Enabled = false;
			this.LengthTextBox.Location = new System.Drawing.Point(116, 72);
			this.LengthTextBox.Name = "LengthTextBox";
			this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
			this.LengthTextBox.TabIndex = 8;
			this.LengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// WidthTextBox
			// 
			this.WidthTextBox.Enabled = false;
			this.WidthTextBox.Location = new System.Drawing.Point(116, 47);
			this.WidthTextBox.Name = "WidthTextBox";
			this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
			this.WidthTextBox.TabIndex = 7;
			this.WidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// RadiusTextBox
			// 
			this.RadiusTextBox.Enabled = false;
			this.RadiusTextBox.Location = new System.Drawing.Point(116, 22);
			this.RadiusTextBox.Name = "RadiusTextBox";
			this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
			this.RadiusTextBox.TabIndex = 6;
			this.RadiusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// OutputBox
			// 
			this.OutputBox.Controls.Add(this.AreaOutputLabel);
			this.OutputBox.Controls.Add(this.AreaLabel);
			this.OutputBox.Location = new System.Drawing.Point(23, 204);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.Size = new System.Drawing.Size(222, 40);
			this.OutputBox.TabIndex = 8;
			this.OutputBox.TabStop = false;
			this.OutputBox.Text = "Output";
			// 
			// AreaOutputLabel
			// 
			this.AreaOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.AreaOutputLabel.Location = new System.Drawing.Point(116, 12);
			this.AreaOutputLabel.Name = "AreaOutputLabel";
			this.AreaOutputLabel.Size = new System.Drawing.Size(100, 20);
			this.AreaOutputLabel.TabIndex = 7;
			this.AreaOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(23, 250);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(70, 23);
			this.CalculateButton.TabIndex = 9;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(99, 250);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(70, 23);
			this.ClearButton.TabIndex = 10;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(175, 250);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(70, 23);
			this.CloseButton.TabIndex = 11;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 285);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.OutputBox);
			this.Controls.Add(this.InputBox);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.ShapeSelectBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Area Calculator";
			this.ShapeSelectBox.ResumeLayout(false);
			this.ShapeSelectBox.PerformLayout();
			this.InputBox.ResumeLayout(false);
			this.InputBox.PerformLayout();
			this.OutputBox.ResumeLayout(false);
			this.OutputBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox ShapeSelectBox;
		private System.Windows.Forms.RadioButton CylinderRadioButton;
		private System.Windows.Forms.RadioButton RectangleRadioButton;
		private System.Windows.Forms.RadioButton CircleRadioButton;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label RadiusLabel;
		private System.Windows.Forms.Label WidthLabel;
		private System.Windows.Forms.Label LengthLabel;
		private System.Windows.Forms.Label HeightLabel;
		private System.Windows.Forms.Label AreaLabel;
		private System.Windows.Forms.GroupBox InputBox;
		private System.Windows.Forms.TextBox HeightTextBox;
		private System.Windows.Forms.TextBox LengthTextBox;
		private System.Windows.Forms.TextBox WidthTextBox;
		private System.Windows.Forms.TextBox RadiusTextBox;
		private System.Windows.Forms.GroupBox OutputBox;
		private System.Windows.Forms.Label AreaOutputLabel;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CloseButton;
	}
}

