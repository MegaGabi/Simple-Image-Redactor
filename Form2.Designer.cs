namespace WindowsFormsApplication5
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
            this.pb_Picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_SizeInfo = new System.Windows.Forms.ToolStripTextBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Picture
            // 
            this.pb_Picture.Location = new System.Drawing.Point(0, 0);
            this.pb_Picture.Name = "pb_Picture";
            this.pb_Picture.Size = new System.Drawing.Size(554, 372);
            this.pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Picture.TabIndex = 0;
            this.pb_Picture.TabStop = false;
            this.pb_Picture.DoubleClick += new System.EventHandler(this.pb_Picture_DoubleClick);
            this.pb_Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pb_Picture.Resize += new System.EventHandler(this.Form2_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tb_SizeInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Save,
            this.ts_Close});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 23);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // ts_Save
            // 
            this.ts_Save.Name = "ts_Save";
            this.ts_Save.Size = new System.Drawing.Size(132, 22);
            this.ts_Save.Text = "Сохранить";
            this.ts_Save.Click += new System.EventHandler(this.ts_Click);
            // 
            // ts_Close
            // 
            this.ts_Close.Name = "ts_Close";
            this.ts_Close.Size = new System.Drawing.Size(132, 22);
            this.ts_Close.Text = "Закрыть";
            this.ts_Close.Click += new System.EventHandler(this.ts_Click);
            // 
            // tb_SizeInfo
            // 
            this.tb_SizeInfo.Name = "tb_SizeInfo";
            this.tb_SizeInfo.ReadOnly = true;
            this.tb_SizeInfo.Size = new System.Drawing.Size(160, 23);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pb_Picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 372);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(554, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(40000, 40000);
            this.MinimumSize = new System.Drawing.Size(239, 38);
            this.Name = "Form2";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ts_Save;
        private System.Windows.Forms.ToolStripMenuItem ts_Close;
        private System.Windows.Forms.ToolStripTextBox tb_SizeInfo;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Panel panel1;
    }
}