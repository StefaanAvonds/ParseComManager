namespace ParseComManager.Forms
{
    partial class FVTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVTables));
            this.gridTables = new System.Windows.Forms.DataGridView();
            this.splitter = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTables
            // 
            this.gridTables.AllowUserToAddRows = false;
            this.gridTables.AllowUserToDeleteRows = false;
            this.gridTables.AllowUserToOrderColumns = true;
            this.gridTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridTables.Location = new System.Drawing.Point(0, 0);
            this.gridTables.Name = "gridTables";
            this.gridTables.ReadOnly = true;
            this.gridTables.RowTemplate.Height = 24;
            this.gridTables.Size = new System.Drawing.Size(240, 319);
            this.gridTables.TabIndex = 0;
            this.gridTables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTables_CellDoubleClick);
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(240, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 319);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // FVTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 319);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.gridTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FVTables";
            this.Text = "Tables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FVTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTables;
        private System.Windows.Forms.Splitter splitter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}