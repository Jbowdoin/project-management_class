using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectaholic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            //add sign out logic here

            //code to load the login form 
            //may add a funtion for this if we add to many forms 
            //*********************************************
            var frm = new LoginForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
            //**********************************************
        }
    }
}
