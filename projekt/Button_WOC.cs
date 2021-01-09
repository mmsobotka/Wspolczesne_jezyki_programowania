using System;
using System.Drawing;
using System.Windows.Forms;

namespace ePOSOne.btnProduct
{
    /// <summary>
    /// The Button_WOC class allows create round buttons.This is an implemented ready-made class
    /// </summary>
    public class Button_WOC : Button
    {
        private Color _borderColor = Color.Silver;
        private Color _onHoverBorderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;

        private bool _isHovering;
        private int _borderThickness = 6;
        private int _borderThicknessByTwo = 3;

        /// <summary>
        /// Button_WOC isHovering
        /// </summary>
        public Button_WOC()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
        }

        /// <summary>
        /// Button_WOC OnPaint funtion
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);

            //Border
            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

            //Inner part. Button itself
            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
                Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
                Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
                Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

            //Button Text
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }

        /// <summary>
        /// Button_WOC BorderColor
        /// </summary>
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Button_WOC OnHoverBorderColor
        /// </summary>
        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Button_WOC ButtonColor
        /// </summary>
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Button_WOC OnHoverButtonColor
        /// </summary>
        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Button_WOC TextColor
        /// </summary>
        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Button_WOC OnHoverTextColor
        /// </summary>
        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
    }
}