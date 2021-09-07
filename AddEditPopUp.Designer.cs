namespace Alarm501
{
    partial class AddEditPopUp
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
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSetAlarmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDateTimePicker.Location = new System.Drawing.Point(38, 42);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(177, 20);
            this.uxDateTimePicker.TabIndex = 0;
            // 
            // uxAlarmCheckBox
            // 
            this.uxAlarmCheckBox.AutoSize = true;
            this.uxAlarmCheckBox.Location = new System.Drawing.Point(236, 45);
            this.uxAlarmCheckBox.Name = "uxAlarmCheckBox";
            this.uxAlarmCheckBox.Size = new System.Drawing.Size(40, 17);
            this.uxAlarmCheckBox.TabIndex = 1;
            this.uxAlarmCheckBox.Text = "On";
            this.uxAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(38, 102);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(101, 35);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxSetAlarmButton
            // 
            this.uxSetAlarmButton.Location = new System.Drawing.Point(207, 102);
            this.uxSetAlarmButton.Name = "uxSetAlarmButton";
            this.uxSetAlarmButton.Size = new System.Drawing.Size(100, 35);
            this.uxSetAlarmButton.TabIndex = 3;
            this.uxSetAlarmButton.Text = "Set";
            this.uxSetAlarmButton.UseVisualStyleBackColor = true;
            this.uxSetAlarmButton.Click += new System.EventHandler(this.uxSetAlarmButton_Click);
            // 
            // AddEditPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 159);
            this.Controls.Add(this.uxSetAlarmButton);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxAlarmCheckBox);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "AddEditPopUp";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSetAlarmButton;
        public System.Windows.Forms.DateTimePicker uxDateTimePicker;
        public System.Windows.Forms.CheckBox uxAlarmCheckBox;
    }
}