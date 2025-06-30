using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class UIGroupBox : GroupBox
    {
        private Font _gGroupBoxFont = null;
        public Font TitleFont
        {
            get => _gGroupBoxFont;

            set => _gGroupBoxFont = value;
        }

        private Color _titleColor;
        public Color TitleColor
        {
            get => _titleColor;

            set => _titleColor = value;
        }

        private Color _backColor;
        new public Color BackColor
        {
            get => _backColor;

            set => _backColor = value;
        }

        private Brush _titleBrush;

        public UIGroupBox() : base()
        {
            this._gGroupBoxFont = new Font("微软雅黑", 10.0f, FontStyle.Bold);
            this._titleColor = Color.FromArgb(64, 64, 64);
            this._titleBrush = new SolidBrush(_titleColor);
            this._backColor = SystemColors.ButtonHighlight;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(_backColor);
            e.Graphics.DrawString(this.Text, _gGroupBoxFont, _titleBrush, 10, 4);

            e.Graphics.DrawLine(Pens.Gray, 0, 0, this.Width - 1, 0);
            e.Graphics.DrawLine(Pens.Gray, this.Width - 1, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawLine(Pens.Gray, this.Width - 1, this.Height - 1, 0, this.Height - 1);
            e.Graphics.DrawLine(Pens.Gray, 0, this.Height - 1, 0, 0);
        }
    }
}
