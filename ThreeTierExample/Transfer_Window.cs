using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BEL;
using System.Data.SqlClient;


namespace ThreeTierExample
{
   
    public partial class Transfer_Window : Form
    {
        public Operations opr = new Operations();
        public SqlDataReader sdr;


        public Transfer_Window()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            sdr = opr.StockView();
            dataGridView1.Rows.Clear();
            while(sdr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = sdr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = sdr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = sdr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = sdr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = sdr[5].ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
