using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String email = textBox1.Text;
            String password = textBox2.Text;
            if (email == "hmousavioun@gmail.com" && password == "hesam123")
            {
                this.Hide();
                new Form4().Show();

            }
            else if (email == "alikarimi@gmail.com" && password == "ali")
            {
                this.Hide();
                new Form4().Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه وارد شده است ","خطا" , MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
