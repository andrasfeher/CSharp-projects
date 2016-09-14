using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a connection string, contains the driver, the servername and the database name
            String ConnectionString = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=mysqlsample;option=3;User=root;Password=jasmine";
            //create a query string
            String myquery = "SELECT * FROM tutorials";
            //run the connection string and the query and store it in the dataadapter
            OdbcDataAdapter MySQLDataAdapter = new OdbcDataAdapter(myquery,ConnectionString);
            //create a new dataset
            DataSet MySQLDataSet = new DataSet();
            //fill the dataset with data from the dataadapter
            MySQLDataAdapter.Fill(MySQLDataSet,"tutorials");
            //now set the datasource of our grid to that of the main table of the dataset
            mysqltable.DataSource = MySQLDataSet.Tables["tutorials"].DefaultView;

        }
    }
}