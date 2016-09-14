using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flashcard
{
    public partial class MainForm : Form
    {

        private QuandaList _ql = new QuandaList(5);
        private Quanda _currentQuanda;

        public MainForm()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {

        }


        private void btnError_Click(object sender, EventArgs e)
        {

        }
        

 

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Documents and Settings\\N535835\\My Documents\\Visual Studio 2008\\Projects\\Flashcard\\Flashcard\\bin\\Debug\\";
            openFileDialog1.Filter = "cvs fájlok (*.csv)";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _ql.Reset( new QuandaListProvider(openFileDialog1.FileName) );
                DisplayNextQuestion();
            }
        }

        private void DisplayNextQuestion()
        {
            _currentQuanda = _ql.GetNextQuanda();

            if (!chkReverse.Checked)
                txtQuestion.Text = _currentQuanda.Question;
            else
                txtQuestion.Text = _currentQuanda.Answer;
        }

        private void DisplayAnswer()
        {
            if (!chkReverse.Checked)
                txtAnswer.Text = _currentQuanda.Answer;
            else
                txtAnswer.Text = _currentQuanda.Question;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }


    }
}
