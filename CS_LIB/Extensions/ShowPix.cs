using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeptonicaSharp.Extensions
{
    public partial class ShowPix : Form
    {
        BetterPictureBox PicBox = new BetterPictureBox();
        public ShowPix()
        {
            InitializeComponent();
        }

        public ShowPix(Bitmap Pix, string Text = "")
        {
            Load += ShowPix_Load;
            InitializeComponent();
            this.Text = Text;
            if ((Pix == null))
                return;
            PicBox.LoadImage(Pix);
            this.ShowDialog();
        }
        public ShowPix(Pix Pix, string Text = "")
        {
            Load += ShowPix_Load;
            InitializeComponent();
            this.Text = Text;
            if (Pix == null) { return; }
            PicBox.LoadImage(Pix.ToBitmap());
            this.ShowDialog();
        }
        private void ShowPix_Load(object sender, EventArgs e)
        {
            PicBox.Left = 0;
            PicBox.Top = 0;
            PicBox.Width = this.Width;
            PicBox.Height = this.Height;
            this.Controls.Add(PicBox);
        }
    }
}
