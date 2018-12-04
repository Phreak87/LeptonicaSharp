using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System;

    [DebuggerStepThrough()]
    public class BetterPictureBox : PictureBox
    {
        private System.Drawing.Drawing2D.InterpolationMode _interpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        public event ImageMouseClickEventHandler ImageMouseClick;
        public delegate void ImageMouseClickEventHandler(MouseEventArgs PT);
        public event ImageMouseMoveEventHandler ImageMouseMove;
        public delegate void ImageMouseMoveEventHandler(MouseEventArgs PT);
        public event ImageMouseUpEventHandler ImageMouseUp;
        public delegate void ImageMouseUpEventHandler(MouseEventArgs PT);
        public event ImageMouseDownEventHandler ImageMouseDown;
        public delegate void ImageMouseDownEventHandler(MouseEventArgs PT);

        public enum DrawMode
        {
            Both,
            Overlay,
            Background
        }
        public BetterPictureBox()
        {
            MouseMove += PicBox_MouseMove;
            MouseClick += PicBox_MouseClick;
            MouseUp += PicBox_MouseUp;
            MouseDown += PicBox_MouseDown;
            MouseWheel += PicBox_MouseWheel;
            this.BackColor = Color.LightGray;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //public Drawing2D.InterpolationMode InterpolationMode
        //{
        //    get { return _interpolationMode; }
        //    set
        //    {
        //        if (value != _interpolationMode)
        //        {
        //            _interpolationMode = value;
        //            this.Invalidate();
        //        }
        //    }
        //}

        [DebuggerStepThrough()]
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
        {
            //pe.Graphics.InterpolationMode = _interpolationMode
            base.OnPaint(pe);
        }
        [DebuggerStepThrough()]
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
            pevent.Graphics.InterpolationMode = _interpolationMode;
            base.OnPaintBackground(pevent);
        }

        //[DebuggerStepThrough()]
        //public System.Drawing.Point ZoomRand(System.Drawing.Point PNT)
        //{
        //    if ((this.BackgroundImage == null))
        //        return PNT;
        //    double ScaleW = (this.BackgroundImage.Width / this.Width);
        //    //       Breitenskalierung
        //    double ScaleH = (this.BackgroundImage.Height / this.Height);
        //    //     Hoehenskalierung
        //    double ScaleMin = Math.Min(ScaleH, ScaleW);
        //    //                  Die Seite, die am kleinsten skaliert ist
        //    double ScaleMax = Math.Max(ScaleH, ScaleW);
        //    //                  Die Seite, die am stärksten skaliert ist

        //    int DifPXW = this.Width - (this.BackgroundImage.Width / ScaleMax);
        //    // Anzahl der Randpixel Breite
        //    int DifPXH = this.Height - (this.BackgroundImage.Height / ScaleMax);
        //    // Anzahl der Randpixel Höhe

        //    int SolBreite = this.Width;
        //    int IstBreite = this.BackgroundImage.Width / ScaleMax;
        //    int DifBreite = (SolBreite - IstBreite) * ScaleMax;

        //    int SolHoehe = this.Height;
        //    int IstHoehe = this.BackgroundImage.Height / ScaleMax;
        //    int DifHoehe = (SolHoehe - IstHoehe) * ScaleMax;

        //    PNT.X = (PNT.X * ScaleMax) - DifBreite / 2;
        //    PNT.Y = (PNT.Y * ScaleMax) - DifHoehe / 2;
        //    return PNT;
        //}

        //[DebuggerStepThrough()]
        //public Drawing.Point StretchRand(System.Drawing.Point PNT)
        //{
        //    double ScaleW = (this.BackgroundImage.Width / this.Width);
        //    //       Breitenskalierung
        //    double ScaleH = (this.BackgroundImage.Height / this.Height);
        //    //     Hoehenskalierung
        //    double ScaleMin = Math.Min(ScaleH, ScaleW);
        //    //    Die Seite, die am kleinsten skaliert ist
        //    double ScaleMax = Math.Max(ScaleH, ScaleW);
        //    //   Die Seite, die am stärksten skaliert ist
        //    double ScaleDif = ScaleMax - ScaleMin;
        //    //                            '  Differenz der Faktoren
        //    PNT.X = ( PNT.X * (int)ScaleW);
        //    PNT.Y = (PNT.Y * (int)ScaleH);
        //    return PNT;
        //}

        public void LoadImage(Image Picture, Image Overlay = null)
        {
            if ((this.Image != null)) { this.Image.Dispose(); this.Image = null; }

            if (this.Left < 0)
                this.Left = 0;
            if (this.Top < 0)
                this.Top = 0;
            if (this.Width < 100)
                this.Width = 100;
            if (this.Height < 100)
                this.Height = 100;

            if ((Picture == null))
                return;
            this.BackgroundImage = Picture;
            RefreshPic();
        }

        public delegate void PicRefresh();
        [DebuggerStepThrough()]
        public void RefreshPic()
        {
            try
            {
                if (this.InvokeRequired == true)
                {
                    this.Invoke((PicRefresh)RefreshPic);
                    return;
                }
                else
                {
                    this.Refresh();
                }
            }
            catch
            {
            }
        }

        public void LoadImage(string Filename)
        {
            if ((this.Image != null)) { this.Image.Dispose(); this.Image = null; }
            if ((this.BackgroundImage != null)) { this.BackgroundImage.Dispose(); this.BackgroundImage = null; }

            bool Test = false;
            int TestI = 0;
            while (!(Test == true | TestI >= 20))
            {
                try
                {
                    System.IO.FileStream FSTest = new System.IO.FileStream(Filename, System.IO.FileMode.Open);
                    FSTest.Dispose();
                    FSTest = null;
                    Test = true;
                    using (System.IO.FileStream FS = new System.IO.FileStream(Filename, System.IO.FileMode.Open))
                    {
                        //Bitmap BMP = Bitmap.FromStream(FS);
                        //this.BackgroundImage = BMP;
                    }
                }
                catch
                {
                    TestI += 1;
                }
            }

            RefreshPic();
        }

        public Image LoadUnblock(string Filename)
        {
            Bitmap BMP = null;
            if (File.Exists(Filename) == false)
                return null;
            using (System.IO.FileStream FS = new System.IO.FileStream(Filename, System.IO.FileMode.Open))
            {
                // BMP = Bitmap.FromStream(FS);
            }
            return BMP;
        }

        #region "Picturebox Events + Zoom and Move"
        int MPosX;
        int MPosY;
        public enum ImageEvent
        {
            MouseMove,
            MouseClick,
            MouseDown,
            MouseUp
        }

        [DebuggerStepThrough()]
        public void SendEvent(MouseEventArgs e, ImageEvent Evt)
        {
            System.Drawing.Point PNT= PointConverter(e);

            switch (Evt)
            {
                case ImageEvent.MouseClick:
                    if (ImageMouseClick != null)
                    {
                        ImageMouseClick(new MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta));
                    }

                    break;
                case ImageEvent.MouseDown:
                    if (ImageMouseDown != null)
                    {
                        ImageMouseDown(new MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta));
                    }

                    break;
                case ImageEvent.MouseMove:
                    if (ImageMouseMove != null)
                    {
                        ImageMouseMove(new MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta));
                    }

                    break;
                case ImageEvent.MouseUp:
                    if (ImageMouseUp != null)
                    {
                        ImageMouseUp(new MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta));
                    }

                    break;
            }
        }

        [DebuggerStepThrough()]
        public System.Drawing.Point PointConverter(System.Windows.Forms.MouseEventArgs Point)
        {
            //System.Drawing.Point PNT = new System.Drawing.Point(Point.X, Point.Y);
            //switch (this.SizeMode)
            //{
            //    case PictureBoxSizeMode.Zoom:
            //        PNT = ZoomRand(PNT);
            //        break;
            //    case PictureBoxSizeMode.StretchImage:
            //        PNT = StretchRand(PNT);
            //        break;
            //}
            //return PNT;
            return new System.Drawing.Point (0,0);
        }

        private void PicBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendEvent(e, ImageEvent.MouseDown);
            if (e.Button != System.Windows.Forms.MouseButtons.Middle)
                return;
            MPosX = e.X;
            MPosY = e.Y;
        }
        private void PicBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendEvent(e, ImageEvent.MouseUp);
            if (e.Button != System.Windows.Forms.MouseButtons.Middle)
                return;
            MPosX = 0;
            MPosY = 0;
        }
        private void PicBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendEvent(e, ImageEvent.MouseClick);
        }

        [DebuggerStepThrough()]
        private void PicBox_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.Width = this.Width + 200;
                this.Left = this.Left - 100;
                this.Height = this.Height + 200;
                this.Top = this.Top - 100;
            }
            else
            {
                if (this.Height > 250 & this.Width > 250)
                {
                    this.Width = this.Width - 200;
                    this.Left = this.Left + 100;
                    this.Height = this.Height - 200;
                    this.Top = this.Top + 100;
                }
            }
            // If Me.Left < Me.Width * -1 Then Me.Left = 0
        }
        [DebuggerStepThrough()]
        private void PicBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendEvent(e, ImageEvent.MouseMove);
            this.Select();
            if (e.Button != System.Windows.Forms.MouseButtons.Middle)
                return;
            if (MPosX == 0)
                return;
            if (MPosY == 0)
                return;
            this.Top = this.Top - (MPosY - e.Y);
            this.Left = this.Left - (MPosX - e.X);
        }
        #endregion

    }


