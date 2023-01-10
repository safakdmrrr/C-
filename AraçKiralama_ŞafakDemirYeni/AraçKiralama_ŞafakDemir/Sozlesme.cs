using AraçKiralama_ŞafakDemir.ORM.Context;
using AraçKiralama_ŞafakDemir.ORM.Entitiess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AraçKiralama_ŞafakDemir
{
    public partial class Sozlesme : Form
    {
        ProjectContext db;
        public Sozlesme()
        {
            InitializeComponent();
            db = new ProjectContext();
        }


        //private void CategoryList()
        //{
        //    cbx_Araclar.DataSource = db.AracBilgis.ToList();
        //    cbx_Araclar.DisplayMember = "Plaka";
        //    cbx_Araclar.ValueMember = "Id";
        //    cbx_Araclar.SelectedIndex = -1;

        //}
        private void AracList()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-D6TBA31\\SQLEXPRESS;Initial Catalog=AraçKiralama;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM AracBilgis";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbx_Araclar.Items.Add(dr["Plaka"]);
            }
            baglanti.Close();


        }


        private void Sozlesme_Load(object sender, EventArgs e)
        {
            AracList();
            MusteriLİst();
           // griddoldur();
        }

        private void cbx_Araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-D6TBA31\\SQLEXPRESS;Initial Catalog=AraçKiralama;Integrated Security=SSPI");
            baglanti.Open();
            string komutCumlesi = "Select * From AracBilgis where Plaka like '" + cbx_Araclar.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_Marka.Text = read["Marka"].ToString();
                txt_Seri.Text = read["Seri"].ToString();
                txt_ModelYıl.Text = read["ModelYıl"].ToString();
                txt_Renk.Text = read["Renk"].ToString();
                txt_KiraÜcreti.Text = read["KiraÜcreti"].ToString();
            }
        }
        private void MusteriLİst()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-D6TBA31\\SQLEXPRESS;Initial Catalog=AraçKiralama;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM MüsteriBilgi";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Musteriler.Items.Add(dr["AdSoyad"]);
            }
            baglanti.Close();


        }

        private void cmb_Musteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-D6TBA31\\SQLEXPRESS;Initial Catalog=AraçKiralama;Integrated Security=SSPI");
            baglanti.Open();
            string komutCumlesi = "Select * From MüsteriBilgi where AdSoyad like '" + cmb_Musteriler.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_Tc.Text = read["tc"].ToString();
                txt_Tel.Text = read["Tel"].ToString();
            }

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan Fark = DateTime.Parse(datetimeDönüs.Text) - DateTime.Parse(datetimeCikis.Text);
            int gün = Fark.Days;
            txt_Gün.Text = gün.ToString();

            txt_Tutar.Text = (gün * int.Parse(txt_KiraÜcreti.Text)).ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SözlesmeBilgi k = new SözlesmeBilgi();
            k.Plaka = cbx_Araclar.Text;
            k.Marka = txt_Marka.Text;
            k.ModelYıl = txt_Seri.Text;
            k.Renk = txt_Renk.Text;
            k.AdSoyad = cmb_Musteriler.Text;
            k.tc = txt_Tc.Text;
            k.Tel = txt_Tel.Text;
            k.EhliyetNo = txt_EhliyetNo.Text;
            k.EhliyetTarih = txt_EhliyetTarih.Text;
            k.KiraGün =Convert.ToInt32(txt_Gün.Text);
            k.KiraÜcreti = Convert.ToInt32(txt_KiraÜcreti.Text);
            k.Tutar = Convert.ToInt32(txt_Tutar.Text);
            db.SözlesmeBilgis.Add(k);
            db.SaveChanges();
            MessageBox.Show("kayıt başaralı");


        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        void griddoldur()
        {
            con = new SqlConnection(@"Server=DESKTOP-D6TBA31\SQLEXPRESS;Database=AraçKiralama;Integrated Security=true ");
            da = new SqlDataAdapter("Select * From SözlesmeBilgis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "SözlesmeBilgis");
            dataGridView1.DataSource = ds.Tables["SözlesmeBilgis"];
            con.Close();
        }
    }
}
