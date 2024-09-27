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
        int giriş_hakkı = 3;
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
                giriş_hakkı--;
            }

            if (giriş_hakkı>0)
            {
                if (hatalı == 0)
                {
                    label4.Visible = false;
                    MessageBox.Show(" giriş başarılı");

                }
                else
                {
                    MessageBox.Show(" şifre hatalı, giriş hakınız:"+giriş_hakkı);
                }
            }
            else
            {
                MessageBox.Show("giriş hakkınız bitti");
                button1.Enabled = false;

                textBox1.Text = "";
                textBox2.Text = "";

                textBox1.Enabled = false;
                textBox2.Enabled = false;
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
