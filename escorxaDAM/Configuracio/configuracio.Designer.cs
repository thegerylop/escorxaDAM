namespace Configuracio
{
    partial class configuracio
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
            if(disposing && (components != null))
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.paisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paisosToolStripMenuItem,
            this.provasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // paisosToolStripMenuItem
            // 
            this.paisosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.paisosToolStripMenuItem.Name = "paisosToolStripMenuItem";
            this.paisosToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.paisosToolStripMenuItem.Text = "Paisos";
            this.paisosToolStripMenuItem.Click += new System.EventHandler(this.paisosToolStripMenuItem_Click);
            // 
            // provasToolStripMenuItem
            // 
            this.provasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.provasToolStripMenuItem.Name = "provasToolStripMenuItem";
            this.provasToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.provasToolStripMenuItem.Text = "provas";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 585);
            this.panel1.TabIndex = 2;
            // 
            // configuracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1083, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "configuracio";
            this.ShowIcon = false;
            this.Text = "configuracio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem paisosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem provasToolStripMenuItem;
    }
}