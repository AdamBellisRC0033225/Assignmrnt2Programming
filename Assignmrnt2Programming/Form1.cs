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
                label8.Hide();
                textBox8.Hide();
                label9.Hide();
                textBox9.Hide();
                label10.Hide();
                textBox10.Hide();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                label9.Hide();
                textBox9.Hide();
                label10.Hide();
                textBox10.Hide();

                label8.Show();
                textBox8.Show();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
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
        }
    }
}
