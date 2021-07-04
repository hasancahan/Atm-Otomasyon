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
    public partial class Hesapİş : Form
    {
        public static int hesap_no { get; set; }
        
        public Hesapİş()
        {
            InitializeComponent();
        }
       SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");
        
        
        private void Hesapİş_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atm_OtomasyonDataSet.GirişKullanıcı' table. You can move, or remove it, as needed.
            this.girişKullanıcıTableAdapter.Fill(this.atm_OtomasyonDataSet.GirişKullanıcı);
            // TODO: This line of code loads data into the 'atm_OtomasyonDataSet.GirişEkranı' table. You can move, or remove it, as needed.
            this.girişEkranıTableAdapter.Fill(this.atm_OtomasyonDataSet.GirişEkranı);
            
            timer1.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GeriBut_Click(object sender, EventArgs e)
        {
            Hesapİş  formkapa = new Hesapİş();
            formkapa.Close();
            Menu1 form = new Menu1();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para,KAd,KSoyad FROM GirişKullanıcı where HesapNo =@hesap_no", baglantı);
            komut.Parameters.AddWithValue("@hesap_no", hesap_no);
            SqlDataReader read =  komut.ExecuteReader();
            

            if (read.Read()) 
            {
                label8.Text = read["KAd"].ToString();
                label10.Text = read["KSoyad"].ToString();
                label11.Text = read["Para"].ToString();
            }
            baglantı.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            panel3.Show();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Adres FROM GirişKullanıcı where HesapNo =@hesap_no", baglantı);
            komut.Parameters.AddWithValue("@hesap_no", hesap_no);
            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {
                label12.Text = read["Adres"].ToString();
            }
            baglantı.Close();

        }

        

        

       

       
       
    }

       
}

