namespace AppScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseAppBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataLimitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.timerIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.manualStopBtn = new System.Windows.Forms.Button();
            this.manualStartBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.activeInterfaceLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.uploadSpeedLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.downloadSpeedLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.totalDataLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.statusLabelBig = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uploadDataLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.downloadDataLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.logsBox = new System.Windows.Forms.ListBox();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.Location = new System.Drawing.Point(134, 22);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(338, 20);
            this.appNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application to Execute";
            // 
            // browseAppBtn
            // 
            this.browseAppBtn.Location = new System.Drawing.Point(478, 20);
            this.browseAppBtn.Name = "browseAppBtn";
            this.browseAppBtn.Size = new System.Drawing.Size(36, 23);
            this.browseAppBtn.TabIndex = 2;
            this.browseAppBtn.Text = "...";
            this.browseAppBtn.UseVisualStyleBackColor = true;
            this.browseAppBtn.Click += new System.EventHandler(this.browseAppBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm:ss";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(132, 51);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(87, 20);
            this.startTimePicker.TabIndex = 4;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm:ss";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(132, 79);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(87, 20);
            this.endTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data limit";
            // 
            // dataLimitTextBox
            // 
            this.dataLimitTextBox.Location = new System.Drawing.Point(132, 111);
            this.dataLimitTextBox.Name = "dataLimitTextBox";
            this.dataLimitTextBox.Size = new System.Drawing.Size(87, 20);
            this.dataLimitTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MB";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageControl);
            this.tabControl.Controls.Add(this.tabPageLogs);
            this.tabControl.Controls.Add(this.tabPageHelp);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(552, 397);
            this.tabControl.TabIndex = 11;
            // 
            // tabPageControl
            // 
            this.tabPageControl.Controls.Add(this.label17);
            this.tabPageControl.Controls.Add(this.timerIntervalTextBox);
            this.tabPageControl.Controls.Add(this.label15);
            this.tabPageControl.Controls.Add(this.groupBox3);
            this.tabPageControl.Controls.Add(this.groupBox2);
            this.tabPageControl.Controls.Add(this.groupBox1);
            this.tabPageControl.Controls.Add(this.appNameTextBox);
            this.tabPageControl.Controls.Add(this.label5);
            this.tabPageControl.Controls.Add(this.label1);
            this.tabPageControl.Controls.Add(this.dataLimitTextBox);
            this.tabPageControl.Controls.Add(this.browseAppBtn);
            this.tabPageControl.Controls.Add(this.label4);
            this.tabPageControl.Controls.Add(this.label2);
            this.tabPageControl.Controls.Add(this.endTimePicker);
            this.tabPageControl.Controls.Add(this.startTimePicker);
            this.tabPageControl.Controls.Add(this.label3);
            this.tabPageControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControl.Size = new System.Drawing.Size(544, 371);
            this.tabPageControl.TabIndex = 0;
            this.tabPageControl.Text = "Application Control";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(447, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "s";
            // 
            // timerIntervalTextBox
            // 
            this.timerIntervalTextBox.Location = new System.Drawing.Point(385, 54);
            this.timerIntervalTextBox.Name = "timerIntervalTextBox";
            this.timerIntervalTextBox.Size = new System.Drawing.Size(56, 20);
            this.timerIntervalTextBox.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(309, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Timer interval";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.manualStopBtn);
            this.groupBox3.Controls.Add(this.manualStartBtn);
            this.groupBox3.Location = new System.Drawing.Point(18, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 85);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Control";
            // 
            // manualStopBtn
            // 
            this.manualStopBtn.Location = new System.Drawing.Point(17, 48);
            this.manualStopBtn.Name = "manualStopBtn";
            this.manualStopBtn.Size = new System.Drawing.Size(75, 23);
            this.manualStopBtn.TabIndex = 11;
            this.manualStopBtn.Text = "Stop App";
            this.manualStopBtn.UseVisualStyleBackColor = true;
            // 
            // manualStartBtn
            // 
            this.manualStartBtn.Location = new System.Drawing.Point(17, 18);
            this.manualStartBtn.Name = "manualStartBtn";
            this.manualStartBtn.Size = new System.Drawing.Size(75, 23);
            this.manualStartBtn.TabIndex = 10;
            this.manualStartBtn.Text = "Start App";
            this.manualStartBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.activeInterfaceLabel);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.uploadSpeedLabel);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.downloadSpeedLabel);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.totalDataLabel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.elapsedTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.currentTime);
            this.groupBox2.Controls.Add(this.statusLabelBig);
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.uploadDataLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.downloadDataLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(149, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 215);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // activeInterfaceLabel
            // 
            this.activeInterfaceLabel.AutoSize = true;
            this.activeInterfaceLabel.Location = new System.Drawing.Point(112, 46);
            this.activeInterfaceLabel.Name = "activeInterfaceLabel";
            this.activeInterfaceLabel.Size = new System.Drawing.Size(122, 13);
            this.activeInterfaceLabel.TabIndex = 18;
            this.activeInterfaceLabel.Text = "Active network interface";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Network interfaces";
            // 
            // uploadSpeedLabel
            // 
            this.uploadSpeedLabel.AutoSize = true;
            this.uploadSpeedLabel.Location = new System.Drawing.Point(112, 156);
            this.uploadSpeedLabel.Name = "uploadSpeedLabel";
            this.uploadSpeedLabel.Size = new System.Drawing.Size(13, 13);
            this.uploadSpeedLabel.TabIndex = 16;
            this.uploadSpeedLabel.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Upload speed";
            // 
            // downloadSpeedLabel
            // 
            this.downloadSpeedLabel.AutoSize = true;
            this.downloadSpeedLabel.Location = new System.Drawing.Point(112, 134);
            this.downloadSpeedLabel.Name = "downloadSpeedLabel";
            this.downloadSpeedLabel.Size = new System.Drawing.Size(13, 13);
            this.downloadSpeedLabel.TabIndex = 14;
            this.downloadSpeedLabel.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Download speed";
            // 
            // totalDataLabel
            // 
            this.totalDataLabel.AutoSize = true;
            this.totalDataLabel.Location = new System.Drawing.Point(112, 112);
            this.totalDataLabel.Name = "totalDataLabel";
            this.totalDataLabel.Size = new System.Drawing.Size(13, 13);
            this.totalDataLabel.TabIndex = 12;
            this.totalDataLabel.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Total data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Elapsed Time";
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Location = new System.Drawing.Point(268, 91);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(13, 13);
            this.elapsedTime.TabIndex = 9;
            this.elapsedTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Current Time";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(268, 68);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(13, 13);
            this.currentTime.TabIndex = 7;
            this.currentTime.Text = "0";
            // 
            // statusLabelBig
            // 
            this.statusLabelBig.AutoSize = true;
            this.statusLabelBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelBig.Location = new System.Drawing.Point(18, 183);
            this.statusLabelBig.Name = "statusLabelBig";
            this.statusLabelBig.Size = new System.Drawing.Size(48, 20);
            this.statusLabelBig.TabIndex = 6;
            this.statusLabelBig.Text = "State";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(112, 24);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(24, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Idle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Timer status";
            // 
            // uploadDataLabel
            // 
            this.uploadDataLabel.AutoSize = true;
            this.uploadDataLabel.Location = new System.Drawing.Point(112, 90);
            this.uploadDataLabel.Name = "uploadDataLabel";
            this.uploadDataLabel.Size = new System.Drawing.Size(13, 13);
            this.uploadDataLabel.TabIndex = 3;
            this.uploadDataLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Upload data";
            // 
            // downloadDataLabel
            // 
            this.downloadDataLabel.AutoSize = true;
            this.downloadDataLabel.Location = new System.Drawing.Point(112, 68);
            this.downloadDataLabel.Name = "downloadDataLabel";
            this.downloadDataLabel.Size = new System.Drawing.Size(13, 13);
            this.downloadDataLabel.TabIndex = 1;
            this.downloadDataLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Download data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer Control";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(17, 48);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(17, 18);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.logsBox);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(544, 371);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // logsBox
            // 
            this.logsBox.FormattingEnabled = true;
            this.logsBox.Location = new System.Drawing.Point(7, 7);
            this.logsBox.Name = "logsBox";
            this.logsBox.Size = new System.Drawing.Size(531, 355);
            this.logsBox.TabIndex = 0;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Size = new System.Drawing.Size(544, 371);
            this.tabPageHelp.TabIndex = 3;
            this.tabPageHelp.Text = "Help";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.label14);
            this.tabPageAbout.Controls.Add(this.textBox1);
            this.tabPageAbout.Controls.Add(this.label12);
            this.tabPageAbout.Controls.Add(this.label11);
            this.tabPageAbout.Controls.Add(this.label10);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(544, 371);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Application Scheduler v.0.1.0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(23, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(324, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "https://github.com/arifsetiawan/application-scheduler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(327, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Copyright (c) 2013 Nurul Arif Setiawan <n.arif.setiawan@gmail.com>\r\nSource code a" +
    "nd releases are available in\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(512, 78);
            this.label11.TabIndex = 1;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(505, 117);
            this.label10.TabIndex = 0;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 421);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Application Scheduler";
            this.tabControl.ResumeLayout(false);
            this.tabPageControl.ResumeLayout(false);
            this.tabPageControl.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseAppBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataLimitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.ListBox logsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label uploadDataLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label downloadDataLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button manualStopBtn;
        private System.Windows.Forms.Button manualStartBtn;
        private System.Windows.Forms.Label statusLabelBig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label totalDataLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox timerIntervalTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label uploadSpeedLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label downloadSpeedLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label activeInterfaceLabel;
        private System.Windows.Forms.Label label18;
    }
}

