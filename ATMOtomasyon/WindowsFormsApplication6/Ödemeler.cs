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
    public partial class Ödemeler : Form
    {
        public static int hesap_no { get; set; }
        public Ödemeler()
        {
            InitializeComponent();
        }


        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");
        
        
        private void GeriBut_Click(object sender, EventArgs e)
        {
            Ödemeler  formkapa = new Ödemeler();
            formkapa.Close();
            Menu1 form = new Menu1();
            form.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            
        }

        private void Ödemeler_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label22.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para FROM GirişKullanıcı where HesapNo =@hesap_no", baglantı);
            komut.Parameters.AddWithValue("@hesap_no", hesap_no);
            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {

                label8.Text = read["Para"].ToString();
            }
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Show();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para FROM GirişKullanıcı where HesapNo =@hesap_no", baglantı);
            komut.Parameters.AddWithValue("@hesap_no", hesap_no);
            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {

                label15.Text = read["Para"].ToString();
            }
            baglantı.Close();
        }


        //-------------------------------------------RANDOM FATURA----------------------------------------------//

        private void button11_Click(object sender, EventArgs e)
        {
            string[] Sayılar = { "00", "55", "70", "00", "25", "40", "100", "00", "50" };
            Random rastgelesayi = new Random();  // Rastgele sayı üretmek için
            int no = rastgelesayi.Next(0, Sayılar.Length); //Dizinin kaçıncı elemanını yazdıracağımızı belirlemek için
            label4.Text = (Sayılar[no]);
            
            if (label4.Text=="00")
            {
                MessageBox.Show("             Adrese kayıtlı borç bulunmamaktadır...            ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] Sayılar = { "15", "00", "00", "110", "25", "40", "00", "00", "50" };
            Random rastgelesayi = new Random();  
            int no = rastgelesayi.Next(0, Sayılar.Length); 
            label5.Text = (Sayılar[no]);
            
            if (label5.Text == "00")
            {
                MessageBox.Show("             Adrese kayıtlı borç bulunmamaktadır...            ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] Sayılar = { "15", "55", "00", "110", "60", "00", "100", "00", "95" };
            Random rastgelesayi = new Random(); 
            int no = rastgelesayi.Next(0, Sayılar.Length); 
            label6.Text = (Sayılar[no]);
            if (label6.Text == "00")
            {
                MessageBox.Show("             Adrese kayıtlı borç bulunmamaktadır...            ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            button13.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
             
            
            
            
                string[] Sayılar = { "50", "00", "70", "20", "00", "00", "35", "40", "00" };
                Random rastgelesayi = new Random();
                int no = rastgelesayi.Next(0, Sayılar.Length);
                label20.Text = (Sayılar[no]);
                if (label20.Text == "00")
                {
                    
                    MessageBox.Show("             Adrese kayıtlı borç bulunmamaktadır...            ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                button10.Visible = false;
            
            
                
            
            
            
            
            
        }   
        

        //--------------------------------------------SON---------------------------------------------//
        
        
        
        
        
        private void button16_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Telefon FROM GirişKullanıcı where HesapNo =@hesap_no", baglantı);
            komut.Parameters.AddWithValue("@hesap_no", hesap_no);
            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {

                maskedTextBox1.Text= read["Telefon"].ToString();
            }
            baglantı.Close();
        }

        
        
        
        //-------------------------------------------ÖDEMELER----------------------------------------------//
        private void button4_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(label8.Text);
            int deger1 = int.Parse(label4.Text);
            if (deger1>deger)
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
                    para = para - int.Parse(label4.Text);
                    read1.Close();
                    SqlCommand komut2 = new SqlCommand("UPDATE GirişKullanıcı SET Para=@para WHERE HesapNo=@hesap_no", baglantı);
                    komut2.Parameters.AddWithValue("@Para", para);
                    komut2.Parameters.AddWithValue("@hesap_no", hesap_no);
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglantı.Close();
                
            }
            

           
            
            
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            int deger2 = int.Parse(label5.Text);
            int deger = int.Parse(label8.Text);
            if (deger2>deger)
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
                    para = para - int.Parse(label5.Text);
                    read1.Close();
                    SqlCommand komut2 = new SqlCommand("UPDATE GirişKullanıcı SET Para=@para WHERE HesapNo=@hesap_no", baglantı);
                    komut2.Parameters.AddWithValue("@Para", para);
                    komut2.Parameters.AddWithValue("@hesap_no", hesap_no);
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglantı.Close();
            }
            
        }

        


        private void button6_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(label8.Text);
            int deger3 = int.Parse(label6.Text);
            if (deger3>deger)
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
                    para = para - int.Parse(label6.Text);
                    read1.Close();
                    SqlCommand komut2 = new SqlCommand("UPDATE GirişKullanıcı SET Para=@para WHERE HesapNo=@hesap_no", baglantı);
                    komut2.Parameters.AddWithValue("@Para", para);
                    komut2.Parameters.AddWithValue("@hesap_no", hesap_no);
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglantı.Close();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(label20.Text);
            int deger4 = int.Parse(label15.Text);
            if (deger > deger4)
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
                    para = para - int.Parse(label20.Text);
                    read1.Close();
                    SqlCommand komut2 = new SqlCommand("UPDATE GirişKullanıcı SET Para=@para WHERE HesapNo=@hesap_no", baglantı);
                    komut2.Parameters.AddWithValue("@Para", para);
                    komut2.Parameters.AddWithValue("@hesap_no", hesap_no);
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglantı.Close();


            }
              
        }

        

        
        
        //-----------------------------------------SON------------------------------------------------//
    }
}



