﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreeTierExample
{
    public partial class MDIemployee : Form
    {
        StockDetails sd;
        public MDIemployee()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Go Back To Home Page", "Return Home",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            sd.Close();
            
        }

        

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            if(sd==null)
            {
                sd = new StockDetails();
                sd.MdiParent = this;
                sd.FormClosed += Sd_FormClosed;
                sd.Show();
            }
            
            else
            {
                sd.Activate();
            }
            
            
        }

        private void Sd_FormClosed(object sender, FormClosedEventArgs e)
        {
            sd = null;
                // throw new NotImplementedException();
        }
    }
}
