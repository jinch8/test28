using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class LargeCheckBox : System.Windows.Forms.CheckBox
    {
        // --- 自定义属性 ---

        [Category("Appearance_Custom")]
        [Description("复选框未选中时的背景色")]
        public Color UncheckedBackColor { get; set; } = Color.FromArgb(230, 230, 230);

        [Category("Appearance_Custom")]
        [Description("复选框未选中时的边框色")]
        public Color UncheckedBorderColor { get; set; } = Color.Gray;

        [Category("Appearance_Custom")]
        [Description("复选框选中时的背景色")]
        public Color CheckedBackColor { get; set; } = Color.FromArgb(0, 122, 204);

        [Category("Appearance_Custom")]
        [Description("复选框选中时的边框色")]
        public Color CheckedBorderColor { get; set; } = Color.FromArgb(0, 122, 204);

        [Category("Appearance_Custom")]
        [Description("对勾或中间状态符号的颜色")]
        public Color CheckMarkColor { get; set; } = Color.White;

        // 构造函数
        public LargeCheckBox()
        {
            // 设置为3态，这样可以同时处理 Checked 和 Indeterminate 状态
            this.ThreeState = false;
            // 设置双缓冲，防止绘制时闪烁
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e); // 重要：不要调用基类的 OnPaint 方法，否则会绘制标准的 CheckBox

            // 使用高质量的绘制模式
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. 清除背景
            // 使用父控件的背景色来填充，以实现透明效果
            using (var brush = new SolidBrush(this.Parent.BackColor))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // 2. 计算复选框的位置和大小
            // 大小通常基于控件的字体高度，这样它会随字体大小缩放
            int boxSize = (int)(this.Font.Height * 1.2);
            int boxY = (this.ClientSize.Height - boxSize) / 2;
            Rectangle boxRectangle = new Rectangle(0, boxY, boxSize, boxSize);

            // 3. 根据状态绘制复选框
            Color backColor = this.Enabled ? UncheckedBackColor : SystemColors.Control;
            Color borderColor = this.Enabled ? UncheckedBorderColor : SystemColors.ControlDark;

            if (this.Checked)
            {
                backColor = this.Enabled ? CheckedBackColor : SystemColors.ControlDark;
                borderColor = this.Enabled ? CheckedBorderColor : SystemColors.ControlDark;
            }

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, boxRectangle);
            }
            using (var pen = new Pen(borderColor, 2))
            {
                e.Graphics.DrawRectangle(pen, boxRectangle);
            }

            // 4. 根据状态绘制对勾或中间符号
            switch (this.CheckState)
            {
                case CheckState.Checked:
                // 绘制对勾 (✓)
                //using (var pen = new Pen(CheckMarkColor, 2))
                //{
                //    Point[] points = new Point[]
                //    {
                //new Point(boxRectangle.Left + boxRectangle.Width / 4, boxRectangle.Top + boxRectangle.Height / 2),
                //new Point(boxRectangle.Left + boxRectangle.Width / 2 - 1, boxRectangle.Top + boxRectangle.Height * 3 / 4),
                //new Point(boxRectangle.Left + boxRectangle.Width * 3 / 4 + 1, boxRectangle.Top + boxRectangle.Height / 4 + 1)
                //    };
                //    e.Graphics.DrawLines(pen, points);
                //}
                //break;
                case CheckState.Indeterminate:
                    // 绘制中间状态的方块 (■)
                    using (var brush = new SolidBrush(CheckMarkColor))
                    {
                        int inset = boxRectangle.Width / 4;
                        Rectangle indeterminateRect = new Rectangle(
                            boxRectangle.Left + inset,
                            boxRectangle.Top + inset,
                            boxRectangle.Width - (inset * 2),
                            boxRectangle.Height - (inset * 2)
                        );
                        e.Graphics.FillRectangle(brush, indeterminateRect);
                    }
                    break;
                // Unchecked 状态不需要画任何符号
                case CheckState.Unchecked:
                default:
                    break;
            }

            // 5. 绘制文本
            // 计算文本绘制区域
            Rectangle textRectangle = new Rectangle(
                boxRectangle.Right + 5, // 在复选框右边留出5像素间距
                0,
                this.ClientSize.Width - boxRectangle.Width - 5,
                this.ClientSize.Height
            );

            // 使用 TextRenderer 来绘制，效果通常比 Graphics.DrawString 好
            TextRenderer.DrawText(
                e.Graphics,
                this.Text,
                this.Font,
                textRectangle,
                this.Enabled ? this.ForeColor : SystemColors.GrayText,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );
        }
    }
}
