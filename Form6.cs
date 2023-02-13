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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            switch (a)
            {
                case 7015:
                    this.Hide();
                    new Form7().Show();
                    break;

                case 3011:
                    this.Hide();
                    new Form8().Show();
                    break;

                case 2022:
                    this.Hide();
                    new Form9().Show();
                    break;

                case 4987:
                    this.Hide();
                    new Form10().Show();
                    break;

                default:
                    MessageBox.Show("همچین کد و مطلبی وجود ندارد");
                    break;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
