namespace ParseComManager
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnLogins = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupLineSeparator = new System.Windows.Forms.GroupBox();
            this.btnConfigurationFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogins
            // 
            this.btnLogins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogins.Location = new System.Drawing.Point(12, 12);
            this.btnLogins.Name = "btnLogins";
            this.btnLogins.Size = new System.Drawing.Size(226, 32);
            this.btnLogins.TabIndex = 0;
            this.btnLogins.Text = "Logins";
            this.btnLogins.UseVisualStyleBackColor = true;
            this.btnLogins.Click += new System.EventHandler(this.btnLogins_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(12, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupLineSeparator
            // 
            this.groupLineSeparator.Location = new System.Drawing.Point(12, 193);
            this.groupLineSeparator.Name = "groupLineSeparator";
            this.groupLineSeparator.Size = new System.Drawing.Size(226, 10);
            this.groupLineSeparator.TabIndex = 2;
            this.groupLineSeparator.TabStop = false;
            // 
            // btnConfigurationFile
            // 
            this.btnConfigurationFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurationFile.Location = new System.Drawing.Point(12, 155);
            this.btnConfigurationFile.Name = "btnConfigurationFile";
            this.btnConfigurationFile.Size = new System.Drawing.Size(226, 32);
            this.btnConfigurationFile.TabIndex = 1;
            this.btnConfigurationFile.Text = "Open configuration file";
            this.btnConfigurationFile.UseVisualStyleBackColor = true;
            this.btnConfigurationFile.Click += new System.EventHandler(this.btnConfigurationFile_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfigurationFile);
            this.Controls.Add(this.groupLineSeparator);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(268, 300);
            this.MinimumSize = new System.Drawing.Size(268, 300);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogins;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupLineSeparator;
        private System.Windows.Forms.Button btnConfigurationFile;
    }
}

