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
    public partial class MDIemployee : Form
    {
        StockDetails sd = new StockDetails();
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
            sd.Hide();
            
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            sd.Show();
            
            
        }
    }
}
