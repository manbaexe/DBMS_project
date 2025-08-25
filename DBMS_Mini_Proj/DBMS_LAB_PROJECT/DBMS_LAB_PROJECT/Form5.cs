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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Show();
            label2.Show();
            textBox1.Show();
            textBox2.Show();
            button3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Show();
            label4.Show();
            textBox3.Show();
            textBox4.Show();
            button4.Show();
        }
    }
}
