using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_tickets
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the first name");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter the last name");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter the email");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
