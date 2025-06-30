namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.rBtn = new System.Windows.Forms.Button();
            this.btnDBVBandLoad = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new WindowsFormsApp2.UIGroupBox();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRead.FlatAppearance.BorderSize = 2;
            this.btnRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRead.Location = new System.Drawing.Point(43, 48);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(328, 66);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // rBtn
            // 
            this.rBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rBtn.FlatAppearance.BorderSize = 2;
            this.rBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.rBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn.Location = new System.Drawing.Point(43, 135);
            this.rBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn.Name = "rBtn";
            this.rBtn.Size = new System.Drawing.Size(186, 53);
            this.rBtn.TabIndex = 9;
            this.rBtn.Text = "Read";
            this.rBtn.UseVisualStyleBackColor = true;
            // 
            // btnDBVBandLoad
            // 
            this.btnDBVBandLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBVBandLoad.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.btnDBVBandLoad.Location = new System.Drawing.Point(243, 141);
            this.btnDBVBandLoad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDBVBandLoad.Name = "btnDBVBandLoad";
            this.btnDBVBandLoad.Size = new System.Drawing.Size(180, 49);
            this.btnDBVBandLoad.TabIndex = 10;
            this.btnDBVBandLoad.Text = "Load";
            this.btnDBVBandLoad.UseVisualStyleBackColor = true;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnRead);
            this.uiGroupBox1.Controls.Add(this.btnDBVBandLoad);
            this.uiGroupBox1.Controls.Add(this.rBtn);
            this.uiGroupBox1.Location = new System.Drawing.Point(91, 12);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(639, 257);
            this.uiGroupBox1.TabIndex = 11;
            this.uiGroupBox1.TabStop = false;
            this.uiGroupBox1.Text = "uiGroupBox1";
            this.uiGroupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiGroupBox1.TitleFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button rBtn;
        private System.Windows.Forms.Button btnDBVBandLoad;
        private UIGroupBox uiGroupBox1;
    }
}