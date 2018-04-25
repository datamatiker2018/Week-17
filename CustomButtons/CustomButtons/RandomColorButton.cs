using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomButtons
{
    public class RandomColorButton : Button
    {
        private static readonly Random Random = new Random();

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ChangeColor();
            MakeBigger();
        }

        public virtual void ChangeColor()
        {
            BackColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256));
        }

        public virtual void MakeBigger()
        {
            Width += 10;
        }
    }
}