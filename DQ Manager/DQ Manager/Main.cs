using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQ_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aF_TESTDataSet.V_DQ_BATCH_LEVEL_RESULTS' table. You can move, or remove it, as needed.
            this.v_DQ_BATCH_LEVEL_RESULTSTableAdapter.Fill(this.aF_TESTDataSet.V_DQ_BATCH_LEVEL_RESULTS);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_DQ_BATCH_LEVEL_RESULTSTableAdapter.FillBy(this.aF_TESTDataSet.V_DQ_BATCH_LEVEL_RESULTS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
