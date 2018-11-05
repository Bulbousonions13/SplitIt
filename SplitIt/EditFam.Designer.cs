namespace SplitIt
{
    partial class EditFam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFam));
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterEmailLabel = new System.Windows.Forms.Label();
            this.enterNameTB = new System.Windows.Forms.TextBox();
            this.enterEmailTB = new System.Windows.Forms.TextBox();
            this.enterMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(124, 116);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(122, 13);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Enter Member 1 Name : ";
            // 
            // enterEmailLabel
            // 
            this.enterEmailLabel.AutoSize = true;
            this.enterEmailLabel.Location = new System.Drawing.Point(124, 151);
            this.enterEmailLabel.Name = "enterEmailLabel";
            this.enterEmailLabel.Size = new System.Drawing.Size(119, 13);
            this.enterEmailLabel.TabIndex = 1;
            this.enterEmailLabel.Text = "Enter Member 1 Email : ";
            // 
            // enterNameTB
            // 
            this.enterNameTB.Location = new System.Drawing.Point(253, 116);
            this.enterNameTB.Name = "enterNameTB";
            this.enterNameTB.Size = new System.Drawing.Size(231, 20);
            this.enterNameTB.TabIndex = 2;
            // 
            // enterEmailTB
            // 
            this.enterEmailTB.Location = new System.Drawing.Point(253, 148);
            this.enterEmailTB.Name = "enterEmailTB";
            this.enterEmailTB.Size = new System.Drawing.Size(231, 20);
            this.enterEmailTB.TabIndex = 3;
            // 
            // enterMemberButton
            // 
            this.enterMemberButton.Location = new System.Drawing.Point(253, 216);
            this.enterMemberButton.Name = "enterMemberButton";
            this.enterMemberButton.Size = new System.Drawing.Size(108, 23);
            this.enterMemberButton.TabIndex = 4;
            this.enterMemberButton.Text = "Create Member";
            this.enterMemberButton.UseVisualStyleBackColor = true;
            this.enterMemberButton.Click += new System.EventHandler(this.enterMemberButton_Click);
            // 
            // EditFam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 408);
            this.Controls.Add(this.enterMemberButton);
            this.Controls.Add(this.enterEmailTB);
            this.Controls.Add(this.enterNameTB);
            this.Controls.Add(this.enterEmailLabel);
            this.Controls.Add(this.enterNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditFam";
            this.Text = "Edit Family";
            this.Load += new System.EventHandler(this.EditFam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label enterEmailLabel;
        private System.Windows.Forms.TextBox enterNameTB;
        private System.Windows.Forms.TextBox enterEmailTB;
        private System.Windows.Forms.Button enterMemberButton;
    }
}