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
    public partial class GirişEk : Form
    {
        public GirişEk()
        {
            InitializeComponent();
        }
        
        
        
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");

        //----------------------------------------------------------------------------------------------------------//




        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==textBox4.Text)
            {
                MessageBox.Show("           Hatalı giriş yaptınız. Lütfen tüm alanları doldurun.          ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Hesapİş.hesap_no = int.Parse(textBox4.Text);
                ParaYat.hesap_no = int.Parse(textBox4.Text);
                ParaCek.hesap_no = int.Parse(textBox4.Text);
                Ödemeler.hesap_no = int.Parse(textBox4.Text);
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select * from GirişKullanıcı where HesapNo ='" + textBox4.Text + "'and Şifre ='" + textBox1.Text + "'", baglantı);


                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Menu1 frm3 = new Menu1();
                    frm3.Show();
                    GirişEk formkapa = new GirişEk();
                    formkapa.Close();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Hesap No veya Şifre kısmını hatalı girdiniz...");

                }
                baglantı.Close();
                textBox1.Clear();
                textBox4.Clear();
            }
            
            
        }

        public static String HesapNo;
        public static String Şifre;
        public static String KAd;
        public static String KSoyad;
        public static String KTc;
        public static String Telefon;
        public static String Para;
        private void verial()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select Hesap No,Şifre,KAd,KSoyad,KTc,Telefon,Para from GirişKullanıcı where Hesap No='" + textBox4.Text + "'and Şifre ='" + textBox1.Text + "'", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                HesapNo = dr[0].ToString();
                Şifre = dr[1].ToString();
                KAd = dr[2].ToString();
                KSoyad = dr[3].ToString();
                KTc = dr[4].ToString();
                Telefon = dr[5].ToString();
                Para = dr[6].ToString();



            }
            baglantı.Close();
        }






        //----------------------------------------------------------------------------------------------------------//
        
        



        
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==textBox3.Text)
            {
                MessageBox.Show("           Hatalı giriş yaptınız. Lütfen tüm alanları doldurun.          ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                getir();

                baglantı.Open();
                SqlCommand komut = new SqlCommand("select * from GirişEkranı where YönŞubeNo='" + textBox2.Text + "'and YönŞifre ='" + textBox3.Text + "'", baglantı);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    YönGrş frm3 = new YönGrş();
                    frm3.Show();

                    GirişEk formkapa = new GirişEk();
                    formkapa.Close();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şube No veya Şifre kısmını hatalı girdiniz...");

                }
                baglantı.Close();
            }
            

            
        }

        public static String YönŞubeNo;
        public static String  YönŞifre;
        public static String     Ad;
        public static String   Soyad;
        public static String    Tc;
        private void getir ()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select YönŞubeNo,YönŞifre,Ad,Soyad,Tc from GirişEkranı where YönŞubeNo='" + textBox2.Text + "'and YönŞifre ='" + textBox3.Text + "'", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                YönŞubeNo = dr[0].ToString();
                YönŞifre = dr[1].ToString();
                Ad = dr[2].ToString();
                Soyad = dr[3].ToString();
                Tc = dr[4].ToString();


            }
            baglantı.Close();
        }




        //-----------------------------------------------------------------------------------------------------------//




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

        private void button6_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void GirişEk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTMOtomasyonDataSet.TabYonGrs' table. You can move, or remove it, as needed.
           
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

      


       
    }
}
