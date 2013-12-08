using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace AppScheduler
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private int dataLimit;
        private bool applicationStarted;
        private bool appExecuted;
        private System.Diagnostics.Process appProcess;

        private NetworkInterface[] networkInterfaces;
        private int activeInterfaceIndex;

        private long previousBytesReceived = 0;
        private long previousBytedSent = 0;

        public MainForm()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Elapsed);

            InitStatus();
            LoadSettings();
            GetActiveNetwork();
        }

        void GetActiveNetwork()
        {
            activeInterfaceIndex = -1;
            networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < networkInterfaces.Length; i++)
            {
                if (networkInterfaces[i].OperationalStatus == OperationalStatus.Up)
                {
                    activeInterfaceIndex = i;
                    break;
                }
            }

            if (activeInterfaceIndex != -1)
            {
                activeInterfaceLabel.Text = networkInterfaces[activeInterfaceIndex].Description;
            }
            else
            {
                activeInterfaceLabel.Text = "No active network found";
            }
        }

        void InitStatus()
        {
            applicationStarted = false;
            appExecuted = false;

            currentTime.Text = "";
            elapsedTime.Text = "";
            statusLabel.Text = "Idle";
            downloadDataLabel.Text = "0";
            uploadDataLabel.Text = "0";
            totalDataLabel.Text = "0";
            statusLabelBig.Text = "Application Idle";
        }

        void LoadSettings()
        {
            timer.Interval = Properties.Settings.Default.timerInterval;
            timerIntervalTextBox.Text = timer.Interval.ToString();

            dataLimit = Properties.Settings.Default.dataLimit;
            dataLimitTextBox.Text = dataLimit.ToString();

            appNameTextBox.Text = Properties.Settings.Default.executablePath;

            if (!Properties.Settings.Default.firstTime)
            {
                startTimePicker.Value = Properties.Settings.Default.startTime;
                endTimePicker.Value = Properties.Settings.Default.endTime;
            }
        }

        void SaveSettings()
        {
            timer.Interval = int.Parse(timerIntervalTextBox.Text);
            Properties.Settings.Default.timerInterval = timer.Interval;

            dataLimit = int.Parse(dataLimitTextBox.Text);
            Properties.Settings.Default.dataLimit = dataLimit;

            Properties.Settings.Default.executablePath = appNameTextBox.Text;
            Properties.Settings.Default.startTime = startTimePicker.Value;
            Properties.Settings.Default.endTime = endTimePicker.Value;

            Properties.Settings.Default.firstTime = false;
        }

        void UpdateNetworkInterface()
        {
            NetworkInterface nic = networkInterfaces[activeInterfaceIndex];
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            int bytesSentSpeed = (int)(interfaceStats.BytesSent - previousBytedSent) / 1024;
            int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - previousBytesReceived) / 1024;

            previousBytedSent = interfaceStats.BytesSent;
            previousBytesReceived = interfaceStats.BytesReceived;
            long totalBytes = previousBytedSent + previousBytesReceived;

            uploadDataLabel.Text = BytesToString(previousBytedSent);
            downloadDataLabel.Text = BytesToString(previousBytesReceived);
            uploadSpeedLabel.Text = bytesSentSpeed.ToString() + " KB/s";
            downloadSpeedLabel.Text = bytesReceivedSpeed.ToString() + " KB/s";
        }

        void timer_Elapsed(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            currentTime.Text = now.ToString("hh:mm:ss");

            DateTime startTime = startTimePicker.Value;
            DateTime endTime = endTimePicker.Value;

            if (!applicationStarted)
            {
                if (now > startTime && now < endTime)
                {
                    statusLabelBig.Text = "Application Running";
                    applicationStarted = true;
                    appProcess = Process.Start(appNameTextBox.Text);
                }
            }
            else
            {
                if (now > endTime && !appExecuted)
                {
                    statusLabelBig.Text = "Application Ended";
                    appProcess.CloseMainWindow();
                    appProcess.Close();
                    appExecuted = true;
                    applicationStarted = false;
                }
                else
                {
                    UpdateNetworkInterface();

                    Double diffInSeconds = (now - startTime).TotalSeconds;
                    elapsedTime.Text = diffInSeconds.ToString() + " s";
                }
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
                dataLimit = int.Parse(dataLimitTextBox.Text);
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
                            if (diffInSeconds < (1 * 60))
                            {
                                MessageBox.Show("Please set end time later than start time with difference more than 5 minutes");
                            }
                            else
                            {
                                SaveSettings();

                                appExecuted = false; 
                                timer.Start();
                                DateTime now2 = DateTime.Now;
                                currentTime.Text = now2.ToString("hh:mm:ss");
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
            timer.Stop();
            statusLabel.Text = "Idle";
            currentTime.Text = "";
            elapsedTime.Text = "";
        }

        String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}
