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
    public partial class AracEkle : Form
    {
        ProjectContext db;
        public AracEkle()
        {
            InitializeComponent();
            db = new ProjectContext();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            AracBilgi k = new AracBilgi();
            k.Seri = txt_seri.Text;
            k.Plaka = txt_plaka.Text;
            k.Marka = txt_marka.Text;
            k.ModelYıl = txt_yıl.Text;
            k.Km =txt_km.Text;
            k.KiraÜcreti =Convert.ToInt32(txt_KiraUcreti.Text);
            k.Renk = txt_renk.Text;
            k.Yakıt = txt_yakıt.Text;
            k.AracDurumu = txt_durum.Text;
            db.AracBilgis.Add(k);
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
