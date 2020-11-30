
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
            this.project_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Account = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.project_list = new System.Windows.Forms.ListBox();
            this.View = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            // View
            // 
            this.View.BackColor = System.Drawing.SystemColors.HotTrack;
            this.View.Location = new System.Drawing.Point(6, 19);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(115, 48);
            this.View.TabIndex = 4;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Edit.Location = new System.Drawing.Point(127, 19);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(115, 48);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.View);
            this.groupBox2.Controls.Add(this.Edit);
            this.groupBox2.Location = new System.Drawing.Point(378, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
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
    }
}