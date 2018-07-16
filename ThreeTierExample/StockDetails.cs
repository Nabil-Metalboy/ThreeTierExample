﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL;
using BEL;

namespace ThreeTierExample
{
    public partial class StockDetails : Form
    {
        //public Information info = new Information();
        public Operations opr = new Operations();
        public SqlDataReader sd ;
         

        public StockDetails()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void StockDetails_Load(object sender, EventArgs e)
        {
            sd = opr.StockView();
            while(sd.Read())
            {
                ListViewItem lv = new ListViewItem(sd[0].ToString());
                lv.SubItems.Add(sd[1].ToString());
                lv.SubItems.Add(sd[2].ToString());
                lv.SubItems.Add(sd[3].ToString());
                lv.SubItems.Add(sd[4].ToString());
                lv.SubItems.Add(sd[5].ToString());
                listView1.Items.Add(lv);
            }

        }
    }
}
