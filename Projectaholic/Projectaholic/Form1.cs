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
    //add our names here (not sure who is actuly working on it right now
    /*
     * Josh bowdoin
     * James Andersen
     */
    public partial class Form1 : Form
    {
        //should probably make team into an array or list so we can sort out diffrent pepole.
        private string Owner, Description, Team, Risks;
        private string file_name = "save_data.txt";
        private StreamReader SR;
        private StreamWriter SW;
        private int choice;
        public Form1()
        {
            InitializeComponent();
            reset();
            load();
            Project_info.Text = "Set_Project";
            P_name.Text = "Enter project description";
            P_description.Text = "Enter manager name";
            P_team.Text = "Enter  team members";
            P_risk.Text = "Enter list of risks and risk status";
            confirm.Text = "Enter";
            Display.Text = "get project info";
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
                case -3://switch the the  out put desply menu
                    General_section.Visible = false;
                    Main_menu.Visible = false;
                    confirm.Visible = true;
                    Output.Visible = true;
                    break;
                case -2://switch the the  General_section menu

                    input.Visible = false;
                    confirm.Visible = false;
                    Main_menu.Visible = false;
                    General_section.Visible = true;
                    break;
                case -1://switch the the  input menu
                    General_section.Visible = false;
                    input.Visible = true;
                    confirm.Visible = true;
                    break;
                case 0://return to defalt
                    reset();
                    break;

                // add funtonality to the set funtions 
                case 1:
                    set_owner();
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
        private void save() 
        {
            SW = new StreamWriter(file_name);
            //add logic here

            SW.Close();
        }
        private void load()
        {// call this on start up
            try 
            {
                SR = new StreamReader(file_name);
                //add logic here

                SR.Close();
            }
            catch 
            {
                if (SR != null) 
                {
                    SR.Close();//close the file should the try block fail early 
                }
            }
        }
        private void set_owner()
        {
             
            Owner = input.Text;
            input.Text = "";
        }
        private void set_Description()
        {
            
            Description = input.Text;
            input.Text = "";
        }
        private void set_Team()
        {
            //this sould be updated to use list or arrays to list members indivisuly
           
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
            //reset the menu state 
            Header.Text = "What would you like to do ?";
            Main_menu.Visible = true;
            General_section.Visible = false;
            input.Visible = false;
            confirm.Visible = false;
            Output.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //
            Header.Text = "Enter the project description:";
            choice = 2;
            menu_toggle(-1);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            //call the needed funtion from menu_toggle after the user has entered the text, then reset the menu
            //this is called with each enter click
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
            menu_toggle(-3);

            Output.Text = "project manager\t" + Owner + "\r\nTeam\t" + Team + "\r\nHigh level description\r\n"+ Description + "\r\nList of risks and risk status\r\n" + Risks;
            // "\r\n" is needed for making new lines.
        }



        private void P_description_Click(object sender, EventArgs e)
        {
            
            Header.Text = "Enter the Owner's name:";
            choice = 1;//set name
            menu_toggle(-1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ingnore but do not deleat
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            //ingnore but do not deleat
        }

        private void button2_Click(object sender, EventArgs e)
        {// clear out the data 
            Owner = "";
             Description = "";
             Team = "";
             Risks = "";
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            save();// call on click
        }

        private void P_team_Click(object sender, EventArgs e)
        {
            Header.Text = "Enter the team members:";
            choice = 3;
            menu_toggle(-1);
        }

        private void P_risk_Click(object sender, EventArgs e)
        {
            Header.Text = "Enter the project risks :";
            choice = 4;
            menu_toggle(-1);
        }

        private void Header_TextChanged(object sender, EventArgs e)
        {
            //ingnore but do not deleat
        }
    }
}

