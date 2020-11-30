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
  
    public partial class MainForm : Form//this must be the first class
    {
        LinkedList<Label> active_items = new LinkedList<Label>();
        public MainForm()
        {
            InitializeComponent();
            set_project_list(72);//use the lenth of the class link list (what ever you call it)
        }
        private void set_project_list(int n) 
        {
            project_list.Items.Clear();
            for (int i = 0; i < n; i++) 
            {
                project_list.Items.Add("test " + i);
            }
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

    //not needed?
    //class project_Item
    //{
    //    // just a quick class to gooup the buttens and lables together
    //    public Label Name;
    //    public Button View;
    //    public Button Edit;
    //    // add getterts and make this private if you want

    //    public project_Item()
    //    {
    //        Name = new Label();
    //        View = new Button();
    //        Edit = new Button();
            
     
    //    }

    //}
}
