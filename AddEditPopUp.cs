using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class AddEditPopUp : Form
    {
        private Alarm _alarm;
        public AddEditPopUp(Alarm alarm)
        {
            _alarm = alarm;
            InitializeComponent();
            uxDateTimePicker.Value = alarm.AlarmTime;
            uxAlarmCheckBox.Checked = alarm.AlarmState;

        }

        private void uxSetAlarmButton_Click(object sender, EventArgs e)
        {
            SetAlarm(_alarm);
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetAlarm(Alarm alarm)
        {
            alarm.AlarmTime = uxDateTimePicker.Value;
            alarm.AlarmState = uxAlarmCheckBox.Checked;
        }
    }
}
