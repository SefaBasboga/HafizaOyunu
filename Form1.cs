using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random restgele = new Random();
        int süre = 5;


        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            button1.Enabled=false;


            int sayı1, sayı2, sayı3, sayı4, sayı5, sayı6, sayı7, sayı8, sayı9, sayı10, sayı11, sayı12;
            sayı1 = restgele.Next(0, 50);
            sayı2=restgele.Next(0, 50);
            sayı3=restgele.Next(0, 50);
            sayı4 = restgele.Next(0, 50);
            sayı5 = restgele.Next(0, 50);
            sayı6 = restgele.Next(0, 50);
            sayı7 = restgele.Next(0, 50);
            sayı8 = restgele.Next(0, 50);
            sayı9 = restgele.Next(0, 50);
            sayı10=restgele.Next(0, 50);
            sayı11=restgele.Next(0, 50);
            sayı12=restgele.Next(0, 50);

            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();
            label5.Text = sayı5.ToString();
            label6.Text = sayı6.ToString();
            label7.Text = sayı7.ToString();
            label8.Text = sayı8.ToString();
            label9.Text = sayı9.ToString();
            label10.Text = sayı10.ToString();
            label11.Text = sayı11.ToString();
            label12.Text = sayı12.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if(label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (label5.Text == textBox5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (label6.Text == textBox6.Text)
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }

            if (label7.Text == textBox7.Text)
            {
                textBox7.BackColor = Color.Green;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }

            if (label8.Text == textBox8.Text)
            {
                textBox8.BackColor = Color.Green;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }

            if (label9.Text == textBox9.Text)
            {
                textBox9.BackColor = Color.Green;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }
            if (label10.Text == textBox10.Text)
            {
                textBox10.BackColor = Color.Green;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }
            if (label11.Text == textBox11.Text)
            {
                textBox11.BackColor = Color.Green;
            }
            else
            {
                textBox11.BackColor = Color.Red;
            }
            if (label12.Text == textBox12.Text)
            {
                textBox12.BackColor = Color.Green;
            }
            else
            {
                textBox12.BackColor = Color.Red;
            }

            if (label1.Text==textBox1.Text && label2.Text==textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text && label11.Text == textBox11.Text && label12.Text == textBox12.Text)
            {
                MessageBox.Show("Tebrikler Hafızanız Kuvvetli");
            }
            else
            {
                MessageBox.Show("Üzgünüz Oyunu Kaybettiniz");
            }

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label13.Text = süre.ToString();
            if (süre == 0)
            {
                groupBox1.Visible = false;
                timer1.Stop();
                süre = 5;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            timer1.Start();
            button2.Enabled = false;

        }
    }
}
