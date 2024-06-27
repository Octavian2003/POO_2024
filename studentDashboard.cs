using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class studentDashboard : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0,0);
        
        public studentDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private  void AddControls(Form f)
        {
                ControlsPanel.Controls.Clear();
                f.Dock = System.Windows.Forms.DockStyle.Fill;
                f.TopLevel = false;
                ControlsPanel.Controls.Add(f);
                f.Show();
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void studentDashboard_Load(object sender, EventArgs e)
        {
        }

        private void studentDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void studentDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void studentDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            AddControls(new Profile());
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
