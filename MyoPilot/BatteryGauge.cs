using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MyoPilot
{
    [DefaultBindingProperty("ChargePercentage")]
    class BatteryGauge : Control
    {
        private int chargePercentage = 100;
        private int lineThickness = 4;
        private int plusPinThickness = 10;

        public BatteryGauge() : base()
        {
            SetStyle(ControlStyles.Selectable, false);

            SetStyle(ControlStyles.ResizeRedraw | 
                ControlStyles.OptimizedDoubleBuffer, true);

            TabStop = false;
        }


        [
        Category("Appearance"),
        Description("The carge of the battery in percent."),
        DefaultValue((int)100),
        Bindable(BindableSupport.Yes, BindingDirection.OneWay)
        ]
        public int ChargePercentage
        {
            get { return chargePercentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("ChargePercentage must be between 0 and 100");

                chargePercentage = value;
                this.Invalidate();
            }
        }

        [
        Category("Appearance"),
        Description("The thickness of the border line."),
        DefaultValue((int)4)
        ]
        public int LineThickness
        {
            get { return lineThickness; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("LineThickness must be greater than 0");
                lineThickness = value;
                this.Invalidate();
            }
        }

        [
        Category("Appearance"),
        Description("The thickness of the border line."),
        DefaultValue((int)10)
        ]
        public int PlusPinThickness
        {
            get { return plusPinThickness; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("PlusPinTickness must be greater than 0");
                plusPinThickness = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush foreBrush = new SolidBrush(ForeColor);
            Pen forePen = new Pen(foreBrush, lineThickness);

            // Render bar and text
            string text = chargePercentage.ToString() + " %";
            StringFormat centerFormat = new StringFormat(){Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center};
            PointF center = new PointF((this.Width - plusPinThickness)/ 2f, this.Height / 2f);
            
            GraphicsPath shadowPath = new GraphicsPath();
            shadowPath.AddString(text, Font.FontFamily, (int)Font.Style, Font.Size, center, centerFormat);

            RectangleF bar = new RectangleF(lineThickness, lineThickness,
                (this.Size.Width - lineThickness * 2 - plusPinThickness) * (chargePercentage / 100f),
                (this.Size.Height - lineThickness * 2));

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.ResetClip();
            e.Graphics.SetClip(shadowPath, CombineMode.Exclude);
            e.Graphics.FillRectangle(foreBrush, bar);            

            e.Graphics.ResetClip();
            e.Graphics.SetClip(bar, CombineMode.Exclude);
            e.Graphics.FillPath(foreBrush, shadowPath);            
            e.Graphics.ResetClip();

            // Render battery
            e.Graphics.DrawRectangle(forePen, 0, 0, Width - plusPinThickness, Height);
            e.Graphics.FillRectangle(foreBrush, Width - plusPinThickness, Height / 4, plusPinThickness, Height / 2);

            e.Graphics.Flush();
        }

    }
}
