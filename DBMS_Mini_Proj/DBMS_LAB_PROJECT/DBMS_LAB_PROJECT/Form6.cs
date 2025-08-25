using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_LAB_PROJECT
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label5.Show();
            label6.Show();
            textBox1.Show();
            comboBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            button1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Show();
            textBox1.Show();
            button4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Show();
            button7.Show();
            button8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Show();
            textBox5.Show();
            label7.Show();
            textBox6.Show();
            button9.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button9.Show();
            label8.Show();
            textBox5.Show();
            textBox6.Show();
            label9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label10.Show();
            label11.Show();
            button9.Show();
            textBox6.Show();
            textBox5.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Show();
            button11.Show();
            label12.Show();
        }
    }
}
