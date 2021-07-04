using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class ParaCek : Form
    {
        public static int hesap_no { get; set; }
        public ParaCek()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");

        private void ParaCek_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞMİŞTİR","İşlem Bilgisi",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaCek  formkapa = new ParaCek ();
            formkapa.Close();
            Menu1  form = new Menu1 ();
            form.Show();
            this.Hide();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "10";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "20";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "50";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "100";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "200";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para FROM GirişKullanıcı where HesapNo =@hesap_no", baglantı);
            komut.Parameters.AddWithValue("@hesap_no", hesap_no);
            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {

                label4.Text = read["Para"].ToString();
            }
            baglantı.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text =="")
            {
                MessageBox.Show("LÜtfen çekilecek para miktarını giriniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int deger2 = int.Parse(label4.Text);
                int deger1 = int.Parse(textBox1.Text);
                if (deger1 > deger2)
                {
                    MessageBox.Show("             Bakiye yetersiz...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("SELECT Para FROM GirişKullanıcı where  HesapNo=@hesap_no", baglantı);
                    komut.Parameters.AddWithValue("@hesap_no", hesap_no);
                    SqlDataReader read1 = komut.ExecuteReader();



                    if (read1.Read())
                    {

                        int para = read1.GetInt32(0);
                        para = para - int.Parse(textBox1.Text);
                        read1.Close();
                        SqlCommand komut2 = new SqlCommand("UPDATE GirişKullanıcı SET Para=@para WHERE HesapNo=@hesap_no", baglantı);
                        komut2.Parameters.AddWithValue("@Para", para);
                        komut2.Parameters.AddWithValue("@hesap_no", hesap_no);
                        komut2.ExecuteNonQuery();
                        MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();

                    }
                    baglantı.Close();
                }
            }
            
               
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }








        
        

        

        
            
        
    }
}
