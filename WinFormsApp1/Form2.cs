using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = (Form1.myTimer.Interval / 1000).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.myTimer.Interval = int.Parse(textBox1.Text) * 1000;
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
