namespace WindowsFormsApplication5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Childs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_view_Max = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_view_Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_view_Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_view_Tile = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_view_TileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_Next = new System.Windows.Forms.Panel();
            this.p_Previous = new System.Windows.Forms.Panel();
            this.cb_RealTime = new System.Windows.Forms.CheckBox();
            this.b_Bigger2 = new System.Windows.Forms.Button();
            this.b_Smaller2 = new System.Windows.Forms.Button();
            this.btn_Resize = new System.Windows.Forms.Button();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ts_SaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ts_Childs,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Open,
            this.ts_SaveAll,
            this.ts_Close});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // ts_Open
            // 
            this.ts_Open.Name = "ts_Open";
            this.ts_Open.Size = new System.Drawing.Size(153, 22);
            this.ts_Open.Text = "Открыть";
            this.ts_Open.Click += new System.EventHandler(this.ts_Click);
            // 
            // ts_Childs
            // 
            this.ts_Childs.Name = "ts_Childs";
            this.ts_Childs.Size = new System.Drawing.Size(47, 20);
            this.ts_Childs.Text = "Окна";
            this.ts_Childs.Click += new System.EventHandler(this.ts_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_view_Max,
            this.ts_view_Minimize,
            this.ts_view_Cascade,
            this.ts_view_Tile,
            this.ts_view_TileVertical});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem2.Text = "Вид";
            // 
            // ts_view_Max
            // 
            this.ts_view_Max.Name = "ts_view_Max";
            this.ts_view_Max.Size = new System.Drawing.Size(202, 22);
            this.ts_view_Max.Text = "Максимизировать";
            this.ts_view_Max.Click += new System.EventHandler(this.ts_view_Click);
            // 
            // ts_view_Minimize
            // 
            this.ts_view_Minimize.Name = "ts_view_Minimize";
            this.ts_view_Minimize.Size = new System.Drawing.Size(202, 22);
            this.ts_view_Minimize.Text = "Минимизировать";
            this.ts_view_Minimize.Click += new System.EventHandler(this.ts_view_Click);
            // 
            // ts_view_Cascade
            // 
            this.ts_view_Cascade.Name = "ts_view_Cascade";
            this.ts_view_Cascade.Size = new System.Drawing.Size(202, 22);
            this.ts_view_Cascade.Text = "Окна каскадом";
            this.ts_view_Cascade.Click += new System.EventHandler(this.ts_view_Click);
            // 
            // ts_view_Tile
            // 
            this.ts_view_Tile.Name = "ts_view_Tile";
            this.ts_view_Tile.Size = new System.Drawing.Size(202, 22);
            this.ts_view_Tile.Text = "Горизантальная стопка";
            this.ts_view_Tile.Click += new System.EventHandler(this.ts_view_Click);
            // 
            // ts_view_TileVertical
            // 
            this.ts_view_TileVertical.Name = "ts_view_TileVertical";
            this.ts_view_TileVertical.Size = new System.Drawing.Size(202, 22);
            this.ts_view_TileVertical.Text = "Вертикальная стопка";
            this.ts_view_TileVertical.Click += new System.EventHandler(this.ts_view_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.p_Next);
            this.panel1.Controls.Add(this.p_Previous);
            this.panel1.Controls.Add(this.cb_RealTime);
            this.panel1.Controls.Add(this.b_Bigger2);
            this.panel1.Controls.Add(this.b_Smaller2);
            this.panel1.Controls.Add(this.btn_Resize);
            this.panel1.Controls.Add(this.nud_Height);
            this.panel1.Controls.Add(this.nud_Width);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 412);
            this.panel1.TabIndex = 2;
            // 
            // p_Next
            // 
            this.p_Next.BackColor = System.Drawing.Color.Transparent;
            this.p_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_Next.BackgroundImage")));
            this.p_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_Next.Location = new System.Drawing.Point(89, 219);
            this.p_Next.Name = "p_Next";
            this.p_Next.Size = new System.Drawing.Size(38, 48);
            this.p_Next.TabIndex = 10;
            this.p_Next.Click += new System.EventHandler(this.p_Next_Click);
            this.p_Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Next_MouseDown);
            this.p_Next.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_Next_MouseUp);
            // 
            // p_Previous
            // 
            this.p_Previous.BackColor = System.Drawing.Color.Transparent;
            this.p_Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_Previous.BackgroundImage")));
            this.p_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_Previous.Location = new System.Drawing.Point(52, 228);
            this.p_Previous.Name = "p_Previous";
            this.p_Previous.Size = new System.Drawing.Size(31, 29);
            this.p_Previous.TabIndex = 9;
            this.p_Previous.Click += new System.EventHandler(this.p_Next_Click);
            this.p_Previous.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Next_MouseDown);
            this.p_Previous.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_Next_MouseUp);
            // 
            // cb_RealTime
            // 
            this.cb_RealTime.AutoSize = true;
            this.cb_RealTime.Location = new System.Drawing.Point(6, 112);
            this.cb_RealTime.Name = "cb_RealTime";
            this.cb_RealTime.Size = new System.Drawing.Size(157, 43);
            this.cb_RealTime.TabIndex = 8;
            this.cb_RealTime.Text = "Изменять изображение в\r\n\r\nреальном времени";
            this.cb_RealTime.UseVisualStyleBackColor = true;
            this.cb_RealTime.CheckedChanged += new System.EventHandler(this.cb_RealTime_CheckedChanged);
            // 
            // b_Bigger2
            // 
            this.b_Bigger2.Location = new System.Drawing.Point(15, 161);
            this.b_Bigger2.Name = "b_Bigger2";
            this.b_Bigger2.Size = new System.Drawing.Size(134, 23);
            this.b_Bigger2.TabIndex = 7;
            this.b_Bigger2.Text = "Увеличить в 2 раза";
            this.b_Bigger2.UseVisualStyleBackColor = true;
            this.b_Bigger2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeFixedSizeClick);
            // 
            // b_Smaller2
            // 
            this.b_Smaller2.Location = new System.Drawing.Point(15, 190);
            this.b_Smaller2.Name = "b_Smaller2";
            this.b_Smaller2.Size = new System.Drawing.Size(134, 23);
            this.b_Smaller2.TabIndex = 6;
            this.b_Smaller2.Text = "Уменьшить в 2 раза";
            this.b_Smaller2.UseVisualStyleBackColor = true;
            this.b_Smaller2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeFixedSizeClick);
            // 
            // btn_Resize
            // 
            this.btn_Resize.Location = new System.Drawing.Point(89, 83);
            this.btn_Resize.Name = "btn_Resize";
            this.btn_Resize.Size = new System.Drawing.Size(75, 23);
            this.btn_Resize.TabIndex = 5;
            this.btn_Resize.Text = "Изменить размер";
            this.btn_Resize.UseVisualStyleBackColor = true;
            this.btn_Resize.Click += new System.EventHandler(this.btn_Resize_Click);
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(63, 57);
            this.nud_Height.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nud_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(71, 20);
            this.nud_Height.TabIndex = 4;
            this.nud_Height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Height.ValueChanged += new System.EventHandler(this.wh_changed);
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(63, 34);
            this.nud_Width.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nud_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(71, 20);
            this.nud_Width.TabIndex = 3;
            this.nud_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Width.ValueChanged += new System.EventHandler(this.wh_changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер выбранной  картинки:";
            // 
            // ts_SaveAll
            // 
            this.ts_SaveAll.Name = "ts_SaveAll";
            this.ts_SaveAll.Size = new System.Drawing.Size(153, 22);
            this.ts_SaveAll.Text = "Сохранить все";
            this.ts_SaveAll.Click += new System.EventHandler(this.ts_Click);
            // 
            // ts_Close
            // 
            this.ts_Close.Name = "ts_Close";
            this.ts_Close.Size = new System.Drawing.Size(153, 22);
            this.ts_Close.Text = "Закрыть все";
            this.ts_Close.Click += new System.EventHandler(this.ts_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(602, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(186, 350);
            this.Name = "Form1";
            this.Text = "Редактор изображений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MDragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ts_Open;
        private System.Windows.Forms.ToolStripMenuItem ts_Childs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ts_view_Max;
        private System.Windows.Forms.ToolStripMenuItem ts_view_Minimize;
        private System.Windows.Forms.ToolStripMenuItem ts_view_Cascade;
        private System.Windows.Forms.ToolStripMenuItem ts_view_Tile;
        private System.Windows.Forms.ToolStripMenuItem ts_view_TileVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Resize;
        private System.Windows.Forms.Button b_Bigger2;
        private System.Windows.Forms.Button b_Smaller2;
        private System.Windows.Forms.CheckBox cb_RealTime;
        private System.Windows.Forms.Panel p_Next;
        private System.Windows.Forms.Panel p_Previous;
        private System.Windows.Forms.ToolStripMenuItem ts_SaveAll;
        private System.Windows.Forms.ToolStripMenuItem ts_Close;
    }
}

