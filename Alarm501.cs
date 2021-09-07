using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class Alarm501 : Form
    {

        private List<Alarm> Alarms = new List<Alarm>();

        private List<System.Windows.Forms.Timer> Timers = new List<System.Windows.Forms.Timer>();

        System.Windows.Forms.Timer snoozeTimer = new System.Windows.Forms.Timer();

        public Alarm501()
        {
            InitializeComponent();
            ReadAlarms();
            
        }

        private void ReadAlarms()
        {
            if (File.Exists("..\\..\\alarms.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\alarms.txt");
                while (!sr.EndOfStream)
                {
                    string[] tokens = sr.ReadLine().Split(' ');
                    if (tokens[3] == "PM")
                    {
                        if (tokens[4] == "On")
                        {
                            if (tokens[0] != "12") tokens[0] = (Convert.ToInt32(tokens[0]) + 12).ToString();
                            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2]));
                            Alarm alarm = new Alarm() { AlarmState = true, AlarmTime = alarmTime };
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            TimeSpan ts = alarm.AlarmTime - DateTime.Now;
                            if (ts.TotalMilliseconds < 0) ts = ts.Add(new TimeSpan(1, 0, 0, 0));
                            timer.Interval = (int)ts.TotalMilliseconds;
                            timer.Tick += new EventHandler(TimerElapsed);
                            if (alarm.AlarmState) timer.Start();
                            Alarms.Add(alarm);
                            Timers.Add(timer);
                            uxAlarmListBox.Items.Add(alarm.ToString());
                        }
                        else if (tokens[4] == "Off")
                        {
                            if (tokens[0] != "12") tokens[0] = (Convert.ToInt32(tokens[0]) + 12).ToString();
                            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2]));
                            Alarm alarm = new Alarm() { AlarmState = false, AlarmTime = alarmTime };
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            TimeSpan ts = alarm.AlarmTime - DateTime.Now;
                            if (ts.TotalMilliseconds < 0) ts = ts.Add(new TimeSpan(1, 0, 0, 0));
                            timer.Interval = (int)ts.TotalMilliseconds;
                            timer.Tick += new EventHandler(TimerElapsed);
                            if (alarm.AlarmState) timer.Start();
                            Alarms.Add(alarm);
                            Timers.Add(timer);
                            uxAlarmListBox.Items.Add(alarm.ToString());
                        }
                    }
                    else
                    {
                        if (tokens[4] == "On")
                        {
                            if (tokens[0] == "12") tokens[0] = "0";
                            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2]));
                            Alarm alarm = new Alarm() { AlarmState = true, AlarmTime = alarmTime };
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            TimeSpan ts = alarm.AlarmTime - DateTime.Now;
                            if (ts.TotalMilliseconds < 0) ts = ts.Add(new TimeSpan(1, 0, 0, 0));
                            timer.Interval = (int)ts.TotalMilliseconds;
                            timer.Tick += new EventHandler(TimerElapsed);
                            if (alarm.AlarmState) timer.Start();
                            Alarms.Add(alarm);
                            Timers.Add(timer);
                            uxAlarmListBox.Items.Add(alarm.ToString());
                        }
                        else if (tokens[4] == "Off")
                        {
                            if (tokens[0] == "12") tokens[0] = "0";
                            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2]));
                            Alarm alarm = new Alarm() { AlarmState = false, AlarmTime = alarmTime };
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            TimeSpan ts = alarm.AlarmTime - DateTime.Now;
                            if (ts.TotalMilliseconds < 0) ts = ts.Add(new TimeSpan(1, 0, 0, 0));
                            timer.Interval = (int)ts.TotalMilliseconds;
                            timer.Tick += new EventHandler(TimerElapsed);
                            if (alarm.AlarmState) timer.Start();
                            Alarms.Add(alarm);
                            Timers.Add(timer);
                            uxAlarmListBox.Items.Add(alarm.ToString());

                        }
                    }
                }
                if (Alarms.Count != 0)
                {
                    uxEditAlarmButton.Enabled = true;
                }
                if (Alarms.Count >= 5)
                {
                    uxAddAlarmButton.Enabled = false;
                }
                sr.Close();
            }

        }

        private void uxAddAlarmButton_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm() { AlarmTime = DateTime.Now, AlarmState = false};
            AddEditPopUp uxPopUp = new AddEditPopUp(alarm);
            DialogResult response = uxPopUp.ShowDialog();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TimeSpan ts = alarm.AlarmTime - DateTime.Now;
            if (ts.TotalMilliseconds < 0) ts = ts.Add(new TimeSpan(1, 0, 0, 0));
            timer.Interval = (int)ts.TotalMilliseconds;
            timer.Tick += new EventHandler(TimerElapsed);
            if (alarm.AlarmState) timer.Start();
            Alarms.Add(alarm);
            Timers.Add(timer);
            uxEditAlarmButton.Enabled = true;
            uxAlarmListBox.Items.Add(alarm.ToString());
            if(Alarms.Count >= 5)
            {
                uxAddAlarmButton.Enabled = false;
            }
            
        }

        private void uxEditAlarmButton_Click(object sender, EventArgs e)
        {
            if (uxAlarmListBox.SelectedItem == null)
                return;
            Alarm alarm = Alarms[uxAlarmListBox.SelectedIndex];
            AddEditPopUp uxPopUp = new AddEditPopUp(alarm);
            uxPopUp.ShowDialog();
            System.Windows.Forms.Timer timer = Timers[uxAlarmListBox.SelectedIndex];
            TimeSpan ts = alarm.AlarmTime - DateTime.Now;
            if (ts.TotalMilliseconds < 0) ts = ts.Add(new TimeSpan(1, 0, 0, 0));
            timer.Interval = (int)ts.TotalMilliseconds;
            if (alarm.AlarmState)
            {
                timer.Tick += new EventHandler(TimerElapsed);
            }
            else
            {
                timer.Tick -= new EventHandler(TimerElapsed);
            }

            timer.Start();
            Alarms[uxAlarmListBox.SelectedIndex] = alarm;
            Timers[uxAlarmListBox.SelectedIndex] = timer;
            uxAlarmListBox.Items[uxAlarmListBox.SelectedIndex] = alarm.ToString();
        }

        private void TimerElapsed(object sender, EventArgs e)
        {
            uxAlarmStatusTextBox.Visible = true;
            uxStopAlarmButton.Enabled = true;
            uxSnoozeButton.Enabled = true;
        }

        private void uxSnoozeButton_Click(object sender, EventArgs e)
        {
            if (uxAlarmListBox.SelectedItem == null) return;

            for (int i = 0; i < Alarms.Count; i++)
            {
                if (Alarms[i].AlarmState && Alarms[uxAlarmListBox.SelectedIndex].Equals(Alarms[i]))
                {
                    Timers[i].Tick -= new EventHandler(TimerElapsed);
                    snoozeTimer.Interval = (int)(new TimeSpan(0, 0, 3).TotalMilliseconds);
                    snoozeTimer.Tick += new EventHandler(TimerElapsed);
                    snoozeTimer.Start();
                    uxSnoozeButton.Enabled = false;
                    uxStopAlarmButton.Enabled = false;
                    uxAlarmStatusTextBox.Visible = false;
                }
            }
        }

        private void uxStopAlarmButton_Click(object sender, EventArgs e)
        {

            if (uxAlarmListBox.SelectedItem == null) return;

            snoozeTimer.Stop();

            for (int i = 0; i < Alarms.Count; i++)
            {
                if (Alarms[i].AlarmState && Alarms[uxAlarmListBox.SelectedIndex].Equals(Alarms[i]))
                {
                    Alarms[i].AlarmState = false;
                    Timers[i].Tick -= new EventHandler(TimerElapsed);
                    Timers[i].Stop();
                    uxAlarmListBox.Items[i] = Alarms[i].ToString() + " Stopped";
                    uxAlarmStatusTextBox.Visible = false;
                    uxSnoozeButton.Enabled = false;
                    uxStopAlarmButton.Enabled = false;
                }
            }
        }

        private void Alarm501_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("..\\..\\alarms.txt", false);
            foreach (Alarm alarm in Alarms)
            {
                string period;
                string state;
                string alarmInfo;
                if(alarm.AlarmTime.Hour >= 12)
                {
                    period = "PM";
                }
                else
                {
                    period = "AM";
                }
                if (alarm.AlarmState)
                {
                    state = "On";
                }
                else
                {
                    state = "Off";
                }
                if(alarm.AlarmTime.Hour == 0)
                {
                    alarmInfo = "12 " + alarm.AlarmTime.Minute.ToString() + " " + alarm.AlarmTime.Second.ToString() + " " + period + " " + state;
                }
                else if (alarm.AlarmTime.Hour > 12)
                {
                    int hour = alarm.AlarmTime.Hour - 12;
                    alarmInfo = hour.ToString() + " " + alarm.AlarmTime.Minute.ToString() + " " + alarm.AlarmTime.Second.ToString() + " " + period + " " + state;
                }
                else
                {
                    alarmInfo = alarm.AlarmTime.Hour.ToString() + " " + alarm.AlarmTime.Minute.ToString() + " " + alarm.AlarmTime.Second.ToString() + " " + period + " " + state;
                }
                sw.WriteLine(alarmInfo);
            }
            sw.Close();
        }

    }
}
