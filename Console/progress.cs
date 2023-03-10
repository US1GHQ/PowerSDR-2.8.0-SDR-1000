//=================================================================
// progress.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2003-2013  FlexRadio Systems
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// You may contact us via email at: gpl@flexradio.com.
// Paper mail may be sent to: 
//    FlexRadio Systems
//    4616 W. Howard Lane  Suite 1-150
//    Austin, TX 78728
//    USA
//=================================================================

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace PowerSDR
{
    public  partial class Progress : System.Windows.Forms.Form
    {
        #region Variable Declaration

        private float percent_done;

        #endregion

        #region Constructor and Destructor

        public Progress(string s)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.Text = s;
            this.TopMost = true; // .202

            percent_done = 0.0f;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion
        

        #region Misc Routines

        private delegate void Invoker(float f);

        public void SetPercent(float f)
        {
            percent_done = f * 100; ;
            panel1.Invalidate();
        }

        #endregion

        #region Event Handlers

        private void btnAbort_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private string digits = "f0";
        private int percent_digits = 0;
        public int PercentDigits
        {
            get { return percent_digits; }
            set
            {
                percent_digits = value;
                digits = "f" + percent_digits.ToString();
            }
        }

        private string percent_symbol = "%";
        public string PercentSymbol
        {
            get { return percent_symbol; }
            set { percent_symbol = value; }
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int bar = (int)Math.Floor(panel1.Width * percent_done / 100);
            if (bar == 0) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush b = new LinearGradientBrush(
                new Rectangle(0, 0, bar, panel1.Height),
                Color.Green,
                Color.Lime,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b, 0, 0, bar, panel1.Height);

            string s = percent_done.ToString(digits) + percent_symbol;
            SolidBrush b2 = new SolidBrush(Color.Black);
            Font f = new Font("Microsoft Sans Serif", 10);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(s, f, b2, new RectangleF(0, 0, panel1.Width, panel1.Height), sf);
        }

        private void Progress_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        #endregion
    }
}
