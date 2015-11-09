namespace Dag {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.dayText = new System.Windows.Forms.TextBox ();
			this.dayLabel = new System.Windows.Forms.Label ();
			this.monthLabel = new System.Windows.Forms.Label ();
			this.monthText = new System.Windows.Forms.TextBox ();
			this.yearLabel = new System.Windows.Forms.Label ();
			this.yearText = new System.Windows.Forms.TextBox ();
			this.calc = new System.Windows.Forms.Button ();
			this.label = new System.Windows.Forms.Label ();
			this.day = new System.Windows.Forms.Label ();
			this.label1 = new System.Windows.Forms.Label ();
			this.febDay = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.SuspendLayout ();
			// 
			// dayText
			// 
			this.dayText.Location = new System.Drawing.Point (51, 6);
			this.dayText.Name = "dayText";
			this.dayText.Size = new System.Drawing.Size (100, 22);
			this.dayText.TabIndex = 1;
			this.dayText.TextChanged += new System.EventHandler (this.dayText_TextChanged);
			// 
			// dayLabel
			// 
			this.dayLabel.AutoSize = true;
			this.dayLabel.Location = new System.Drawing.Point (12, 9);
			this.dayLabel.Name = "dayLabel";
			this.dayLabel.Size = new System.Drawing.Size (33, 17);
			this.dayLabel.TabIndex = 1;
			this.dayLabel.Text = "Day";
			// 
			// monthLabel
			// 
			this.monthLabel.AutoSize = true;
			this.monthLabel.Location = new System.Drawing.Point (158, 10);
			this.monthLabel.Name = "monthLabel";
			this.monthLabel.Size = new System.Drawing.Size (47, 17);
			this.monthLabel.TabIndex = 2;
			this.monthLabel.Text = "Month";
			// 
			// monthText
			// 
			this.monthText.Location = new System.Drawing.Point (211, 6);
			this.monthText.Name = "monthText";
			this.monthText.Size = new System.Drawing.Size (100, 22);
			this.monthText.TabIndex = 2;
			this.monthText.TextChanged += new System.EventHandler (this.monthText_TextChanged);
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Location = new System.Drawing.Point (317, 10);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size (38, 17);
			this.yearLabel.TabIndex = 2;
			this.yearLabel.Text = "Year";
			// 
			// yearText
			// 
			this.yearText.Location = new System.Drawing.Point (361, 7);
			this.yearText.Name = "yearText";
			this.yearText.Size = new System.Drawing.Size (100, 22);
			this.yearText.TabIndex = 3;
			this.yearText.TextChanged += new System.EventHandler (this.yearText_TextChanged);
			// 
			// calc
			// 
			this.calc.Location = new System.Drawing.Point (178, 47);
			this.calc.Name = "calc";
			this.calc.Size = new System.Drawing.Size (115, 28);
			this.calc.TabIndex = 4;
			this.calc.Text = "Calculate";
			this.calc.UseVisualStyleBackColor = true;
			this.calc.Click += new System.EventHandler (this.calc_Click);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point (34, 118);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size (171, 17);
			this.label.TabIndex = 4;
			this.label.Text = "The date you entered is a";
			// 
			// day
			// 
			this.day.AutoSize = true;
			this.day.Location = new System.Drawing.Point (212, 118);
			this.day.Name = "day";
			this.day.Size = new System.Drawing.Size (0, 17);
			this.day.TabIndex = 5;
			this.day.Click += new System.EventHandler (this.day_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point (34, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (176, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "The year you entered has ";
			// 
			// febDay
			// 
			this.febDay.AutoSize = true;
			this.febDay.Location = new System.Drawing.Point (212, 92);
			this.febDay.Name = "febDay";
			this.febDay.Size = new System.Drawing.Size (0, 17);
			this.febDay.TabIndex = 5;
			this.febDay.Click += new System.EventHandler (this.day_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point (236, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (118, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "days in February.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (478, 144);
			this.Controls.Add (this.febDay);
			this.Controls.Add (this.day);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.label);
			this.Controls.Add (this.calc);
			this.Controls.Add (this.yearLabel);
			this.Controls.Add (this.monthLabel);
			this.Controls.Add (this.dayLabel);
			this.Controls.Add (this.yearText);
			this.Controls.Add (this.monthText);
			this.Controls.Add (this.dayText);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.TextBox dayText;
		private System.Windows.Forms.Label dayLabel;
		private System.Windows.Forms.Label monthLabel;
		private System.Windows.Forms.TextBox monthText;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.TextBox yearText;
		private System.Windows.Forms.Button calc;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label day;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label febDay;
		private System.Windows.Forms.Label label2;
	}
}

