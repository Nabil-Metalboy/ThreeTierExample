using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreeTierExample
{
    public partial class MDIadmin : Form
    {
        StockDetails sd;
        Transfer_Window tw;
        public MDIadmin()
        {
            InitializeComponent();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sd == null)
            {
                sd = new StockDetails();
                sd.MdiParent = this;
                sd.FormClosed += tw_FormClosed;
                sd.Show();
            }

            else
            {
                sd.Activate();
            }
           // tw.Dispose();

        }

        

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Do You Want To Go Back To Home Page", "Return Home",
            //   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           
            //if (sd != null)
            //{
            //    sd.Activate();

            //}
            //else if (tw != null)
            //{
            //    tw.Activate();
            //}
            //else if (sd == null)
            //    sd.Close();
            //else if (tw == null)
            //    tw.Close();
                
        }



        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tw == null)
            {
                tw = new Transfer_Window();
                tw.MdiParent = this;
                tw.FormClosed += tw_FormClosed;
                tw.Show();
            }

            else
            {
                tw.Activate();
            }
            //sd.Dispose();
        }

        private void sd_FormClosed(object sender, FormClosedEventArgs e)
        {
            sd = null;
            //tw = null;
            //throw new NotImplementedException();
        }
        private void tw_FormClosed(object sender, FormClosedEventArgs e)
        {
            tw = null;
            //tw = null;
            //throw new NotImplementedException();
        }
    }
}
