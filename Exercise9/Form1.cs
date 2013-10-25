using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNP;

namespace Exercise9
{
    public partial class Form1 : Form
    {
        MathLib math = new MathLib();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum=math.sumDouble(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text ));
            label2.Text = ""+sum;
            string s = textBox1.Text + button1.Text + textBox2.Text + label1.Text + label2.Text;
            listBox1.Items.Add(s);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = math.subDouble(Double.Parse(textBox4.Text), Double.Parse(textBox3.Text));
            label3.Text = "" + sum;
            string s = textBox4.Text + button2.Text + textBox3.Text + label4.Text + label3.Text;
            listBox1.Items.Add(s);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = math.multiplyDouble(Double.Parse(textBox6.Text), Double.Parse(textBox5.Text));
            label5.Text = "" + sum;
            string s = textBox6.Text + button3.Text + textBox5.Text + label6.Text + label5.Text;
            listBox1.Items.Add(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sum = math.divideDouble(Double.Parse(textBox8.Text), Double.Parse(textBox7.Text));
            label7.Text = "" + sum;
            string s = textBox8.Text + button4.Text + textBox7.Text + label8.Text + label7.Text;
            listBox1.Items.Add(s);
        }

       

       
    }
}
