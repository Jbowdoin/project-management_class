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
       // LinkedList<Label> active_items = new LinkedList<Label>();
        public MainForm()
        {
            InitializeComponent();
            set_project_list(72);//use the lenth of the project class link list (what ever you call it)
            //set defalt view  
            output.Visible = true;
            Input_group.Visible = false;
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
        private void show_input() 
        {
            //show input hide output;  
            output.Visible = false;
            Input_group.Visible = true;

            // note use
            //Owner_Name_Input.Text;
            //Team_Names_Input.Text;
            //Project_Name_input.Text;
            //to get input
        }

        private void New_Click(object sender, EventArgs e)
        {
            show_input();
            // remember to use "\r\n" to make new lines when formating output 
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //remove an item from the list
            set_project_list(72);//use the lenth of the project class link list (what ever you call it)
        }

        private void View_Click(object sender, EventArgs e)
        {
            //show output hide input;  
            output.Visible = true;
            Input_group.Visible = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            show_input();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //add new progect to the progect list
            set_project_list(72);//use the lenth of the project class link list (what ever you call it)
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //update this to work with a list of items as needed
            Owner_Name_Input.Text="";
            Team_Names_Input.Text="";
            Project_Name_input.Text="";
            Risks_Input.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
