namespace IMAGE_EDITOR_V2
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxContrast = new System.Windows.Forms.Label();
            this.lblCurrentContrast = new System.Windows.Forms.Label();
            this.lblMinContrast = new System.Windows.Forms.Label();
            this.trkContrast = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaxBrightness = new System.Windows.Forms.Label();
            this.lblCurrentBrightness = new System.Windows.Forms.Label();
            this.lblMinBrightness = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkContrast)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 49);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(829, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxContrast);
            this.groupBox1.Controls.Add(this.lblCurrentContrast);
            this.groupBox1.Controls.Add(this.lblMinContrast);
            this.groupBox1.Controls.Add(this.trkContrast);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 399);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(829, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrast";
            // 
            // lblMaxContrast
            // 
            this.lblMaxContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMaxContrast.AutoSize = true;
            this.lblMaxContrast.Location = new System.Drawing.Point(773, 57);
            this.lblMaxContrast.Name = "lblMaxContrast";
            this.lblMaxContrast.Size = new System.Drawing.Size(31, 16);
            this.lblMaxContrast.TabIndex = 3;
            this.lblMaxContrast.Text = "2.00";
            // 
            // lblCurrentContrast
            // 
            this.lblCurrentContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCurrentContrast.AutoSize = true;
            this.lblCurrentContrast.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentContrast.Location = new System.Drawing.Point(278, 55);
            this.lblCurrentContrast.Name = "lblCurrentContrast";
            this.lblCurrentContrast.Size = new System.Drawing.Size(14, 16);
            this.lblCurrentContrast.TabIndex = 2;
            this.lblCurrentContrast.Text = "0";
            // 
            // lblMinContrast
            // 
            this.lblMinContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinContrast.AutoSize = true;
            this.lblMinContrast.Location = new System.Drawing.Point(13, 57);
            this.lblMinContrast.Name = "lblMinContrast";
            this.lblMinContrast.Size = new System.Drawing.Size(35, 16);
            this.lblMinContrast.TabIndex = 1;
            this.lblMinContrast.Text = "-1.00";
            // 
            // trkContrast
            // 
            this.trkContrast.AutoSize = false;
            this.trkContrast.BackColor = System.Drawing.Color.DarkGreen;
            this.trkContrast.Dock = System.Windows.Forms.DockStyle.Top;
            this.trkContrast.Location = new System.Drawing.Point(3, 17);
            this.trkContrast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trkContrast.Maximum = 200;
            this.trkContrast.Minimum = -100;
            this.trkContrast.Name = "trkContrast";
            this.trkContrast.Size = new System.Drawing.Size(823, 36);
            this.trkContrast.TabIndex = 0;
            this.trkContrast.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaxBrightness);
            this.groupBox2.Controls.Add(this.lblCurrentBrightness);
            this.groupBox2.Controls.Add(this.lblMinBrightness);
            this.groupBox2.Controls.Add(this.trkBrightness);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(706, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(123, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brightness";
            // 
            // lblMaxBrightness
            // 
            this.lblMaxBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaxBrightness.AutoSize = true;
            this.lblMaxBrightness.Location = new System.Drawing.Point(55, 22);
            this.lblMaxBrightness.Name = "lblMaxBrightness";
            this.lblMaxBrightness.Size = new System.Drawing.Size(35, 16);
            this.lblMaxBrightness.TabIndex = 3;
            this.lblMaxBrightness.Text = "-1.00";
            // 
            // lblCurrentBrightness
            // 
            this.lblCurrentBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrentBrightness.AutoSize = true;
            this.lblCurrentBrightness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentBrightness.Cursor = System.Windows.Forms.Cursors.No;
            this.lblCurrentBrightness.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentBrightness.Location = new System.Drawing.Point(52, 177);
            this.lblCurrentBrightness.Name = "lblCurrentBrightness";
            this.lblCurrentBrightness.Size = new System.Drawing.Size(14, 16);
            this.lblCurrentBrightness.TabIndex = 2;
            this.lblCurrentBrightness.Text = "0";
            // 
            // lblMinBrightness
            // 
            this.lblMinBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMinBrightness.AutoSize = true;
            this.lblMinBrightness.Location = new System.Drawing.Point(52, 327);
            this.lblMinBrightness.Name = "lblMinBrightness";
            this.lblMinBrightness.Size = new System.Drawing.Size(31, 16);
            this.lblMinBrightness.TabIndex = 1;
            this.lblMinBrightness.Text = "1.00";
            // 
            // trkBrightness
            // 
            this.trkBrightness.AutoSize = false;
            this.trkBrightness.BackColor = System.Drawing.Color.Crimson;
            this.trkBrightness.Dock = System.Windows.Forms.DockStyle.Left;
            this.trkBrightness.Location = new System.Drawing.Point(3, 17);
            this.trkBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trkBrightness.Maximum = 100;
            this.trkBrightness.Minimum = -100;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBrightness.Size = new System.Drawing.Size(43, 331);
            this.trkBrightness.TabIndex = 0;
            this.trkBrightness.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 350);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkContrast)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxContrast;
        private System.Windows.Forms.Label lblCurrentContrast;
        private System.Windows.Forms.Label lblMinContrast;
        private System.Windows.Forms.TrackBar trkContrast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaxBrightness;
        private System.Windows.Forms.Label lblCurrentBrightness;
        private System.Windows.Forms.Label lblMinBrightness;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}