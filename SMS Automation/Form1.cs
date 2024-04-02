using Microsoft.VisualBasic;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.ServiceProcess;
using System;
using System.Windows.Forms;
using System.IO;
using System.Configuration.Install;
using System.Collections.Specialized;
using System.Drawing;

namespace ReadFileApplication
{
    public partial class Form1 : Form
    {
             private string ConfigFile= @"C:\Program Files\SquareOne Technologies\Ooredoo Load Balancer\Configuration.ini";
          string windowsServicePath =@"C:\Program Files\SquareOne Technologies\Ooredoo Load Balancer\WindowsService\ReadFiles";
        private string S1TypeOfInterval = "";
        private string S1ValueOfInterval = "";
        private string S2TypeOfInterval = "";
        private string S2ValueOfInterval = "";
        string ReadFrom = "";
        string SaveTo = "";
        string NumberOfBot = "";
        string processed_textBox = "";
        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ServiceActionListDDL_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }

        private void ServicesRunActionListDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicesRunActionListDDL.SelectedIndex > -1)
            {
                if (ServicesRunActionListDDL.SelectedIndex == 0)
                {
                    RunEverygroupBox.Visible = false;
                    AtSpecificTimegroupBox.Visible = true;
                }
                else
                {
                    RunEverygroupBox.Visible = true;
                    AtSpecificTimegroupBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EveryTimeBtn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private string Encrypt(string strText)
        {
            string str1 = "W@A@S@I@M";
            byte[] rgbIV = new byte[8]
            {
        (byte) 18,
        (byte) 52,
        (byte) 86,
        (byte) 120,
        (byte) 144,
        (byte) 171,
        (byte) 205,
        (byte) 239
            };
            string str2;
            try
            {
                byte[] bytes1 = Encoding.UTF8.GetBytes(Strings.Mid(str1, 1, 8));
                byte[] bytes2 = Encoding.UTF8.GetBytes(strText);
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(bytes1, rgbIV), CryptoStreamMode.Write);
                cryptoStream.Write(bytes2, 0, bytes2.Length);
                cryptoStream.FlushFinalBlock();
                str2 = Convert.ToBase64String(memoryStream.ToArray());
            }
            catch (Exception ex)
            {
                //ProjectData.SetProjectError(ex);
                str2 = ex.Message;
                //ProjectData.ClearProjectError();
            }
            return str2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ServiceActionListDDL.Text))
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {

                    int ServiceId = 1;
                    string ServiceOperationalName = "SMSAutomationServiceBlock.exe";
                    string windowsServicePath = this.windowsServicePath + @"\" + ServiceOperationalName;



                    Assembly assembly = Assembly.LoadFrom(windowsServicePath);

                    InstallWindowsService(ServiceOperationalName, assembly);
                    InstallService.Enabled = false;
                    //ServiceStatus.Text = "installed";
                    UninstallService.Enabled = true;
                    StartBtn.Enabled = true;
                    StopBtn.Enabled = false;
                    MessageBox.Show("The Service Installed Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                catch (Exception ex)
                {
                    MessageBox.Show("There was an error with installing the service" + ex.InnerException + ex.StackTrace + ex.Message);
                }


            }

        }
        public static void InstallWindowsService(string serviceName, Assembly assembly)
        {
            if (IsServiceInstalled(serviceName))
            {
                return;
            }

            using (AssemblyInstaller installer = GetInstaller(assembly))
            {
                IDictionary state = new Hashtable();
                try
                {
                    installer.Install(state);

                    installer.Commit(state);
                }
                catch
                {
                    try
                    {
                        installer.Rollback(state);
                    }
                    catch { }
                    throw;
                }
                //    installer.BeforeInstall -= installer_BeforeInstall;
            }

        }

        private static AssemblyInstaller GetInstaller(Assembly assembly)
        {

            AssemblyInstaller installer = new AssemblyInstaller(assembly, null);
            installer.UseNewContext = true;

            return installer;
        }

        public static bool IsServiceInstalled(string serviceName)
        {

            using (ServiceController controller = new ServiceController(serviceName))
            {
                try
                {
                    ServiceControllerStatus status = controller.Status;
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }

        private void InstallService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ServiceActionListDDL.Text))
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {

                    int ServiceId = 1;
                    string ServiceOperationalName = "ReadFilesServices.exe";
                    string windowsServicePath = this.windowsServicePath + @"\" + ServiceOperationalName;



                    Assembly assembly = Assembly.LoadFrom(windowsServicePath);

                    InstallWindowsService(ServiceOperationalName, assembly);
                    InstallService.Enabled = false;
                    ServiceStatus.Text = "installed";
                    UninstallService.Enabled = true;
                    StartBtn.Enabled = true;
                    StopBtn.Enabled = false;
                    MessageBox.Show("The Service Installed Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                catch (Exception ex)
                {
                    MessageBox.Show("There was an error with installing the service" + ex.InnerException + ex.StackTrace + ex.Message);
                }


            }
        }
        private void UnInstallTheService(string ServiceName)
        {
            ServiceInstaller serviceInstaller = new ServiceInstaller();
            InstallContext installContext = new InstallContext("\\Service.txt", new string[0]);
            serviceInstaller.Context = installContext;
            serviceInstaller.ServiceName = ServiceName;
            ListDictionary listDictionary1 = new ListDictionary();
            ListDictionary listDictionary2 = (ListDictionary)null;
            try
            {
                serviceInstaller.Uninstall((IDictionary)listDictionary2);
                int num = (int)Interaction.MsgBox((object)"Service uninstalled successfully.", MsgBoxStyle.Information, (object)"Uninstall");
            }
            catch (Exception ex)
            {
                int num = (int)Interaction.MsgBox((object)("Error occured while uninstalling the service\r\n" + ex.ToString()));
            }
            finally
            {
                if (!string.IsNullOrEmpty(this.ServiceActionListDDL.Text))
                {
                    this.GetServiceStatus(this.ServiceActionListDDL.SelectedItem.ToString());
                }
            }
        }

        private void UninstallService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ServiceActionListDDL.Text))
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string ServiceNameForDeletion = "Read_Files_Services";

                this.UnInstallTheService(ServiceNameForDeletion);


            }
        }

        private void ServiceActionListDDL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //ServiceRunTimeTypescomboBox.SelectedIndex = -1;
            UnitcomboBox.SelectedIndex = -1;
            DurationAmountcomboBox.SelectedIndex = -1;
            HourcomboBox.SelectedIndex = -1;
            MinutecomboBox.SelectedIndex = -1;
            AMPMcomboBox.SelectedIndex = -1;

            string ServiceConfigFileName = "";
            string ServiceTypeOfInterval = "";
            string ServiceValueOfInterval = "";

           
            if (File.Exists(ConfigFile))
            {
                using (StreamReader s = new StreamReader(ConfigFile))
                {
                  this.textBox1.Text= s.ReadLine();
                  this.textBox2.Text= s.ReadLine();
                  this.processedtextBox.Text=s.ReadLine();
                  this.textBox3.Text = s.ReadLine();


                    ServiceTypeOfInterval = s.ReadLine();
                    ServiceValueOfInterval = s.ReadLine();
                }

                if (ServiceTypeOfInterval.Contains("Every"))
                {
                    ServicesRunActionListDDL.SelectedIndex = 1;
                    if (ServiceTypeOfInterval.Split(' ')[1] == "Seconds")
                    {
                        UnitcomboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        UnitcomboBox.SelectedIndex = 1;
                    }
                    DurationAmountcomboBox.SelectedIndex = Convert.ToInt32(ServiceValueOfInterval) - 1;
                }
                if (ServiceTypeOfInterval.Contains("At"))
                {
                    ServicesRunActionListDDL.SelectedIndex = 0;
                    HourcomboBox.SelectedIndex = Convert.ToInt32(ServiceValueOfInterval.Split(':')[0]) - 1;
                    MinutecomboBox.SelectedIndex = Convert.ToInt32(ServiceValueOfInterval.Split(':')[1]);
                    if (ServiceValueOfInterval.Contains("AM"))
                    {
                        AMPMcomboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        AMPMcomboBox.SelectedIndex = 1;
                    }
                }
            }

            this.GetServiceStatus(this.ServiceActionListDDL.SelectedItem.ToString());
        }
        private void GetServiceStatus(string ServiceName)
        {
            try
            {
                if (ServiceName.Contains("ReadFilesServices"))
                {
                    this.ssev1.Refresh();
                    if (this.ssev1.Status == ServiceControllerStatus.Running)
                    {
                        this.ServiceStatus.Text = "Installed / Running";
                        this.StartBtn.Enabled = false;
                        this.StopBtn.Enabled = true;
                    }
                    else
                    {
                        this.ServiceStatus.Text = "Installed / Stopped";
                        this.StartBtn.Enabled = true;
                        this.StopBtn.Enabled = false;
                    }
                    this.InstallService.Enabled = false;
                    this.UninstallService.Enabled = true;
                }
            



            }
            catch (Exception ex)
            {
                this.ServiceStatus.Text = "Not Installed";
                this.InstallService.Enabled = true;
                this.UninstallService.Enabled = false;
                this.StartBtn.Enabled = false;
                this.StopBtn.Enabled = false;
            }
        }
        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ServiceActionListDDL.Text))
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                this.ServiceAction("start");

            }


        }
        private void ServiceAction(string SerStatus)
        {
            try
            {

                this.ssev1.Start();
                ServiceStatus.ForeColor = Color.Green;
                ServiceStatus.Text = "Running";
                StartBtn.Enabled = false;
                StopBtn.Enabled = true;
                UninstallService.Enabled = true;
                MessageBox.Show("Service Started Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error with starting the service" + ex.InnerException + ex.StackTrace + ex.Message);
            }
        }

        private void StopBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ServiceActionListDDL.Text))
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    string ServiceNameForStop = "Read_Files_Services";
                    ServiceController sc = new ServiceController(ServiceNameForStop);
                    ServiceStatus.ForeColor = Color.Red;
                    ServiceStatus.Text = "Stopped";
                    sc.Stop();
                    StopBtn.Enabled = false;
                    StartBtn.Enabled = true;
                    UninstallService.Enabled = true;
                    MessageBox.Show("Service Stopped Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error with Stopping the service" + ex.InnerException + ex.StackTrace + ex.Message);
                }


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ServiceActionListDDL.SelectedValue = 1;
        }

        private void ServicesRunActionListDDL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ServicesRunActionListDDL.SelectedIndex > -1)
            {
                if (ServicesRunActionListDDL.SelectedIndex == 0)
                {
                    RunEverygroupBox.Visible = false;
                    AtSpecificTimegroupBox.Visible = true;
                }
                else
                {
                    RunEverygroupBox.Visible = true;
                    AtSpecificTimegroupBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Select Service From The Drop Down List.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFrom = textBox1.Text;
            SaveTo = textBox2.Text;
            NumberOfBot = textBox3.Text;
            processed_textBox = processedtextBox.Text;
            string filePath = ConfigFile;

            #region Validation
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(processedtextBox.Text))
            {
                MessageBox.Show("Please enter a value in the text box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ServicesRunActionListDDL.SelectedIndex == 0)
            {
                if (HourcomboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Hour Run", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MinutecomboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Minute Hour Run", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (AMPMcomboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please AM/PM Hour Run", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else if (ServicesRunActionListDDL.SelectedIndex == 1)
            {
                if (UnitcomboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Unit Run", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DurationAmountcomboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Duration Amount Hour Run", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select Service Run", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion Validation


            if (UnitcomboBox.SelectedIndex > -1 && DurationAmountcomboBox.SelectedIndex > -1)
            {
                if (UnitcomboBox.SelectedIndex == 0)
                {

                    switch (ServicesRunActionListDDL.SelectedIndex)
                    {
                        case 0:
                            S1TypeOfInterval = "Every Seconds";
                            S1ValueOfInterval = DurationAmountcomboBox.SelectedItem.ToString();
                            break;
                        case 1:
                            S2TypeOfInterval = "Every Seconds";
                            S2ValueOfInterval = DurationAmountcomboBox.SelectedItem.ToString();
                            break;


                    }
                }
                else
                {

                    switch (ServicesRunActionListDDL.SelectedIndex)
                    {
                        case 0:
                            S1TypeOfInterval = "Every Minutes";
                            S1ValueOfInterval = DurationAmountcomboBox.SelectedItem.ToString();
                            break;
                        case 1:
                            S2TypeOfInterval = "Every Minutes";
                            S2ValueOfInterval = DurationAmountcomboBox.SelectedItem.ToString();
                            break;


                    }
                }
            }



            if (HourcomboBox.SelectedIndex > -1 && MinutecomboBox.SelectedIndex > -1 && AMPMcomboBox.SelectedIndex > -1)
            {
                switch (ServicesRunActionListDDL.SelectedIndex)
                {
                    case 0:
                        S1TypeOfInterval = "At";
                        S1ValueOfInterval = HourcomboBox.SelectedItem.ToString() + ":" + MinutecomboBox.SelectedItem.ToString() + ":00 " + AMPMcomboBox.SelectedItem.ToString();
                        break;
                    case 1:
                        S2TypeOfInterval = "At";
                        S2ValueOfInterval = HourcomboBox.SelectedItem.ToString() + ":" + MinutecomboBox.SelectedItem.ToString() + ":00" + AMPMcomboBox.SelectedItem.ToString();
                        break;


                }
            }




            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine((ReadFrom));
                    writer.WriteLine((SaveTo));
                    writer.WriteLine((processed_textBox));
                    writer.WriteLine((NumberOfBot));

                    if (ServicesRunActionListDDL.SelectedIndex == 0)
                    {
                        writer.WriteLine((S1TypeOfInterval));
                        writer.WriteLine((S1ValueOfInterval));

                    }
                    else
                    {
                        writer.WriteLine((S2TypeOfInterval));
                        writer.WriteLine((S2ValueOfInterval));
                    }
                }
                //using (StreamWriter writer = new StreamWriter(filePath))
                //{
                //    writer.WriteLine(Encrypt(ReadFrom));
                //    writer.WriteLine(Encrypt(SaveTo));
                //    writer.WriteLine(Encrypt(NumberOfBot));
                //    if (ServiceActionListDDL.SelectedIndex == 0)
                //    {
                //        writer.WriteLine(Encrypt(S1TypeOfInterval));
                //        writer.WriteLine(Encrypt(S1ValueOfInterval));

                //    }
                //    else
                //    {
                //        writer.WriteLine(Encrypt(S2TypeOfInterval));
                //        writer.WriteLine(Encrypt(S2ValueOfInterval));
                //    }
                //}
                MessageBox.Show("File created and text written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UnitcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (UnitcomboBox.SelectedIndex == 0)
            {
                RunEveryunitLbl.Text = "Seconds";
            }
            else
            {
                RunEveryunitLbl.Text = "Minutes";
            }
            RunEveryunitLbl.Visible = true;
            DurationAmountcomboBox.Visible = true;
        }
    }


}
    

