using AraçKiralama_ŞafakDemir.ORM.Context;
using AraçKiralama_ŞafakDemir.ORM.Entitiess;
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
    public partial class MüsteriEkle : Form
    {
        ProjectContext db;
        public MüsteriEkle()
        {
            InitializeComponent();
            db = new ProjectContext();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            MüsteriBilgi k = new MüsteriBilgi();

            k.tc = txt_Tc.Text;
            k.Adres = txt_Adres.Text;
            k.AdSoyad = txt_AdSoyad.Text;
            k.Mail = txt_Mail.Text;
            k.Tel = maskedtxt_Tel.Text;
            db.MüsteriBilgis.Add(k);
            db.SaveChanges();

            MessageBox.Show("Kayıt Başarılı");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
