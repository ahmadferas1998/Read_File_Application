using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ReadFileApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processedtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AtSpecificTimegroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AMPMcomboBox = new System.Windows.Forms.ComboBox();
            this.minutesL = new System.Windows.Forms.Label();
            this.MinutecomboBox = new System.Windows.Forms.ComboBox();
            this.Hour = new System.Windows.Forms.Label();
            this.HourcomboBox = new System.Windows.Forms.ComboBox();
            this.RunEverygroupBox = new System.Windows.Forms.GroupBox();
            this.RunEveryunitLbl = new System.Windows.Forms.Label();
            this.DurationAmountcomboBox = new System.Windows.Forms.ComboBox();
            this.UnitcomboBox_Selected = new System.Windows.Forms.Label();
            this.UnitcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ServicesRunActionListDDL = new System.Windows.Forms.ComboBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.UninstallService = new System.Windows.Forms.Button();
            this.InstallService = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceActionListDDL = new System.Windows.Forms.ComboBox();
            this.ssev1 = new System.ServiceProcess.ServiceController();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AtSpecificTimegroupBox.SuspendLayout();
            this.RunEverygroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(799, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(799, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Read From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Of Bot :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 125);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 22);
            this.textBox3.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processedtextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(948, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration setting";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // processedtextBox
            // 
            this.processedtextBox.Location = new System.Drawing.Point(111, 92);
            this.processedtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processedtextBox.Name = "processedtextBox";
            this.processedtextBox.Size = new System.Drawing.Size(799, 22);
            this.processedtextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "processed :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(373, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServiceStatus);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.AtSpecificTimegroupBox);
            this.groupBox2.Controls.Add(this.RunEverygroupBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ServicesRunActionListDDL);
            this.groupBox2.Controls.Add(this.StopBtn);
            this.groupBox2.Controls.Add(this.StartBtn);
            this.groupBox2.Controls.Add(this.UninstallService);
            this.groupBox2.Controls.Add(this.InstallService);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ServiceActionListDDL);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(948, 303);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.AutoSize = true;
            this.ServiceStatus.Location = new System.Drawing.Point(355, 71);
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.Size = new System.Drawing.Size(0, 17);
            this.ServiceStatus.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Servise Status:";
            // 
            // AtSpecificTimegroupBox
            // 
            this.AtSpecificTimegroupBox.Controls.Add(this.label6);
            this.AtSpecificTimegroupBox.Controls.Add(this.AMPMcomboBox);
            this.AtSpecificTimegroupBox.Controls.Add(this.minutesL);
            this.AtSpecificTimegroupBox.Controls.Add(this.MinutecomboBox);
            this.AtSpecificTimegroupBox.Controls.Add(this.Hour);
            this.AtSpecificTimegroupBox.Controls.Add(this.HourcomboBox);
            this.AtSpecificTimegroupBox.Location = new System.Drawing.Point(585, 89);
            this.AtSpecificTimegroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtSpecificTimegroupBox.Name = "AtSpecificTimegroupBox";
            this.AtSpecificTimegroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtSpecificTimegroupBox.Size = new System.Drawing.Size(342, 109);
            this.AtSpecificTimegroupBox.TabIndex = 18;
            this.AtSpecificTimegroupBox.TabStop = false;
            this.AtSpecificTimegroupBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "AM/PM :";
            // 
            // AMPMcomboBox
            // 
            this.AMPMcomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.AMPMcomboBox.FormattingEnabled = true;
            this.AMPMcomboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMcomboBox.Location = new System.Drawing.Point(81, 59);
            this.AMPMcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AMPMcomboBox.Name = "AMPMcomboBox";
            this.AMPMcomboBox.Size = new System.Drawing.Size(75, 24);
            this.AMPMcomboBox.TabIndex = 18;
            // 
            // minutesL
            // 
            this.minutesL.AutoSize = true;
            this.minutesL.Location = new System.Drawing.Point(169, 18);
            this.minutesL.Name = "minutesL";
            this.minutesL.Size = new System.Drawing.Size(65, 17);
            this.minutesL.TabIndex = 16;
            this.minutesL.Text = "minutes :";
            // 
            // MinutecomboBox
            // 
            this.MinutecomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.MinutecomboBox.FormattingEnabled = true;
            this.MinutecomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.MinutecomboBox.Location = new System.Drawing.Point(239, 16);
            this.MinutecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinutecomboBox.Name = "MinutecomboBox";
            this.MinutecomboBox.Size = new System.Drawing.Size(75, 24);
            this.MinutecomboBox.TabIndex = 15;
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(26, 18);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(47, 17);
            this.Hour.TabIndex = 14;
            this.Hour.Text = "Hour :";
            // 
            // HourcomboBox
            // 
            this.HourcomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.HourcomboBox.FormattingEnabled = true;
            this.HourcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            ""});
            this.HourcomboBox.Location = new System.Drawing.Point(81, 16);
            this.HourcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourcomboBox.Name = "HourcomboBox";
            this.HourcomboBox.Size = new System.Drawing.Size(75, 24);
            this.HourcomboBox.TabIndex = 13;
            // 
            // RunEverygroupBox
            // 
            this.RunEverygroupBox.Controls.Add(this.RunEveryunitLbl);
            this.RunEverygroupBox.Controls.Add(this.DurationAmountcomboBox);
            this.RunEverygroupBox.Controls.Add(this.UnitcomboBox_Selected);
            this.RunEverygroupBox.Controls.Add(this.UnitcomboBox);
            this.RunEverygroupBox.Location = new System.Drawing.Point(585, 89);
            this.RunEverygroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunEverygroupBox.Name = "RunEverygroupBox";
            this.RunEverygroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunEverygroupBox.Size = new System.Drawing.Size(342, 84);
            this.RunEverygroupBox.TabIndex = 13;
            this.RunEverygroupBox.TabStop = false;
            this.RunEverygroupBox.Visible = false;
            // 
            // RunEveryunitLbl
            // 
            this.RunEveryunitLbl.AutoSize = true;
            this.RunEveryunitLbl.Location = new System.Drawing.Point(169, 18);
            this.RunEveryunitLbl.Name = "RunEveryunitLbl";
            this.RunEveryunitLbl.Size = new System.Drawing.Size(64, 17);
            this.RunEveryunitLbl.TabIndex = 16;
            this.RunEveryunitLbl.Text = "Secand :";
            // 
            // DurationAmountcomboBox
            // 
            this.DurationAmountcomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.DurationAmountcomboBox.FormattingEnabled = true;
            this.DurationAmountcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.DurationAmountcomboBox.Location = new System.Drawing.Point(239, 16);
            this.DurationAmountcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DurationAmountcomboBox.Name = "DurationAmountcomboBox";
            this.DurationAmountcomboBox.Size = new System.Drawing.Size(75, 24);
            this.DurationAmountcomboBox.TabIndex = 15;
            // 
            // UnitcomboBox_Selected
            // 
            this.UnitcomboBox_Selected.AutoSize = true;
            this.UnitcomboBox_Selected.Location = new System.Drawing.Point(6, 18);
            this.UnitcomboBox_Selected.Name = "UnitcomboBox_Selected";
            this.UnitcomboBox_Selected.Size = new System.Drawing.Size(41, 17);
            this.UnitcomboBox_Selected.TabIndex = 14;
            this.UnitcomboBox_Selected.Text = "Unit :";
            // 
            // UnitcomboBox
            // 
            this.UnitcomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.UnitcomboBox.FormattingEnabled = true;
            this.UnitcomboBox.Items.AddRange(new object[] {
            "Second",
            "Minute"});
            this.UnitcomboBox.Location = new System.Drawing.Point(55, 16);
            this.UnitcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnitcomboBox.Name = "UnitcomboBox";
            this.UnitcomboBox.Size = new System.Drawing.Size(75, 24);
            this.UnitcomboBox.TabIndex = 13;
            this.UnitcomboBox.SelectedIndexChanged += new System.EventHandler(this.UnitcomboBox_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Services Run :";
            // 
            // ServicesRunActionListDDL
            // 
            this.ServicesRunActionListDDL.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.ServicesRunActionListDDL.FormattingEnabled = true;
            this.ServicesRunActionListDDL.Items.AddRange(new object[] {
            "At Specific Time a Day",
            "Every Specific Interval"});
            this.ServicesRunActionListDDL.Location = new System.Drawing.Point(741, 38);
            this.ServicesRunActionListDDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServicesRunActionListDDL.Name = "ServicesRunActionListDDL";
            this.ServicesRunActionListDDL.Size = new System.Drawing.Size(169, 24);
            this.ServicesRunActionListDDL.TabIndex = 11;
            this.ServicesRunActionListDDL.SelectedIndexChanged += new System.EventHandler(this.ServicesRunActionListDDL_SelectedIndexChanged_1);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Red;
            this.StopBtn.Location = new System.Drawing.Point(509, 37);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(37, 24);
            this.StopBtn.TabIndex = 10;
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click_1);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.StartBtn.Location = new System.Drawing.Point(466, 37);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(37, 24);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // UninstallService
            // 
            this.UninstallService.ForeColor = System.Drawing.Color.Red;
            this.UninstallService.Location = new System.Drawing.Point(358, 34);
            this.UninstallService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UninstallService.Name = "UninstallService";
            this.UninstallService.Size = new System.Drawing.Size(102, 26);
            this.UninstallService.TabIndex = 8;
            this.UninstallService.Text = "Uninstall";
            this.UninstallService.UseVisualStyleBackColor = true;
            this.UninstallService.Click += new System.EventHandler(this.UninstallService_Click);
            // 
            // InstallService
            // 
            this.InstallService.ForeColor = System.Drawing.Color.DarkGreen;
            this.InstallService.Location = new System.Drawing.Point(250, 34);
            this.InstallService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstallService.Name = "InstallService";
            this.InstallService.Size = new System.Drawing.Size(102, 26);
            this.InstallService.TabIndex = 7;
            this.InstallService.Text = "Install";
            this.InstallService.UseVisualStyleBackColor = true;
            this.InstallService.Click += new System.EventHandler(this.InstallService_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Services :";
            // 
            // ServiceActionListDDL
            // 
            this.ServiceActionListDDL.AutoCompleteCustomSource.AddRange(new string[] {
            "ReadFileServices"});
            this.ServiceActionListDDL.FormattingEnabled = true;
            this.ServiceActionListDDL.Items.AddRange(new object[] {
            "ReadFilesServices"});
            this.ServiceActionListDDL.Location = new System.Drawing.Point(75, 34);
            this.ServiceActionListDDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceActionListDDL.Name = "ServiceActionListDDL";
            this.ServiceActionListDDL.Size = new System.Drawing.Size(169, 24);
            this.ServiceActionListDDL.TabIndex = 0;
            this.ServiceActionListDDL.SelectedIndexChanged += new System.EventHandler(this.ServiceActionListDDL_SelectedIndexChanged_1);
            // 
            // ssev1
            // 
            this.ssev1.ServiceName = "Read_Files_Services";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AtSpecificTimegroupBox.ResumeLayout(false);
            this.AtSpecificTimegroupBox.PerformLayout();
            this.RunEverygroupBox.ResumeLayout(false);
            this.RunEverygroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private NotifyIcon notifyIcon1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private ComboBox ServiceActionListDDL;
        private Label label4;
        private Button UninstallService;
        private Button InstallService;
        private Button StopBtn;
        private Button StartBtn;
        private Label label5;
        private ComboBox ServicesRunActionListDDL;
        private GroupBox RunEverygroupBox;
        private Label UnitcomboBox_Selected;
        private ComboBox UnitcomboBox;
        private Label RunEveryunitLbl;
        private ComboBox DurationAmountcomboBox;
        private GroupBox AtSpecificTimegroupBox;
        private Label minutesL;
        private ComboBox MinutecomboBox;
        private Label Hour;
        private ComboBox HourcomboBox;
        private Label label6;
        private ComboBox AMPMcomboBox;
        private Label label8;
        private Label label7;
        private Label ServiceStatus;
      
        private TextBox processedtextBox;
        private Label label9;
        private System.ServiceProcess.ServiceController ssev1;
    }
}
