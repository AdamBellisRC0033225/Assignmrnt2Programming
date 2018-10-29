using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmrnt2Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
                label5.Hide();
                textBox5.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox4.Text = "";
                textBox5.Text = "";

                label4.Hide();
                textBox4.Hide();
                label5.Hide();
                textBox5.Hide();

                label3.Show();
                textBox3.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox5.Text = "";

                label5.Hide();
                textBox5.Hide();

                label3.Show();
                textBox3.Show();
                label4.Show();
                textBox4.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label3.Show();
                textBox3.Show();
                label4.Show();
                textBox4.Show();
                label5.Show();
                textBox5.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

                label8.Hide();
                textBox8.Hide();
                label9.Hide();
                textBox9.Hide();
                label10.Hide();
                textBox10.Hide();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                textBox9.Text = "";
                textBox10.Text = "";

                label9.Hide();
                textBox9.Hide();
                label10.Hide();
                textBox10.Hide();

                label8.Show();
                textBox8.Show();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                textBox10.Text = "";

                label10.Hide();
                textBox10.Hide();

                label8.Show();
                textBox8.Show();
                label9.Show();
                textBox9.Show();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                label8.Show();
                textBox8.Show();
                label9.Show();
                textBox9.Show();
                label10.Show();
                textBox10.Show();
            }
        }

        private void Parallel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;
            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }
            R1 = Convert.ToDouble(textBox1.Text);
            R2 = Convert.ToDouble(textBox2.Text);
            double R = R1 + R2 + R3 + R4 + R5;
            Answer1.Text = "Answer = " + R;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5;
            double rrt = 0;
            try
            {
                r1 = Convert.ToDouble(textBox6.Text);
                rrt = rrt + 1.0 / r1;
            }
            catch
            {

            }
            try
            {
                r2 = Convert.ToDouble(textBox7.Text);
                rrt = rrt + 1.0 / r2;
            }
            catch
            {

            }
            try
            {
                r3 = Convert.ToDouble(textBox8.Text);
                rrt = rrt + 1.0 / r3;
            }
            catch
            {
                
            }
            try
            {
                r4 = Convert.ToDouble(textBox9.Text);
                rrt = rrt + 1.0 / r4;
            }
            catch
            {
               
            }
            try
            {
                r5 = Convert.ToDouble(textBox10.Text);
                rrt = rrt + 1.0 / r5;
            }
            catch
            {
               
            }
            double r = 1.0 / rrt;
            Answer.Text = "Answer = " + r;
        }
    }
}
