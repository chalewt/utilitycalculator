namespace UtilityCalculator
{
    partial class MainMdi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utlityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utlityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utlityToolStripMenuItem
            // 
            this.utlityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electricityToolStripMenuItem,
            this.waterToolStripMenuItem,
            this.internetToolStripMenuItem});
            this.utlityToolStripMenuItem.Name = "utlityToolStripMenuItem";
            this.utlityToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.utlityToolStripMenuItem.Text = "&Utlity";
            // 
            // electricityToolStripMenuItem
            // 
            this.electricityToolStripMenuItem.Name = "electricityToolStripMenuItem";
            this.electricityToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.electricityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.electricityToolStripMenuItem.Text = "&Electricity";
            this.electricityToolStripMenuItem.Click += new System.EventHandler(this.electricityToolStripMenuItem_Click);
            // 
            // waterToolStripMenuItem
            // 
            this.waterToolStripMenuItem.Name = "waterToolStripMenuItem";
            this.waterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.waterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waterToolStripMenuItem.Text = "&Water";
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            this.internetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.internetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.internetToolStripMenuItem.Text = "&Internet";
            // 
            // MainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 508);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMdi";
            this.Text = "Utility Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utlityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
    }
}

