namespace HospitalCharges
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
			this.daysLabel = new System.Windows.Forms.Label();
			this.medLabel = new System.Windows.Forms.Label();
			this.surgicalLabel = new System.Windows.Forms.Label();
			this.labLabel = new System.Windows.Forms.Label();
			this.rehabLabel = new System.Windows.Forms.Label();
			this.daysTextBox = new System.Windows.Forms.TextBox();
			this.medTextBox = new System.Windows.Forms.TextBox();
			this.surgicalTextBox = new System.Windows.Forms.TextBox();
			this.labTextBox = new System.Windows.Forms.TextBox();
			this.rehabTextBox = new System.Windows.Forms.TextBox();
			this.calculateButton = new System.Windows.Forms.Button();
			this.totalLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.dateTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// daysLabel
			// 
			this.daysLabel.AutoSize = true;
			this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.daysLabel.Location = new System.Drawing.Point(300, 46);
			this.daysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.daysLabel.Name = "daysLabel";
			this.daysLabel.Size = new System.Drawing.Size(180, 17);
			this.daysLabel.TabIndex = 0;
			this.daysLabel.Text = "Number of days in hospital:";
			// 
			// medLabel
			// 
			this.medLabel.AutoSize = true;
			this.medLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.medLabel.Location = new System.Drawing.Point(341, 89);
			this.medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.medLabel.Name = "medLabel";
			this.medLabel.Size = new System.Drawing.Size(135, 17);
			this.medLabel.TabIndex = 1;
			this.medLabel.Text = "Medication charges:";
			// 
			// surgicalLabel
			// 
			this.surgicalLabel.AutoSize = true;
			this.surgicalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.surgicalLabel.Location = new System.Drawing.Point(360, 140);
			this.surgicalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.surgicalLabel.Name = "surgicalLabel";
			this.surgicalLabel.Size = new System.Drawing.Size(118, 17);
			this.surgicalLabel.TabIndex = 2;
			this.surgicalLabel.Text = "Surgical charges:";
			// 
			// labLabel
			// 
			this.labLabel.AutoSize = true;
			this.labLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labLabel.Location = new System.Drawing.Point(411, 190);
			this.labLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labLabel.Name = "labLabel";
			this.labLabel.Size = new System.Drawing.Size(67, 17);
			this.labLabel.TabIndex = 3;
			this.labLabel.Text = "Lab fees:";
			// 
			// rehabLabel
			// 
			this.rehabLabel.AutoSize = true;
			this.rehabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rehabLabel.Location = new System.Drawing.Point(276, 239);
			this.rehabLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.rehabLabel.Name = "rehabLabel";
			this.rehabLabel.Size = new System.Drawing.Size(204, 17);
			this.rehabLabel.TabIndex = 4;
			this.rehabLabel.Text = "Physical rehabilitation charges:";
			// 
			// daysTextBox
			// 
			this.daysTextBox.Location = new System.Drawing.Point(487, 42);
			this.daysTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.daysTextBox.Name = "daysTextBox";
			this.daysTextBox.Size = new System.Drawing.Size(132, 23);
			this.daysTextBox.TabIndex = 5;
			// 
			// medTextBox
			// 
			this.medTextBox.Location = new System.Drawing.Point(487, 89);
			this.medTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.medTextBox.Name = "medTextBox";
			this.medTextBox.Size = new System.Drawing.Size(132, 23);
			this.medTextBox.TabIndex = 6;
			// 
			// surgicalTextBox
			// 
			this.surgicalTextBox.Location = new System.Drawing.Point(487, 140);
			this.surgicalTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.surgicalTextBox.Name = "surgicalTextBox";
			this.surgicalTextBox.Size = new System.Drawing.Size(132, 23);
			this.surgicalTextBox.TabIndex = 7;
			// 
			// labTextBox
			// 
			this.labTextBox.Location = new System.Drawing.Point(487, 186);
			this.labTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.labTextBox.Name = "labTextBox";
			this.labTextBox.Size = new System.Drawing.Size(132, 23);
			this.labTextBox.TabIndex = 8;
			// 
			// rehabTextBox
			// 
			this.rehabTextBox.Location = new System.Drawing.Point(487, 235);
			this.rehabTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.rehabTextBox.Name = "rehabTextBox";
			this.rehabTextBox.Size = new System.Drawing.Size(132, 23);
			this.rehabTextBox.TabIndex = 9;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(699, 89);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(84, 42);
			this.calculateButton.TabIndex = 10;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Location = new System.Drawing.Point(696, 186);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(44, 17);
			this.totalLabel.TabIndex = 11;
			this.totalLabel.Text = "Total:";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(383, 315);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(43, 17);
			this.timeLabel.TabIndex = 12;
			this.timeLabel.Text = "Time:";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(383, 377);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(42, 17);
			this.dateLabel.TabIndex = 13;
			this.dateLabel.Text = "Date:";
			// 
			// timeTextBox
			// 
			this.timeTextBox.Location = new System.Drawing.Point(441, 315);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(100, 23);
			this.timeTextBox.TabIndex = 14;
			// 
			// dateTextBox
			// 
			this.dateTextBox.Location = new System.Drawing.Point(441, 374);
			this.dateTextBox.Name = "dateTextBox";
			this.dateTextBox.Size = new System.Drawing.Size(100, 23);
			this.dateTextBox.TabIndex = 15;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(611, 332);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 39);
			this.saveButton.TabIndex = 16;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.dateTextBox);
			this.Controls.Add(this.timeTextBox);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.rehabTextBox);
			this.Controls.Add(this.labTextBox);
			this.Controls.Add(this.surgicalTextBox);
			this.Controls.Add(this.medTextBox);
			this.Controls.Add(this.daysTextBox);
			this.Controls.Add(this.rehabLabel);
			this.Controls.Add(this.labLabel);
			this.Controls.Add(this.surgicalLabel);
			this.Controls.Add(this.medLabel);
			this.Controls.Add(this.daysLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label daysLabel;
		private System.Windows.Forms.Label medLabel;
		private System.Windows.Forms.Label surgicalLabel;
		private System.Windows.Forms.Label labLabel;
		private System.Windows.Forms.Label rehabLabel;
		private System.Windows.Forms.TextBox daysTextBox;
		private System.Windows.Forms.TextBox medTextBox;
		private System.Windows.Forms.TextBox surgicalTextBox;
		private System.Windows.Forms.TextBox labTextBox;
		private System.Windows.Forms.TextBox rehabTextBox;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.TextBox dateTextBox;
		private System.Windows.Forms.Button saveButton;
	}
}

