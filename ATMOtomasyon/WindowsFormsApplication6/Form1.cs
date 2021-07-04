using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class KartEk : Form
    {
        public KartEk()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            KartEk formkapa = new KartEk();
            formkapa.Close();
            GirişEk  form = new GirişEk ();
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToString();
        }

        private void KartEk_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
