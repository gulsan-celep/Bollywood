using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bollywood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] koltuk = new Button[60];
        string ad = "", soyad = "";
        LinkedList ll = new LinkedList(60);
        string[] Musteri = new string[61];
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 25 , y=50;
            for (int i = 0; i < 60; i++)
            {
                koltuk[i] = new Button();
                koltuk[i].BackColor = System.Drawing.Color.LightGreen;
                koltuk[i].Text = (i+1).ToString();
                this.Controls.Add(koltuk[i]);
                if(i%8==0)
                {
                    x = 25;
                    y += 30; 
                }
                koltuk[i].Top = y;
                koltuk[i].Left = x;
                koltuk[i].Width = 50;
                koltuk[i].Height = 20;
                x += 85;

                comboBox1.Items.Add(i + 1);
                comboBox2.Items.Add(i + 1);
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        { 
            ad = textBox1.Text;
            soyad = textBox2.Text;
            int sayi = Convert.ToInt32(comboBox1.Text);
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            int yazi = Convert.ToInt32(comboBox1.Text)-1;
                
                    koltuk[yazi].BackColor = System.Drawing.Color.Red;
                    ll.InsertPos(yazi, yazi);
                
            
            MessageBox.Show("Sayın " + ad + " " + soyad + " " + (yazi+1) + "biletiniz alınmıştır");

            Musteri[ll.GetElement(yazi).Data] = ad + " " + soyad;
            
                       
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string temp = "";
            for(int i=1;i<60;i++)
            {
                if(Musteri[i]!=null)
                {
                    temp += i.ToString() + ". " + Musteri[i] + "\n";
                }
                
            }
            MessageBox.Show(temp);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yazi = Convert.ToInt32(comboBox2.Text) - 1;
            if (ll.DeletePos(yazi)==false)
            {
                MessageBox.Show("Koltuk zaten boş..");
            }
            else
            {
                koltuk[yazi].BackColor = System.Drawing.Color.LightGreen;
                Musteri[yazi+1] = "";
            }
        }

       
    }
}
