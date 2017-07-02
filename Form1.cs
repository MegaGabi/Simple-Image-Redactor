using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public int ChildHeight
        {
            get { return decimal.ToInt32(nud_Height.Value); }
            set { nud_Height.Value = value;                 }
        }

        public int ChildWidth
        {
            get { return decimal.ToInt32(nud_Width.Value);  }
            set { nud_Width.Value = value;                  }
        }

        public Form1()
        {
            InitializeComponent();

            string filter = 
        "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            ofd.Filter = filter;
            ofd.InitialDirectory = Properties.Settings.Default.path;
        }

        private void mdi_Click(object sender, EventArgs e)
        {
            var needed = this.MdiChildren.First(c=>c.Text == ((ToolStripMenuItem)sender).Text);

            needed.Focus();
        }

        private void ts_Click(object sender, EventArgs e)
        {
            if (sender == ts_Open)
            {
                DialogResult res = ofd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string sourceFile = ofd.FileName;
                    OpenForm(sourceFile);
                }
            }
            else if(sender == ts_SaveAll)
            {
                ThreadPool.QueueUserWorkItem(
                    (o) =>
                    {
                        foreach(Form2 item in this.MdiChildren)
                        {
                            item.FastSave(item.path);
                        }
                    }
                );
            }
            else if(sender == ts_Close)
            {
                foreach(var item in MdiChildren)
                {
                    item.Close();
                }
            }
        }

        public void OpenForm(string sourceFile)
        {
            Form2 newMDIChild = new Form2();
            newMDIChild.path = sourceFile;

            Invoke((Action)(() => LoadImage(newMDIChild, sourceFile)));
            
            AddChild(sourceFile, newMDIChild);

            newMDIChild.Show();

            var item = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = newMDIChild.Text,
                Text = newMDIChild.Text
            };
            item.Click += mdi_Click;
            ts_Childs.DropDownItems.Add(item);
        }

        private void LoadImage(Form2 newMDIChild, string sourceFile)
        {
            var tmp = Image.FromFile(sourceFile);
            newMDIChild.Picture = new Bitmap(tmp);
            newMDIChild.PictureBox.Size = newMDIChild.Picture.Size;
            tmp.Dispose();
        }

        private void AddChild(string sourceFile, Form2 newMDIChild)
        {
            string text = Path.GetFileName(sourceFile);

            if (ts_Childs.DropDownItems.Find(text, false).Length > 0)
            {
                AddChild(Path.GetFileNameWithoutExtension(sourceFile) + "#" + Path.GetExtension(sourceFile), newMDIChild);
                return;
            }
            else
            {
                newMDIChild.MdiParent = this;
                newMDIChild.Text = text;
                newMDIChild.FormClosed += Form_Closed;
            }
        }

        private void MDragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            DragDropOpenForms(e);
        }

        private void DragDropOpenForms(DragEventArgs e)
        {
            string[] buf = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            List<string> files = buf.ToList();
            for (int i = 0; i < files.Count; i++)
            {
                var file = files[i];
                var ext = Path.GetExtension(file).ToLower();
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".gif" || ext == ".png")
                    OpenForm(file);
                else if (!(File.Exists(file)))
                {
                    if (Directory.Exists(file))
                    {
                        var buf_Files = Directory.GetFiles(file);
                        foreach (var item in buf_Files)
                            files.Add(item);
                    }
                }
            }
        }

        private void MDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ts_view_Click(object sender, EventArgs e)
        {
            if(sender == ts_view_Max)
            {
                foreach (var item in this.MdiChildren)
                    item.WindowState = FormWindowState.Maximized;
            }
            else if (sender == ts_view_Minimize)
            {
                foreach (var item in this.MdiChildren)
                    item.WindowState = FormWindowState.Minimized;
            }
            else if (sender == ts_view_Tile)
            {
               this.LayoutMdi(MdiLayout.TileHorizontal);
            }
            else if (sender == ts_view_TileVertical)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            else if (sender == ts_view_Cascade)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void btn_Resize_Click(object sender, EventArgs e)
        {
            Form2 activeChild = (Form2)this.ActiveMdiChild;

            if (activeChild != null)
            {
                var size = new Size(decimal.ToInt32(nud_Width.Value),
                                    decimal.ToInt32(nud_Height.Value));

                activeChild.PictureBox.Size = size;
            }
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            Form2 activeChild = (Form2)this.ActiveMdiChild;

            if (activeChild != null)
            {
                var size = activeChild.PictureBox.Size;

                nud_Width.Value = size.Width;
                nud_Height.Value = size.Height;
            }
        }

        private void ChangeFixedSizeClick(object sender, MouseEventArgs e)
        {
            int w = (int)nud_Width.Value,
                h = (int)nud_Height.Value;

            if(sender == b_Smaller2)
            {
                nud_Width.Value     = w / 2;
                nud_Height.Value    = h / 2;
            }
            else if(sender == b_Bigger2)
            {
                nud_Width.Value     = w * 2;
                nud_Height.Value    = h * 2;
            }

            btn_Resize_Click(null, null);
        }

        private void wh_changed(object sender, EventArgs e)
        {
            if(cb_RealTime.Checked)
            {
                btn_Resize_Click(null, null);
            }
        }

        private void cb_RealTime_CheckedChanged(object sender, EventArgs e)
        {
            btn_Resize.Enabled = !cb_RealTime.Checked;
        }

        private void p_Next_Click(object sender, EventArgs e)
        {
            Form2 activeChild = (Form2)this.ActiveMdiChild;
            var Items = ts_Childs.DropDownItems;
            if (activeChild != null)
            {
                var name = activeChild.Text;

                var curr = Items.Find(name, false);
                if(curr != null)
                {
                    int currIndex = Items.IndexOf(curr[0]);
                    if(sender == p_Next)
                    {
                        if(Items.Count > (currIndex + 1))
                        {
                            mdi_Click(Items[currIndex + 1], null);
                        }
                        else
                        {
                            mdi_Click(Items[0], null);
                        }
                    }
                    else if(sender == p_Previous)
                    {
                        if (0 <= (currIndex - 1))
                        {
                            mdi_Click(Items[currIndex - 1], null);
                        }
                        else
                        {
                            mdi_Click(Items[Items.Count - 1], null);
                        }
                    }
                }
            }
        }

        private void p_Next_MouseDown(object sender, MouseEventArgs e)
        {
            var dwn = (sender as Panel);
            dwn.Top--;
        }

        private void p_Next_MouseUp(object sender, MouseEventArgs e)
        {
            var dwn = (sender as Panel);
            dwn.Top++;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if(MdiChildren.Length > 0)
            {
                if (sender != this)
                {
                    var items = ts_Childs.DropDownItems.Find(((Form2)sender).Text, false);

                    if (items.Length > 0)
                        ts_Childs.DropDownItems.Remove(items[0]);
                }
            }
        }
    }
}
