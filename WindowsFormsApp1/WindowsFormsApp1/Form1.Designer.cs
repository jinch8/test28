namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new Krypton.Navigator.KryptonPage();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonTrackBar1 = new Krypton.Toolkit.KryptonTrackBar();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonThemeListBox1 = new Krypton.Toolkit.KryptonThemeListBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.ControlKryptonFormFeatures = false;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonNavigator1.Owner = null;
            this.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(1367, 144);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1365, 104);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "0baf34ad7aab4f92bd64257fcb8c170d";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(1365, 104);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "41f52eb2d7734a2ea6acc5a8cac27953";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(445, 17);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(209, 67);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonTrackBar1
            // 
            this.kryptonTrackBar1.Location = new System.Drawing.Point(35, 39);
            this.kryptonTrackBar1.Name = "kryptonTrackBar1";
            this.kryptonTrackBar1.Size = new System.Drawing.Size(371, 27);
            this.kryptonTrackBar1.TabIndex = 2;
            this.kryptonTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kryptonTrackBar1.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large;
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.ColumnCount = 1;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 0);
            this.kryptonTableLayoutPanel1.Controls.Add(this.kryptonPanel2, 0, 1);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 3;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(1373, 681);
            this.kryptonTableLayoutPanel1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1367, 144);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonThemeListBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonTrackBar1);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 153);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1367, 505);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonThemeListBox1
            // 
            this.kryptonThemeListBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            this.kryptonThemeListBox1.Location = new System.Drawing.Point(829, 17);
            this.kryptonThemeListBox1.Name = "kryptonThemeListBox1";
            this.kryptonThemeListBox1.Size = new System.Drawing.Size(504, 474);
            this.kryptonThemeListBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 681);
            this.Controls.Add(this.kryptonTableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTrackBar kryptonTrackBar1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonThemeListBox kryptonThemeListBox1;
    }
}

