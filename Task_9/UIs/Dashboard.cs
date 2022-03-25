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

namespace Task_9.UIs
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            view();
        }

        void view()
        {
            int x = 0, y = 0;
            for (int i = 1; i < 15; i++)
            {
                Panel p = new Panel();
                p.Location = new Point(50+x, 50+y);
                p.Size = new Size(120, 120);
                p.BackColor = Color.Red;
                Label l1 = new Label();
                l1.Text = "Name";
                l1.Location = new Point(60 + x, 60 + y);
                Label l2 = new Label();
                l2.Text = "Phone";
                l2.Location = new Point(60 + x, 85 + y);
                Label l3 = new Label();
                l3.Text = "Email";
                l3.Location = new Point(60 + x, 110 + y);
                Label l4 = new Label();
                l4.Text = "Date";
                l4.Location = new Point(60 + x, 135 + y);
                Button b = new Button();
                b.Size = new Size(120, 30);
                b.Text = "Cancel";
                b.BackColor = Color.Red;
                b.Location = new Point(50 + x, 170 + y);
                this.Controls.Add(b);
                this.Controls.Add(l1);
                this.Controls.Add(l2);
                this.Controls.Add(l3);
                this.Controls.Add(l4);
                this.Controls.Add(p);
                x += 130;
                if (i % 6 == 0)
                {
                    x = 0;
                    y += 160;
                }
            }
            
        }
    }
}
