namespace BTL
{
    partial class FQuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuanLi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíSảnPhẩmToolStripMenuItem,
            this.quảnLíĐơnHàngToolStripMenuItem,
            this.quảnLíKháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíSảnPhẩmToolStripMenuItem
            // 
            this.quảnLíSảnPhẩmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíSảnPhẩmToolStripMenuItem.Image")));
            this.quảnLíSảnPhẩmToolStripMenuItem.Name = "quảnLíSảnPhẩmToolStripMenuItem";
            this.quảnLíSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.quảnLíSảnPhẩmToolStripMenuItem.Text = "Quản lí sản phẩm";
            this.quảnLíSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLíSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLíĐơnHàngToolStripMenuItem
            // 
            this.quảnLíĐơnHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíĐơnHàngToolStripMenuItem.Image")));
            this.quảnLíĐơnHàngToolStripMenuItem.Name = "quảnLíĐơnHàngToolStripMenuItem";
            this.quảnLíĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.quảnLíĐơnHàngToolStripMenuItem.Text = "Quản lí đơn hàng";
            this.quảnLíĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíĐơnHàngToolStripMenuItem_Click);
            // 
            // quảnLíKháchHàngToolStripMenuItem
            // 
            this.quảnLíKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíKháchHàngToolStripMenuItem.Image")));
            this.quảnLíKháchHàngToolStripMenuItem.Name = "quảnLíKháchHàngToolStripMenuItem";
            this.quảnLíKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.quảnLíKháchHàngToolStripMenuItem.Text = "Quản lí khách hàng";
            this.quảnLíKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíKháchHàngToolStripMenuItem_Click);
            // 
            // FQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 643);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FQuanLi";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíKháchHàngToolStripMenuItem;
    }
}