using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace AppScheduler
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;
        Int32 dataLimit;
        bool applicationStarted;

        public MainForm()
        {
            InitializeComponent();

            applicationStarted = false;
            dataLimit = 100;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Elapsed);

            dataLimitTextBox.Text = dataLimit.ToString();
            currentTime.Text = "";
            elapsedTime.Text = "";

            appNameTextBox.Text = Properties.Settings.Default.executablePath;
        }

        void timer_Elapsed(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            currentTime.Text = now.ToString("hh:mm:ss");

            System.Console.WriteLine(now);

            if (!applicationStarted)
            {
                DateTime startTime = startTimePicker.Value;

                if (startTime > now)
                {
                    statusLabelBig.Text = "Application Running";
                }
            }
            else
            {

            }
        }

        private void browseAppBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Executable files|*.exe";
            DialogResult result = openFileDialog.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                appNameTextBox.Text = file;
                Properties.Settings.Default.executablePath = file;
                Properties.Settings.Default.Save();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // check if data limit is valid
            try
            {
                dataLimit = Int32.Parse(dataLimitTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please set data limit first in MB. Example: 20");
            }

            // check if application name is set
            if (appNameTextBox.Text == "")
            {
                MessageBox.Show("Please set application to execute");
            }
            else
            {
                // check if application is exists
                if (!File.Exists(appNameTextBox.Text))
                {
                    MessageBox.Show("Please set application to execute correctly. File not found");
                }
                else
                {
                    // check if start time is later then now
                    DateTime now = DateTime.Now;
                    DateTime startTime = startTimePicker.Value;
                    int result = DateTime.Compare(startTime, now);

                    if (result > 0)
                    {
                        
                        DateTime endTime = endTimePicker.Value;
                        Double diffInSeconds = (endTime - startTime).TotalSeconds;
                        if (diffInSeconds <= 0)
                        {
                            MessageBox.Show("Please set end time later than start time with difference more than 5 minutes");
                        }
                        else
                        {
                            if (diffInSeconds < (5 * 60))
                            {
                                MessageBox.Show("Please set end time later than start time with difference more than 5 minutes");
                            }
                            else
                            {
                                timer.Start();
                                statusLabel.Text = "Timer started";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please set start time later than now");
                    }
                }
            }

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
