using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question_and_answer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome " + textBox1.Text + "question: 17 - 2 x 8 = 1, Yes or No?"
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("correct answer + textBox1.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("incorrect answer + textBox1.");
        }
    }
}
