namespace Alarm501
{
    partial class Alarm501
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
            this.uxEditAlarmButton = new System.Windows.Forms.Button();
            this.uxAddAlarmButton = new System.Windows.Forms.Button();
            this.uxAlarmListBox = new System.Windows.Forms.ListBox();
            this.uxSnoozeButton = new System.Windows.Forms.Button();
            this.uxStopAlarmButton = new System.Windows.Forms.Button();
            this.uxAlarmStatusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxEditAlarmButton
            // 
            this.uxEditAlarmButton.Enabled = false;
            this.uxEditAlarmButton.Location = new System.Drawing.Point(24, 26);
            this.uxEditAlarmButton.Name = "uxEditAlarmButton";
            this.uxEditAlarmButton.Size = new System.Drawing.Size(75, 34);
            this.uxEditAlarmButton.TabIndex = 0;
            this.uxEditAlarmButton.Text = "Edit";
            this.uxEditAlarmButton.UseVisualStyleBackColor = true;
            this.uxEditAlarmButton.Click += new System.EventHandler(this.uxEditAlarmButton_Click);
            // 
            // uxAddAlarmButton
            // 
            this.uxAddAlarmButton.Location = new System.Drawing.Point(251, 26);
            this.uxAddAlarmButton.Name = "uxAddAlarmButton";
            this.uxAddAlarmButton.Size = new System.Drawing.Size(75, 34);
            this.uxAddAlarmButton.TabIndex = 1;
            this.uxAddAlarmButton.Text = "+";
            this.uxAddAlarmButton.UseVisualStyleBackColor = true;
            this.uxAddAlarmButton.Click += new System.EventHandler(this.uxAddAlarmButton_Click);
            // 
            // uxAlarmListBox
            // 
            this.uxAlarmListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxAlarmListBox.FormattingEnabled = true;
            this.uxAlarmListBox.ItemHeight = 24;
            this.uxAlarmListBox.Location = new System.Drawing.Point(79, 96);
            this.uxAlarmListBox.Name = "uxAlarmListBox";
            this.uxAlarmListBox.Size = new System.Drawing.Size(197, 196);
            this.uxAlarmListBox.TabIndex = 2;
            // 
            // uxSnoozeButton
            // 
            this.uxSnoozeButton.Enabled = false;
            this.uxSnoozeButton.Location = new System.Drawing.Point(24, 349);
            this.uxSnoozeButton.Name = "uxSnoozeButton";
            this.uxSnoozeButton.Size = new System.Drawing.Size(75, 42);
            this.uxSnoozeButton.TabIndex = 3;
            this.uxSnoozeButton.Text = "Snooze";
            this.uxSnoozeButton.UseVisualStyleBackColor = true;
            this.uxSnoozeButton.Click += new System.EventHandler(this.uxSnoozeButton_Click);
            // 
            // uxStopAlarmButton
            // 
            this.uxStopAlarmButton.Enabled = false;
            this.uxStopAlarmButton.Location = new System.Drawing.Point(251, 349);
            this.uxStopAlarmButton.Name = "uxStopAlarmButton";
            this.uxStopAlarmButton.Size = new System.Drawing.Size(75, 42);
            this.uxStopAlarmButton.TabIndex = 4;
            this.uxStopAlarmButton.Text = "Stop";
            this.uxStopAlarmButton.UseVisualStyleBackColor = true;
            this.uxStopAlarmButton.Click += new System.EventHandler(this.uxStopAlarmButton_Click);
            // 
            // uxAlarmStatusTextBox
            // 
            this.uxAlarmStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxAlarmStatusTextBox.Location = new System.Drawing.Point(128, 311);
            this.uxAlarmStatusTextBox.Name = "uxAlarmStatusTextBox";
            this.uxAlarmStatusTextBox.ReadOnly = true;
            this.uxAlarmStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.uxAlarmStatusTextBox.TabIndex = 5;
            this.uxAlarmStatusTextBox.Text = "Alarm went OFF";
            this.uxAlarmStatusTextBox.Visible = false;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.uxAlarmStatusTextBox);
            this.Controls.Add(this.uxStopAlarmButton);
            this.Controls.Add(this.uxSnoozeButton);
            this.Controls.Add(this.uxAlarmListBox);
            this.Controls.Add(this.uxAddAlarmButton);
            this.Controls.Add(this.uxEditAlarmButton);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alarm501_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEditAlarmButton;
        private System.Windows.Forms.Button uxAddAlarmButton;
        private System.Windows.Forms.ListBox uxAlarmListBox;
        private System.Windows.Forms.Button uxSnoozeButton;
        private System.Windows.Forms.Button uxStopAlarmButton;
        private System.Windows.Forms.TextBox uxAlarmStatusTextBox;
    }
}

