using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Security.AccessControl;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public string path;

        DialogResult answer;
        bool Resized = false;

        public Image Picture
        {
            get{return pb_Picture.Image;}
            set{pb_Picture.Image = value;}
        }

        public PictureBox PictureBox
        {
            get { return pb_Picture; }
        }

        public Form2()
        {
            InitializeComponent();

            string filter =
       "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            sfd.Filter = filter;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (!Resized)
                Resized = true;

            tb_SizeInfo.Text = "Размер: " + pb_Picture.Width + "х" + pb_Picture.Height;

            if (MdiParent != null)
            {
                ((Form1)MdiParent).ChildHeight = pb_Picture.Height;
                ((Form1)MdiParent).ChildWidth = pb_Picture.Width;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2_Resize(null, null);
            Resized = false;
        }

        private void ts_Click(object sender, EventArgs e)
        {
           
            if (sender == ts_Save)
            {
                sfd.FileName = Path.GetFileNameWithoutExtension(this.Text);
                answer = MessageBox.Show("Сохранить картинку с выбранным размером?", 
                                             "Сохранить?",
                                             MessageBoxButtons.YesNoCancel);

                if(answer == DialogResult.No || answer == DialogResult.Cancel)
                {
                    return;
                }

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    string source = sfd.FileName;
                    FastSave(source);
                }
            }
            else if(sender == ts_Close)
            {
                Close();
            }
        }

        public void FastSave(string source)
        {

            source = Path.GetDirectoryName(path);
            source = Path.Combine(source, this.Text);

            int w = pb_Picture.ClientSize.Width,
                h = pb_Picture.ClientSize.Height;

            using (Bitmap bm = new Bitmap(
                w,
                h))
            {
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    Rectangle source_rect = new Rectangle(
                        0, 0, pb_Picture.Image.Width, pb_Picture.Image.Height);
                    Rectangle dest_rect = new Rectangle(
                        0, 0, bm.Width, bm.Height);
                    gr.DrawImage(pb_Picture.Image,
                        dest_rect, source_rect, GraphicsUnit.Pixel);

                    gr.Flush();
                }

                bm.Save(source);

                bm.Dispose();
            }
            Resized = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Resized)
            {
                ts_Click(ts_Save, null);
                if (answer == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    answer = DialogResult.None;
                    return;
                }
            }

            pb_Picture.Image.Dispose();

            if (MdiParent != null)
            {
                ((Form1)MdiParent).ChildHeight = 1;
                ((Form1)MdiParent).ChildWidth = 1;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!panel1.Focused)
                panel1.Focus();
        }

        private void pb_Picture_DoubleClick(object sender, EventArgs e)
        {

            if(MdiParent != null)
            {
                var parent = (Form1)MdiParent;
                parent.OpenForm(path);
            }
        }
    }
}
