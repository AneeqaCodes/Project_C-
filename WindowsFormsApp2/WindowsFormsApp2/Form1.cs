using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        double subtotal; double a; double RegShip = 3; double t; decimal b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double expShip = 5;
                t = a + expShip;
                textBox3.Text = t.ToString();
                textBox4.Text = expShip.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your order", "");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)

        {

            if (numericUpDown1.Value >= 1 || numericUpDown1.Value <= 100)
            {

                subtotal = 49.95;
                a = a + subtotal;
                textBox5.Text = a.ToString();
                t = a + RegShip;
                textBox3.Text = t.ToString();
            }
            if (numericUpDown1.Value < 1)
            {
                textBox5.Text = "0";
                textBox4.Text = "0";
                textBox3.Text = "0";
            }
            if (numericUpDown1.Value < b)
            {

                int q = Convert.ToInt32(textBox5.Text);
                double c = q - subtotal;
                textBox5.Text = c.ToString();
            }
            b = numericUpDown1.Value;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                t = a + RegShip;
                textBox3.Text = t.ToString();
                textBox4.Text = RegShip.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 6;

        }
        private void numericUpDown1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e)
        {

        }

    }
}
