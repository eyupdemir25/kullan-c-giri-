using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int hatalı = 0;
            if (textBox1.Text!="admin")
            {
                hatalı = 1;
                label4.Visible = true;

            }
            if (textBox2.Text!="123")
            {
                hatalı = 1;
            }
            if (hatalı==0)
            {
                MessageBox.Show("başarılı");
                label4.Visible = false;
            }
            else
            {
                MessageBox.Show("hatalı");
            }


            /* if (textBox1.Text=="admin")
            {
                if (textBox2.Text=="123")
                {
                    MessageBox.Show("başarılı ");
                }
                else
                {
                    MessageBox.Show("parola yanlış");
                }
            }
            else
            {
                MessageBox.Show("kullanıcı bulunamadı");
            }
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
