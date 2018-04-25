using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomButtons
{
    public sealed class DefaultButton : Control
    {
        private readonly SolidBrush _borderBrush;
        private readonly SolidBrush _textBrush;
        private Rectangle _borderRectangle;
        private readonly StringFormat _stringFormat = new StringFormat();
        private const float BorderThickness = 2;
        private readonly Color _primaryColor = ColorTranslator.FromHtml("#181818");
        private readonly Color _secondaryColor = ColorTranslator.FromHtml("#222");
        private readonly Color _textColor = ColorTranslator.FromHtml("#FFF");

        public override Cursor Cursor => Cursors.Hand;
        
        public DefaultButton()
        {
            base.BackColor = _primaryColor;

            _borderBrush = new SolidBrush(_primaryColor);
            _textBrush = new SolidBrush(_textColor);

            _stringFormat.Alignment = StringAlignment.Center;
            _stringFormat.LineAlignment = StringAlignment.Center;

            this.Paint += FlatButton_Paint;
        }

        private void FlatButton_Paint(object sneder, PaintEventArgs e)
        {
            _borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawString(Text, Font, _textBrush, _borderRectangle, _stringFormat);
            e.Graphics.DrawRectangle(new Pen(_borderBrush, BorderThickness), _borderRectangle);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = _primaryColor;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = _secondaryColor;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.BackColor = _secondaryColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.BackColor = _primaryColor;
        }
    }
}
