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

namespace ThreeTierExample
{
    public partial class Login : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        DataTable dt = new DataTable();
        private bool v;
        public String utype;

        public Login()
        {
            InitializeComponent();
        }

        public Login(bool v)
        {
             this.v = v;
            InitializeComponent();
            btnReg.Visible = v;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            info.username = tbUname.Text;
            info.password = tbPass.Text;

           dt =  opr.login(info);

            if (dt.Rows.Count > 0)
            {
                utype = dt.Rows[0][9].ToString().Trim();
                if (utype == "Admin")
                {
                    this.Hide();
                    MDIadmin mdi = new MDIadmin();
                    mdi.Show();
                }
                else
                {
                    this.Hide();
                    MDIemployee mde = new MDIemployee();
                    mde.Show();
                }
            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }
    }
}

