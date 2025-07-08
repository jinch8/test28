using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class CheckEx : UserControl
    {
        private bool _checked = false;

        // --- 自定义属性 ---

        [Category("Appearance_Custom")]
        [Description("当复选框为“选中”状态时显示的图片")]
        public Image ImageChecked { get; set; }

        [Category("Appearance_Custom")]
        [Description("当复选框为“未选中”状态时显示的图片")]
        public Image ImageUnchecked { get; set; }

        [Category("Appearance_Custom")]
        [Description("核心状态：是否被选中")]
        public bool Checked
        {
            get { return _checked; }
            set
            {
                if (_checked != value)
                {
                    _checked = value;
                    UpdateImage();
                    // 触发状态改变事件
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        // --- 自定义事件 ---

        [Category("Action_Custom")]
        [Description("当 Checked 属性发生改变时触发")]
        public event EventHandler CheckedChanged;

        public CheckEx()
        {
            InitializeComponent();

            UpdateImage();

            // 为内部的 PictureBox 和 Label 都关联上点击事件
            this.pbx.MouseDown += Control_Click;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            // 点击时，切换 Checked 状态
            this.Checked = !this.Checked;
        }
        private void UpdateImage()
        {
            if (this.Checked)
            {
                pbx.Image = ImageChecked;
            }
            else
            {
                pbx.Image = ImageUnchecked;
            }
        }
    }
}
