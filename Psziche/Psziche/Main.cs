using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Psziche
{
    public partial class frmMain : Form
    {
        string patientName = "";
        WordList wl;
        DateTime startTime;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmName nameForm = new frmName();

            nameForm.ShowDialog();

            if (nameForm.getName() == "")
            {
                Close();
            }
            else
            {
                patientName = nameForm.getName();
                wl = new WordList( Properties.Settings.Default.datFile );
                BeginMeasure();
            }
        }

        private void BeginMeasure()
        {
            lblWord.Text = wl.GetNextWord();
            startTime = DateTime.Now;
        }

        private void EndMeasure()
        {
            wl.SetIntervalForCurrentWord(DateTime.Now.Subtract( startTime ).Milliseconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndMeasure();

            try
            {
                BeginMeasure();
            }
            catch (EndOfWordListException)
            {
                MessageBox.Show("Vége a tesztnek");
                SaveTestResults(patientName, wl.GetResultList());
                this.Close();
            }
        }

        private void SaveTestResults(string patientName, List<WordStruct> resultList )
        {
            StreamWriter sw = File.CreateText(patientName + ".dat");

            foreach ( WordStruct ws in resultList )
            {
                sw.WriteLine(ws.GetText() + ";" + ws.GetInterval()); 
            }

            sw.Close();
        }


    }
}
