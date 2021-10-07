using System;
using System.Windows.Forms;
using GradMetod.Function;

namespace GradMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked== true)
            {
                Metods metods = new Metods();
              label1.Text =   Convert.ToString(metods.Solve(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox4.Text)));
            }

            if (radioButton2.Checked == true)
            {
                Metods metods = new Metods();
                label1.Text = Convert.ToString(metods.Solve(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox4.Text))[0]);
                label6.Text = Convert.ToString(metods.Solve(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox4.Text))[1]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Visible = false;
                textBox2.Text = null;
                label3.Text = null;
            }
            else
            {
                textBox2.Visible = true;
                label3.Text = "y";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                textBox2.Visible = true;
                label3.Text = "y";
            }
            else
            {
                textBox2.Visible = false;
                label3.Text = null;
                textBox2.Text = null;
            }
        }
    }
}
