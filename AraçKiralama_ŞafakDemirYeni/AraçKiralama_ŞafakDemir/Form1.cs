using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama_ŞafakDemir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {

            MüsteriEkle form = new MüsteriEkle();
            form.Show();
            this.Hide();

        }

        private void btn_MusteriListele_Click(object sender, EventArgs e)
        {
            MüsteriListe form = new MüsteriListe();
            form.Show();
            this.Hide();
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            AracEkle form = new AracEkle();
            form.Show();
            this.Hide();
        }

        private void btn_AracListele_Click(object sender, EventArgs e)
        {
            AraçList form = new AraçList();
            form.Show();
            this.Hide();
        }

        private void btn_Sözlesme_Click(object sender, EventArgs e)
        {
            Sozlesme form = new Sozlesme();
            form.Show();
            this.Hide();
        }
    }
}
