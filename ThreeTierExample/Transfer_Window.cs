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
        public DataTable sdr;


        public Transfer_Window()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            sdr = opr.StockInTransfer();
            dataGridView1.Rows.Clear();
            foreach(DataRow item in sdr.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = item["ManufID"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ItemName"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Carton"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Piece"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["ShortName"].ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
                dataGridView1.SelectedRows[0].Cells[0].Value = false;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if((bool)item.Cells[0].Value == true )
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
