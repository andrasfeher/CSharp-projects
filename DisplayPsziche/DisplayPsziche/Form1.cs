using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DisplayPsziche
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("hh.dat");

            string record;

            while ((record = sr.ReadLine()) != null)
            {
                dgvResult.Rows.Add(  record.Split( ';' ) ); 
            }

            sr.Close();
        }
    }
}
