namespace Projectaholic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.P_name = new System.Windows.Forms.Button();
            this.P_description = new System.Windows.Forms.Button();
            this.P_team = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.TextBox();
            this.P_risk = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.Project_info = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            this.Main_menu = new System.Windows.Forms.GroupBox();
            this.General_section = new System.Windows.Forms.GroupBox();
            this.Main_menu.SuspendLayout();
            this.General_section.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AcceptsReturn = true;
            this.input.AcceptsTab = true;
            this.input.Location = new System.Drawing.Point(551, 354);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.input.Size = new System.Drawing.Size(399, 235);
            this.input.TabIndex = 0;
            // 
            // P_name
            // 
            this.P_name.Location = new System.Drawing.Point(0, 19);
            this.P_name.Name = "P_name";
            this.P_name.Size = new System.Drawing.Size(200, 35);
            this.P_name.TabIndex = 1;
            this.P_name.Text = "button1";
            this.P_name.UseVisualStyleBackColor = true;
            this.P_name.Click += new System.EventHandler(this.button1_Click);
            // 
            // P_description
            // 
            this.P_description.Location = new System.Drawing.Point(199, 19);
            this.P_description.Name = "P_description";
            this.P_description.Size = new System.Drawing.Size(200, 35);
            this.P_description.TabIndex = 2;
            this.P_description.Text = "button2";
            this.P_description.UseVisualStyleBackColor = true;
            this.P_description.Click += new System.EventHandler(this.P_description_Click);
            // 
            // P_team
            // 
            this.P_team.Location = new System.Drawing.Point(0, 60);
            this.P_team.Name = "P_team";
            this.P_team.Size = new System.Drawing.Size(200, 35);
            this.P_team.TabIndex = 3;
            this.P_team.Text = "button3";
            this.P_team.UseVisualStyleBackColor = true;
            this.P_team.Click += new System.EventHandler(this.P_team_Click);
            // 
            // Header
            // 
            this.Header.AcceptsReturn = true;
            this.Header.AcceptsTab = true;
            this.Header.Location = new System.Drawing.Point(551, 313);
            this.Header.Multiline = true;
            this.Header.Name = "Header";
            this.Header.ReadOnly = true;
            this.Header.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Header.Size = new System.Drawing.Size(399, 35);
            this.Header.TabIndex = 4;
            this.Header.Text = "What would you like to do";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Header.TextChanged += new System.EventHandler(this.Header_TextChanged);
            // 
            // P_risk
            // 
            this.P_risk.Location = new System.Drawing.Point(199, 60);
            this.P_risk.Name = "P_risk";
            this.P_risk.Size = new System.Drawing.Size(200, 35);
            this.P_risk.TabIndex = 5;
            this.P_risk.Text = "button3";
            this.P_risk.UseVisualStyleBackColor = true;
            this.P_risk.Click += new System.EventHandler(this.P_risk_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(551, 595);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(399, 35);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "button3";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Project_info
            // 
            this.Project_info.Location = new System.Drawing.Point(0, 19);
            this.Project_info.Name = "Project_info";
            this.Project_info.Size = new System.Drawing.Size(200, 76);
            this.Project_info.TabIndex = 7;
            this.Project_info.Text = "button1";
            this.Project_info.UseVisualStyleBackColor = true;
            this.Project_info.Click += new System.EventHandler(this.Project_info_Click);
            // 
            // Output
            // 
            this.Output.AcceptsReturn = true;
            this.Output.AcceptsTab = true;
            this.Output.Location = new System.Drawing.Point(551, 354);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(399, 235);
            this.Output.TabIndex = 8;
            this.Output.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(199, 19);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(200, 76);
            this.Display.TabIndex = 9;
            this.Display.Text = "button1";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Main_menu
            // 
            this.Main_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Main_menu.Controls.Add(this.Project_info);
            this.Main_menu.Controls.Add(this.Display);
            this.Main_menu.Location = new System.Drawing.Point(551, 354);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(399, 101);
            this.Main_menu.TabIndex = 10;
            this.Main_menu.TabStop = false;
            // 
            // General_section
            // 
            this.General_section.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.General_section.Controls.Add(this.P_name);
            this.General_section.Controls.Add(this.P_description);
            this.General_section.Controls.Add(this.P_team);
            this.General_section.Controls.Add(this.P_risk);
            this.General_section.Location = new System.Drawing.Point(551, 354);
            this.General_section.Name = "General_section";
            this.General_section.Size = new System.Drawing.Size(399, 101);
            this.General_section.TabIndex = 11;
            this.General_section.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 642);
            this.Controls.Add(this.Main_menu);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.General_section);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Main_menu.ResumeLayout(false);
            this.General_section.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button P_name;
        private System.Windows.Forms.Button P_description;
        private System.Windows.Forms.Button P_team;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Button P_risk;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button Project_info;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.GroupBox Main_menu;
        private System.Windows.Forms.GroupBox General_section;
    }
}

