using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFilePath = @"D:\TestReadFileServices\FileToRead\New Text Document.txt";
            File.WriteAllText(@"D:\TestReadFileServices\FileToRead\New Text Document_handle.txt",
            Encoding.GetEncoding(1256).GetString(File.ReadAllBytes(selectedFilePath)));
        }
    }
}
