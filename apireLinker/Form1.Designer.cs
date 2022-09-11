namespace apireLinker
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.groupBoxLink = new System.Windows.Forms.GroupBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.groupBoxLink.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLink
            // 
            this.textBoxLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLink.Location = new System.Drawing.Point(3, 26);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(375, 20);
            this.textBoxLink.TabIndex = 0;
            // 
            // buttonBuild
            // 
            this.buttonBuild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuild.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBuild.Location = new System.Drawing.Point(0, 153);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(405, 50);
            this.buttonBuild.TabIndex = 2;
            this.buttonBuild.Text = "BUILD";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // groupBoxLink
            // 
            this.groupBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLink.Controls.Add(this.textBoxLink);
            this.groupBoxLink.Location = new System.Drawing.Point(12, 10);
            this.groupBoxLink.Name = "groupBoxLink";
            this.groupBoxLink.Size = new System.Drawing.Size(381, 49);
            this.groupBoxLink.TabIndex = 5;
            this.groupBoxLink.TabStop = false;
            this.groupBoxLink.Text = "Link - URL";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFile.Controls.Add(this.textBoxFile);
            this.groupBoxFile.Location = new System.Drawing.Point(12, 85);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(381, 49);
            this.groupBoxFile.TabIndex = 6;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "File - Filename";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxFile.Location = new System.Drawing.Point(3, 26);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(375, 20);
            this.textBoxFile.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 203);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxLink);
            this.Controls.Add(this.buttonBuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "linker";
            this.groupBoxLink.ResumeLayout(false);
            this.groupBoxLink.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.GroupBox groupBoxLink;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.TextBox textBoxFile;
    }
}

