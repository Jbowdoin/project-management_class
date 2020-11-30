
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
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSideSplitContainer)).BeginInit();
            this.MainSideSplitContainer.Panel1.SuspendLayout();
            this.MainSideSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSettingSplitContainer)).BeginInit();
            this.ProjectSettingSplitContainer.SuspendLayout();
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
            this.ProjectSettingSplitContainer.Size = new System.Drawing.Size(309, 958);
            this.ProjectSettingSplitContainer.SplitterDistance = 697;
            this.ProjectSettingSplitContainer.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSettingSplitContainer)).EndInit();
            this.ProjectSettingSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.SplitContainer MainSideSplitContainer;
        private System.Windows.Forms.SplitContainer ProjectSettingSplitContainer;
    }
}