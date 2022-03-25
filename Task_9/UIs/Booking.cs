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
    
    public partial class Booking : UserControl
    {
        List<RoomLocator> busy = new List<RoomLocator>();
        List<int> roomBusy = new List<int>();
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = ""; textBox3.Text = "962";
            label4.Visible = false;
            textBox4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool itBusy = false;
            foreach (int t in roomBusy)
                if (t == Convert.ToInt32(textBox5.Text))
                    itBusy = true;
            if (checkInput() && !itBusy)
            {
                RoomLocator addNew;
                DateTime x = new DateTime(Convert.ToInt16(comboBox1.Text), Convert.ToInt16(comboBox2.Text), Convert.ToInt16(comboBox3.Text),0,0,0);
                if (radioButtonGuset.Checked)
                {
                    string pay="";
                    if (radioButton1.Checked)
                        pay = "cash";
                    else if (radioButton2.Checked)
                        pay = "creditcard";
                    addNew = new RoomLocator(textBox1.Text, textBox2.Text, Convert.ToInt64(textBox3.Text), pay, Convert.ToInt32(textBox5.Text), true, x);
                }
                else
                    addNew = new RoomLocator(textBox1.Text, textBox2.Text, Convert.ToInt64(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), true, x);
                busy.Add(addNew);
            }
            else
                MessageBox.Show("Enter the real information");
            Clear();
        }

        bool checkInput()
        {
            if (textBox1.Text != "" && checkEmail(textBox2.Text) && checkPhoneNumber(textBox3.Text) && comboBox1.Text != "" && comboBox2.Text != ""
                && comboBox3.Text != "" && (textBox4.Text != "" || radioButton1.Checked || radioButton2.Checked) &&
                (radioButtonGuset.Checked || radioButtonEmp.Checked) && textBox5.Text!="")
            {
                return true;
            }
            return false;
        }
        bool checkEmail(string str)
        {
            int a1 = 0, a2 = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '@')
                    a1 = i;
                else if (str[i] == '.')
                    a2 = i;
            }
            if (a1 != 0 && a2 != 0 && a1 < a2)
                return true;
            else
                return false;
        }
        bool checkPhoneNumber(string str)
        {
            if (str.Length == 12)
                return true;
            else
                return false;
        }

        private void radioButtonGuset_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Payment";
            label4.Visible = true;
            textBox4.Visible = false; ;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            groupBox1.Visible = true;
        }

        private void radioButtonEmp_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Salary";
            label4.Visible = true;
            textBox4.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            groupBox1.Visible = false;
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = ""; textBox3.Text = "962"; textBox4.Text = ""; textBox5.Text = "";
            comboBox1.Text = ""; comboBox2.Text = ""; comboBox3.Text = "";
            radioButtonEmp.Checked = false; radioButtonGuset.Checked = false;
            label4.Visible = false;
            textBox4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            groupBox1.Visible = false;
        }
    }
}
