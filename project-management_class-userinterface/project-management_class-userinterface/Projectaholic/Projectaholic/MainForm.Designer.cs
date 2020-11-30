
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
            this.Settings = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSideSplitContainer)).BeginInit();
            this.MainSideSplitContainer.Panel1.SuspendLayout();
            this.MainSideSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSettingSplitContainer)).BeginInit();
            this.ProjectSettingSplitContainer.Panel2.SuspendLayout();
            this.ProjectSettingSplitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // ProjectSettingSplitContainer.Panel2
            // 
            this.ProjectSettingSplitContainer.Panel2.Controls.Add(this.groupBox1);
            this.ProjectSettingSplitContainer.Size = new System.Drawing.Size(309, 958);
            this.ProjectSettingSplitContainer.SplitterDistance = 697;
            this.ProjectSettingSplitContainer.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.MainSideSplitContainer)).EndInit();
            this.MainSideSplitContainer.ResumeLayout(false);
            this.ProjectSettingSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSettingSplitContainer)).EndInit();
            this.ProjectSettingSplitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
    }
}