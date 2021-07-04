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
    public partial class ParaYat : Form
    {
        public static int hesap_no { get; set; }
        
        public ParaYat()
        {
            InitializeComponent();
        }



        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            ParaYat  formkapa = new ParaYat ();
            formkapa.Close();
            Menu1 form = new Menu1();
            form.Show();
            this.Hide();
        }
       
        
        
        private void ParaYat_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
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
                
                label1.Text = read["Para"].ToString();
            }
            baglantı.Close();
            
        }






        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
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
            label13.Text = DateTime.Now.ToString();
        }





        

        private void button19_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" )
            {
                MessageBox.Show("LÜtfen çekilecek para miktarını giriniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int deger = int.Parse(textBox1.Text);
                if (deger < 0)
                {
                    MessageBox.Show("Lütfen bakiyenizi kontrol ediniz");
                }
                else
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("SELECT Para FROM GirişKullanıcı where  HesapNo=@hesap_no", baglantı);
                    komut.Parameters.AddWithValue("@hesap_no", hesap_no);
                    SqlDataReader read1 = komut.ExecuteReader();

                    MessageBox.Show("             İşlem başarılı bir şekilde gerçekleştirilmiştir.            ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    if (read1.Read())
                    {

                        int para = read1.GetInt32(0);
                        para = int.Parse(textBox1.Text) + para;
                        read1.Close();
                        SqlCommand komut2 = new SqlCommand("UPDATE GirişKullanıcı SET Para=@para WHERE HesapNo=@hesap_no", baglantı);
                        komut2.Parameters.AddWithValue("@Para", para);
                        komut2.Parameters.AddWithValue("@hesap_no", hesap_no);
                        komut2.ExecuteNonQuery();
                        textBox1.Clear();

                    }
                    baglantı.Close();
                }
            }

            



            
        
            
        }

       
        
        
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            
            if (textBox2.Text == textBox4.Text)
            {
                MessageBox.Show("           Hatalı giriş yaptınız. Lütfen tüm alanları doldurun.          ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into BaskaHsbParYatr (Hesapno,TcNO,TelNO,YtrPara)values (@Hesapno,@TcNo,@TelNO,@YtrPara)", baglantı);
                komut.Parameters.AddWithValue("@Hesapno", textBox4.Text);
                komut.Parameters.AddWithValue("@TcNO", textBox2.Text);
                komut.Parameters.AddWithValue("@TelNO", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@YtrPara", textBox5.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                textBox5.Clear();
                textBox2.Clear();
                textBox4.Clear();
                maskedTextBox1.Clear();
                MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            

            
      
            
            
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }









        public object ytrpara { get; set; }
    }
}
