using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Mohammad Al-Qaisy

namespace Task_9
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            booking1.Visible = false;
            dashboard1.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel4.Visible = false;
            booking1.Visible = true;
            label1.Text = "Booking";
            dashboard1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dashboard";
            booking1.Visible = false;
            dashboard1.Visible = true;
            panel4.Visible = false;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
