using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        IconButton _curBtn;
        Panel _leftBorderBtn;
        Form _curChildFrm;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        struct RgbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        public Form1()
        {
            InitializeComponent();
            _leftBorderBtn = new Panel();
            _leftBorderBtn.Size = new Size(7, 60);
            pnMenu.Controls.Add(_leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object sender, Color clr)
        {
            if (sender != null)
            {
                DisableButton();
                _curBtn = (IconButton)sender;
                _curBtn.BackColor = Color.FromArgb(37, 36, 81);
                _curBtn.ForeColor = clr;
                _curBtn.TextAlign = ContentAlignment.MiddleCenter;
                _curBtn.IconColor = clr;
                _curBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _curBtn.ImageAlign = ContentAlignment.MiddleRight;

                _leftBorderBtn.BackColor = clr;
                _leftBorderBtn.Location = new Point(0, _curBtn.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();

                iconCurChildFrm.IconChar = _curBtn.IconChar;
                iconCurChildFrm.IconColor = clr;
            }
        }

        private void DisableButton()
        {
            if (_curBtn != null)
            {
                _curBtn.BackColor = Color.FromArgb(31, 30, 68);
                _curBtn.ForeColor = Color.Gainsboro;
                _curBtn.TextAlign = ContentAlignment.MiddleLeft;
                _curBtn.IconColor = Color.Gainsboro;
                _curBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _curBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color1);
            OpenChildFrm(new Form());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color2);
            OpenChildFrm(new Form());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color3);
            OpenChildFrm(new Form());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color4);
            OpenChildFrm(new Form());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color5);
            OpenChildFrm(new Form());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color6);
            OpenChildFrm(new Form());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _curChildFrm?.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            _leftBorderBtn.Visible = false;

            iconCurChildFrm.IconChar = IconChar.Home;
            iconCurChildFrm.IconColor = Color.MediumPurple;

            lblCurChildFrm.Text = "Home";
        }

        private void OpenChildFrm(Form childFrm)
        {
            if (_curChildFrm != null)
            {
                _curChildFrm.Close();
            }

            _curChildFrm = childFrm;
            childFrm.TopLevel = false;
            childFrm.FormBorderStyle = FormBorderStyle.None;
            childFrm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(childFrm);
            pnDesktop.Tag = childFrm;
            childFrm.BringToFront();
            childFrm.Show();
            lblCurChildFrm.Text = childFrm.Text;
        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
