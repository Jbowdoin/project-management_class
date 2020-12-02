
namespace Projectaholic
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainSideSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ProjectSettingSplitContainer = new System.Windows.Forms.SplitContainer();
            this.project_list = new System.Windows.Forms.ListBox();
            this.project_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Account = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Input_group = new System.Windows.Forms.GroupBox();
            this.Risks_Input = new System.Windows.Forms.TextBox();
            this.Risks_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Team_Names_Input = new System.Windows.Forms.Label();
            this.Owner_Name_Input = new System.Windows.Forms.TextBox();
            this.Owner_Name_label = new System.Windows.Forms.Label();
            this.Project_Name_input = new System.Windows.Forms.TextBox();
            this.Project_Name_label = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSideSplitContainer)).BeginInit();
            this.MainSideSplitContainer.Panel1.SuspendLayout();
            this.MainSideSplitContainer.Panel2.SuspendLayout();
            this.MainSideSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSettingSplitContainer)).BeginInit();
            this.ProjectSettingSplitContainer.Panel1.SuspendLayout();
            this.ProjectSettingSplitContainer.Panel2.SuspendLayout();
            this.ProjectSettingSplitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Input_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainSideSplitContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1457, 958);
            this.MainPanel.TabIndex = 1;
            // 
            // MainSideSplitContainer
            // 
            this.MainSideSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSideSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSideSplitContainer.Name = "MainSideSplitContainer";
            // 
            // MainSideSplitContainer.Panel1
            // 
            this.MainSideSplitContainer.Panel1.Controls.Add(this.ProjectSettingSplitContainer);
            // 
            // MainSideSplitContainer.Panel2
            // 
            this.MainSideSplitContainer.Panel2.Controls.Add(this.groupBox2);
            this.MainSideSplitContainer.Size = new System.Drawing.Size(1457, 958);
            this.MainSideSplitContainer.SplitterDistance = 309;
            this.MainSideSplitContainer.TabIndex = 0;
            // 
            // ProjectSettingSplitContainer
            // 
            this.ProjectSettingSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectSettingSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ProjectSettingSplitContainer.Name = "ProjectSettingSplitContainer";
            this.ProjectSettingSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ProjectSettingSplitContainer.Panel1
            // 
            this.ProjectSettingSplitContainer.Panel1.AutoScroll = true;
            this.ProjectSettingSplitContainer.Panel1.Controls.Add(this.project_list);
            this.ProjectSettingSplitContainer.Panel1.Controls.Add(this.project_label);
            // 
            // ProjectSettingSplitContainer.Panel2
            // 
            this.ProjectSettingSplitContainer.Panel2.Controls.Add(this.groupBox1);
            this.ProjectSettingSplitContainer.Size = new System.Drawing.Size(309, 958);
            this.ProjectSettingSplitContainer.SplitterDistance = 697;
            this.ProjectSettingSplitContainer.TabIndex = 0;
            // 
            // project_list
            // 
            this.project_list.BackColor = System.Drawing.Color.LightSkyBlue;
            this.project_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.project_list.FormattingEnabled = true;
            this.project_list.Location = new System.Drawing.Point(3, 48);
            this.project_list.Name = "project_list";
            this.project_list.Size = new System.Drawing.Size(303, 641);
            this.project_list.TabIndex = 3;
            // 
            // project_label
            // 
            this.project_label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.project_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_label.Location = new System.Drawing.Point(3, 9);
            this.project_label.Name = "project_label";
            this.project_label.Size = new System.Drawing.Size(306, 36);
            this.project_label.TabIndex = 2;
            this.project_label.Text = "Projects";
            this.project_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Account);
            this.groupBox1.Controls.Add(this.Logout);
            this.groupBox1.Controls.Add(this.Settings);
            this.groupBox1.Location = new System.Drawing.Point(2, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Account.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Account.Location = new System.Drawing.Point(-2, 19);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(306, 44);
            this.Account.TabIndex = 1;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logout.Location = new System.Drawing.Point(-2, 119);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(306, 44);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Settings.Location = new System.Drawing.Point(-2, 69);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(306, 44);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.Clear);
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Input_group);
            this.groupBox2.Controls.Add(this.New);
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.Edit);
            this.groupBox2.Controls.Add(this.output);
            this.groupBox2.Controls.Add(this.View);
            this.groupBox2.Location = new System.Drawing.Point(22, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 574);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clear.Location = new System.Drawing.Point(458, 528);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(430, 40);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Save.Location = new System.Drawing.Point(6, 528);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(430, 40);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Input_group
            // 
            this.Input_group.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Input_group.Controls.Add(this.textBox3);
            this.Input_group.Controls.Add(this.label2);
            this.Input_group.Controls.Add(this.textBox1);
            this.Input_group.Controls.Add(this.label1);
            this.Input_group.Controls.Add(this.Risks_Input);
            this.Input_group.Controls.Add(this.Risks_label);
            this.Input_group.Controls.Add(this.textBox2);
            this.Input_group.Controls.Add(this.Team_Names_Input);
            this.Input_group.Controls.Add(this.Owner_Name_Input);
            this.Input_group.Controls.Add(this.Owner_Name_label);
            this.Input_group.Controls.Add(this.Project_Name_input);
            this.Input_group.Controls.Add(this.Project_Name_label);
            this.Input_group.Location = new System.Drawing.Point(6, 9);
            this.Input_group.Name = "Input_group";
            this.Input_group.Size = new System.Drawing.Size(882, 410);
            this.Input_group.TabIndex = 7;
            this.Input_group.TabStop = false;
            // 
            // Risks_Input
            // 
            this.Risks_Input.Location = new System.Drawing.Point(285, 46);
            this.Risks_Input.Multiline = true;
            this.Risks_Input.Name = "Risks_Input";
            this.Risks_Input.Size = new System.Drawing.Size(591, 255);
            this.Risks_Input.TabIndex = 11;
            // 
            // Risks_label
            // 
            this.Risks_label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Risks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Risks_label.Location = new System.Drawing.Point(285, 7);
            this.Risks_label.Name = "Risks_label";
            this.Risks_label.Size = new System.Drawing.Size(591, 36);
            this.Risks_label.TabIndex = 10;
            this.Risks_label.Text = "List of risks";
            this.Risks_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 214);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 87);
            this.textBox2.TabIndex = 9;
            // 
            // Team_Names_Input
            // 
            this.Team_Names_Input.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Team_Names_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_Names_Input.Location = new System.Drawing.Point(3, 175);
            this.Team_Names_Input.Name = "Team_Names_Input";
            this.Team_Names_Input.Size = new System.Drawing.Size(279, 36);
            this.Team_Names_Input.TabIndex = 8;
            this.Team_Names_Input.Text = "Team Names";
            this.Team_Names_Input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Owner_Name_Input
            // 
            this.Owner_Name_Input.Location = new System.Drawing.Point(3, 135);
            this.Owner_Name_Input.Multiline = true;
            this.Owner_Name_Input.Name = "Owner_Name_Input";
            this.Owner_Name_Input.Size = new System.Drawing.Size(279, 37);
            this.Owner_Name_Input.TabIndex = 7;
            // 
            // Owner_Name_label
            // 
            this.Owner_Name_label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Owner_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owner_Name_label.Location = new System.Drawing.Point(3, 96);
            this.Owner_Name_label.Name = "Owner_Name_label";
            this.Owner_Name_label.Size = new System.Drawing.Size(279, 36);
            this.Owner_Name_label.TabIndex = 6;
            this.Owner_Name_label.Text = "Owner Name";
            this.Owner_Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Project_Name_input
            // 
            this.Project_Name_input.Location = new System.Drawing.Point(3, 46);
            this.Project_Name_input.Multiline = true;
            this.Project_Name_input.Name = "Project_Name_input";
            this.Project_Name_input.Size = new System.Drawing.Size(279, 47);
            this.Project_Name_input.TabIndex = 5;
            // 
            // Project_Name_label
            // 
            this.Project_Name_label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Project_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project_Name_label.Location = new System.Drawing.Point(3, 7);
            this.Project_Name_label.Name = "Project_Name_label";
            this.Project_Name_label.Size = new System.Drawing.Size(279, 36);
            this.Project_Name_label.TabIndex = 4;
            this.Project_Name_label.Text = "Project Name";
            this.Project_Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.SystemColors.HotTrack;
            this.New.Location = new System.Drawing.Point(6, 425);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(430, 40);
            this.New.TabIndex = 9;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Remove.Location = new System.Drawing.Point(458, 425);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(430, 40);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Edit.Location = new System.Drawing.Point(458, 479);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(430, 40);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(6, 9);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(882, 410);
            this.output.TabIndex = 7;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.SystemColors.HotTrack;
            this.View.Location = new System.Drawing.Point(6, 479);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(430, 40);
            this.View.TabIndex = 4;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 356);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 37);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Functional Requirements";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 356);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(430, 37);
            this.textBox3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Non-Functional Requirements";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 958);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Projectaholic";
            this.MainPanel.ResumeLayout(false);
            this.MainSideSplitContainer.Panel1.ResumeLayout(false);
            this.MainSideSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSideSplitContainer)).EndInit();
            this.MainSideSplitContainer.ResumeLayout(false);
            this.ProjectSettingSplitContainer.Panel1.ResumeLayout(false);
            this.ProjectSettingSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSettingSplitContainer)).EndInit();
            this.ProjectSettingSplitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Input_group.ResumeLayout(false);
            this.Input_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.SplitContainer MainSideSplitContainer;
        private System.Windows.Forms.SplitContainer ProjectSettingSplitContainer;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label project_label;
        private System.Windows.Forms.ListBox project_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.GroupBox Input_group;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Team_Names_Input;
        private System.Windows.Forms.TextBox Owner_Name_Input;
        private System.Windows.Forms.Label Owner_Name_label;
        private System.Windows.Forms.TextBox Project_Name_input;
        private System.Windows.Forms.Label Project_Name_label;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Risks_Input;
        private System.Windows.Forms.Label Risks_label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}