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
    public partial class YönGrş : Form
    {
        public YönGrş()
        {
            InitializeComponent();
        }


        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");

        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            YönGrş  formkapa = new YönGrş ();
            formkapa.Close();
            GirişEk  form = new GirişEk ();
            form.Show();
            this.Hide();
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

        private void YönGrş_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para FROM AnaPara where  AtmNO=1", baglantı);
           
            SqlDataReader read = komut.ExecuteReader();

            
            if (read.Read())
            {

                label5.Text = read["Para"].ToString();
            }
            baglantı.Close();
       
            // TODO: This line of code loads data into the 'atm_OtomasyonDataSet.GirişKullanıcı' table. You can move, or remove it, as needed.
            this.girişKullanıcıTableAdapter.Fill(this.atm_OtomasyonDataSet.GirişKullanıcı);
            // TODO: This line of code loads data into the 'atm_OtomasyonDataSet.GirişEkranı' table. You can move, or remove it, as needed.
            this.girişEkranıTableAdapter.Fill(this.atm_OtomasyonDataSet.GirişEkranı);
            // TODO: This line of code loads data into the 'aTMOtomasyonDataSet.TabYonGrs' table. You can move, or remove it, as needed.
            
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label12.Text = GirişEk.YönŞubeNo.ToString();
            label13.Text = GirişEk.YönŞifre.ToString();
            label14.Text = GirişEk.Ad.ToString();
            label15.Text = GirişEk.Soyad.ToString();
            label17.Text = GirişEk.Tc.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            verilerigöster("Select * from GirişEkranı");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="" && textBox4.Text=="")
            {
                
                MessageBox.Show("           Ekleme İşlemi Hatalı, Lütfen tüm alanları doldurunuz.          ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.BackColor = Color.Green;
                textBox4.BackColor = Color.Green;
                textBox6.BackColor = Color.Green;
                textBox7.BackColor = Color.Green;
                textBox5.BackColor = Color.Green;
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into GirişEkranı (YönŞubeNo,YönŞifre,Ad,Soyad,Tc)values (@YönŞubeNo,@YönŞifre,@Ad,@Soyad,@Tc)", baglantı);
                komut.Parameters.AddWithValue("@YönŞubeNo", textBox2.Text);
                komut.Parameters.AddWithValue("@YönŞifre", textBox4.Text);
                komut.Parameters.AddWithValue("@Ad", textBox6.Text);
                komut.Parameters.AddWithValue("@Soyad", textBox7.Text);
                komut.Parameters.AddWithValue("@Tc", textBox5.Text);
                komut.ExecuteNonQuery();
                verilerigöster("Select * from GirişEkranı");
                baglantı.Close();

                textBox2.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox5.Clear();
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text=="")
            {
                
                MessageBox.Show("           Silme İşlemi Hatalı, Lütfen belirtilen alanı doldurunuz.           ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.BackColor = Color.Red;
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from GirişEkranı where YönŞubeNo=@YönŞubeNo", baglantı);
                komut.Parameters.AddWithValue("@YönŞubeNo", textBox3.Text);
                komut.ExecuteNonQuery();
                verilerigöster("SELECT * from GirişEkranı");
                baglantı.Close();
                textBox3.Clear();
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para FROM AnaPara where  AtmNO=1", baglantı);
            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {
                
                int anapara = read.GetInt32(0);
                anapara = int.Parse(textBox1.Text)+anapara;
                read.Close();
                SqlCommand komut2 = new SqlCommand("UPDATE AnaPara SET Para=@anapara WHERE AtmNO=1", baglantı);
                komut2.Parameters.AddWithValue("@anapara", anapara);
                komut2.ExecuteNonQuery();
            } 
            baglantı.Close();
            MessageBox.Show("             İşleminiz başarılı bir şekilde gerçekleştirilmiştir...             ", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT Para FROM AnaPara where  AtmNO=1", baglantı);

            SqlDataReader read = komut.ExecuteReader();


            if (read.Read())
            {

                label5.Text = read["Para"].ToString();
            }
            baglantı.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        

       
    }
}
