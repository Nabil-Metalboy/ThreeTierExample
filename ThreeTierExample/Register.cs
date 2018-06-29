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
    public partial class Register : Form
    {
        Information info = new Information();
        Operations opr = new Operations();
        string gender;
        public Register()
        {
            InitializeComponent();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            info.name = tbName.Text;
            if(rbMale.Checked == true)
            {
                gender = "Male";
            }
            if(rbFemale.Checked == true)
            {
                gender = "Female";
            }
            info.gender = gender;
            info.dob = Convert.ToDateTime(dropDOB.Value.ToShortDateString());
            info.address = tbAddress.Text;
            info.education = cbEdu.Text;
            info.mobilenum = tbMobileno.Text;
            info.username = tbUsername.Text;
            info.password = tbPassword.Text;

            int rows =  opr.insertEmp(info);
            if(rows >0)
            {
                MessageBox.Show("Data Saved Successfully");
                this.Hide();
                Login lg = new Login(false);
                lg.Show();
            }
        }
    }
}
