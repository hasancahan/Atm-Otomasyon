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
    public partial class Menu1 : Form
    {
     
        public Menu1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1BCL722\\SQLEXPRESS;Initial Catalog=Atm Otomasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
   
            Menu1 formkapa = new Menu1();
            formkapa.Close();
            ParaCek  form = new ParaCek ();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu1 formkapa = new Menu1();
            formkapa.Close();
            ParaYat form = new ParaYat();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu1 formkapa = new Menu1();
            formkapa.Close();
            Hesapİş  form = new Hesapİş();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu1 formkapa = new Menu1();
            formkapa.Close();
            Ödemeler  form = new Ödemeler();
            form.Show();
            this.Hide();
        }

        private void Menu1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak istediğinizden eminmisiniz ?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            
            Menu1  formkapa = new Menu1 ();
            formkapa.Close();
            GirişEk form = new GirişEk();
            form.Show();
            this.Hide();
        }

        
    }
}
