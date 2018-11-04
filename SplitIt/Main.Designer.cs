namespace SplitIt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewBillFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBillFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToBillFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSplitItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewBillFamilyToolStripMenuItem,
            this.editBillFamilyToolStripMenuItem,
            this.loginToBillFamilyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewBillFamilyToolStripMenuItem
            // 
            this.createNewBillFamilyToolStripMenuItem.Name = "createNewBillFamilyToolStripMenuItem";
            this.createNewBillFamilyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.createNewBillFamilyToolStripMenuItem.Text = "Create New Bill Family";
            this.createNewBillFamilyToolStripMenuItem.Click += new System.EventHandler(this.createNewBillFamilyToolStripMenuItem_Click);
            // 
            // editBillFamilyToolStripMenuItem
            // 
            this.editBillFamilyToolStripMenuItem.Name = "editBillFamilyToolStripMenuItem";
            this.editBillFamilyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editBillFamilyToolStripMenuItem.Text = "Edit Bill Family";
            this.editBillFamilyToolStripMenuItem.Click += new System.EventHandler(this.editBillFamilyToolStripMenuItem_Click);
            // 
            // loginToBillFamilyToolStripMenuItem
            // 
            this.loginToBillFamilyToolStripMenuItem.Name = "loginToBillFamilyToolStripMenuItem";
            this.loginToBillFamilyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loginToBillFamilyToolStripMenuItem.Text = "Login to Bill Family";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSplitItToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSplitItToolStripMenuItem
            // 
            this.aboutSplitItToolStripMenuItem.Name = "aboutSplitItToolStripMenuItem";
            this.aboutSplitItToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutSplitItToolStripMenuItem.Text = "About SplitIt";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "SplitIt - Bill Sharing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewBillFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBillFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToBillFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSplitItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label newFamName;
    }
}

