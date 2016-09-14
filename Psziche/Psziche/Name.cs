using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Psziche
{
    public partial class frmName : Form
    {
        public frmName()
        {
            InitializeComponent();
        }

        public string getName()
        {
            return txtName.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Érvénytelen páciensnév");
                txtName.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }

}