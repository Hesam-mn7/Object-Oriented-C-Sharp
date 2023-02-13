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
    public partial class Form5 : Form
    {
        User user;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.username = textBox1.Text;
            user.email = textBox2.Text;
            user.password = textBox3.Text;
            user.repeatpassword = textBox4.Text;
            user.favouriteteam = comboBox1.Text;
            user.city = comboBox2.Text;
            user.more = textBox5.Text;

            if (user.username == "" || user.password == "" || user.email == "" || user.repeatpassword == "")
            {
                MessageBox.Show("اطلاعات ستاره دار را کامل وارد کنید");
            }
            else if (user.password != user.repeatpassword)
            {
                MessageBox.Show("رمز عبور و تکرار آن باید مشابه هم باشند");

            }
            else
            {
                MessageBox.Show(" عضویت با موفقیت انجام شد " + user.username );

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
