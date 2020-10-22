using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projectaholic
{
    public partial class Form1 : Form
    {
        //should probably make team into an array or list so we can sort out diffrent pepole.
        private string Owner, Description, Team, Risks;
        private int choice;
        public Form1()
        {
            InitializeComponent();
            reset();
            Project_info.Text = "Set_Project";
            P_name.Text = "Enter project description";
            P_description.Text = "Enter manager name";
            P_team.Text = "Enter  team members";
            P_risk.Text = "Enter list of risks and risk status";
            confirm.Text = "Enter";
        }
        //Your software should include the following set of functions.
        //A.A General section that allows the input of the following information:
        // 1. A high level description of the software project
        // 2. The owner or the project manager name
        // 3. A list of project team members(which may vary as the project progresses)
        // 4. A list of risks and risk status
        //B.Project Requirements
        //1. Have a feature that allows the user to enter a list of functional and nonfunctional requirements for the software project
        //C. Project Effort Monitoring and Tracking
        //1. Have a feature that allows the user to enter (at a daily or weekly basis) the
        //effort in number of person hours expended on Requirements Analysis,
        //Designing, Coding, Testing, Project Management(by each of the earlier
        //entered requirements)
        //2. Have a feature that allows the user to view the total expended hours by
        //requirements analysis, designing, coding, testing, project management(by
        //each of the requirement entered).
        private void menu_toggle(int x) 
        {
            switch (x) 
            {
                case -2:
                    Project_info.Visible = false;
                    Display.Visible = false;
                    P_name.Visible = true;
                    P_description.Visible = true;
                    P_team.Visible = true;
                    P_risk.Visible = true;
                    input.Visible = false;
                    confirm.Visible = false;
                    break;
                case -1:
                    P_name.Visible = false;
                    P_description.Visible = false;
                    P_team.Visible = false;
                    P_risk.Visible = false;
                    input.Visible = true;
                    confirm.Visible = true;
                    break;
                case 0:
                    reset();
                    break;
              case 1:
                    set_ower();
                    break;
                case 2:
                    set_Description();
                    break;
                case 3:
                    set_Team();
                    break;
                case 4:
                    set_Risk();
                    break;
            }
        }
        private void set_ower() 
        {
            Owner = input.Text;
            input.Text="";
        }
        private void set_Description()
        {
            Description = input.Text;
            input.Text = "";
        }
        private void set_Team()
        {
            Team = input.Text;
            input.Text = "";
        }
        private void set_Risk()
        {
            Risks = input.Text;
            input.Text = "";
        }
        private void reset() 
        {
            Project_info.Visible = true;
            Display.Visible= true;
            P_name.Visible = false;   
            P_description.Visible = false;
            P_team.Visible = false;
            P_risk.Visible = false;
            input.Visible = false;
            confirm.Visible = false;
            Output.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            choice = 1;//set name
            menu_toggle(-1);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            //call the needed funtion from menu_toggle after the user has entered the text, then reset the menu
            menu_toggle(choice);
            menu_toggle(0);
        }

        private void Project_info_Click(object sender, EventArgs e)
        {
            menu_toggle(-2);
        }

        private void Display_Click(object sender, EventArgs e)
        {
            choice = 0;//reset the menu with the next click
            menu_toggle(-2);
            confirm.Visible = true;
            Output.Visible = true;
            Output.Text = "project manager\t" + Owner + "\nTeam\t" + Team + "\nHigh level description\n" + "\nList of risks and risk status\n" + Risks;
           //not sure whay this is not making new lines.
        }

        private void P_description_Click(object sender, EventArgs e)
        {
            choice = 2;
            menu_toggle(-1);
        }

        private void P_team_Click(object sender, EventArgs e)
        {
            choice = 3;
            menu_toggle(-1);
        }

        private void P_risk_Click(object sender, EventArgs e)
        {
            choice = 4;
            menu_toggle(-1);
        }
    }
}
