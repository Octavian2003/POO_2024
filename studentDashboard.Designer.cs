namespace POO
{
    partial class studentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentDashboard));
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.ControlsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CoursesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(1767, 0);
            this.metroControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroControlBox1.MaximizeBox = true;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 5;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.ControlsPanel.Location = new System.Drawing.Point(139, 79);
            this.ControlsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(1761, 871);
            this.ControlsPanel.TabIndex = 6;
            this.ControlsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nume";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Exit
            // 
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(0, 838);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 108);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Log out";
            this.Exit.TextOffset = new System.Drawing.Point(0, 21);
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 94);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(151)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 108);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cont";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(33, 15);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(72, 66);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(151)))), ((int)(((byte)(98)))));
            this.CoursesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CoursesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CoursesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CoursesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CoursesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(151)))), ((int)(((byte)(98)))));
            this.CoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CoursesBtn.ForeColor = System.Drawing.Color.White;
            this.CoursesBtn.Location = new System.Drawing.Point(0, 263);
            this.CoursesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(151)))), ((int)(((byte)(98)))));
            this.CoursesBtn.Size = new System.Drawing.Size(139, 103);
            this.CoursesBtn.TabIndex = 11;
            this.CoursesBtn.Text = "Tablou de bord";
            this.CoursesBtn.TextOffset = new System.Drawing.Point(0, 21);
            this.CoursesBtn.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(151)))), ((int)(((byte)(98)))));
            this.CenterPanel.Controls.Add(this.CoursesBtn);
            this.CenterPanel.Controls.Add(this.panel3);
            this.CenterPanel.Controls.Add(this.pictureBox1);
            this.CenterPanel.Controls.Add(this.Exit);
            this.CenterPanel.Location = new System.Drawing.Point(0, 0);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(139, 950);
            this.CenterPanel.TabIndex = 4;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // studentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1724, 880);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.metroControlBox1);
            this.Controls.Add(this.ControlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "studentDashboard";
            this.Text = "studentDashboard";
            this.Load += new System.EventHandler(this.studentDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.studentDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.studentDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.studentDashboard_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private Guna.UI2.WinForms.Guna2Panel ControlsPanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button CoursesBtn;
        private System.Windows.Forms.Panel CenterPanel;
    }
}