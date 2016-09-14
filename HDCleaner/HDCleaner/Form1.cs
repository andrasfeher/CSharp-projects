using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;


namespace HDCleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            pbrPassProgress.Maximum = 1000;

            lblPass.Text = "0/7";
            lblPass.Refresh();

            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid='c:'");
            disk.Get();
            int freeSpace = Int32.Parse(disk["FreeSpace"].ToString());

            for (int i=0; i<7; i++)
            {
                StreamWriter sw = new StreamWriter("c:\\xx.txt");

                StringBuilder sb = new StringBuilder();

                for (int k = 0; k < 1000; k++)
                    sb.Append(rnd.Next(10));

                for (int j = 0; j < (( freeSpace - 10000000) / 1000); j++)
                {
                    sw.Write(sb);
                    pbrPassProgress.PerformStep();
                }

                pbrPassProgress.Value = 0;
                
                sw.Close();

                File.Delete("c:\\xx.txt");
              

                lblPass.Text = (i + 1).ToString() + "/7";

                lblPass.Refresh();
            }


        }


    }
}