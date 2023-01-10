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

namespace AraçKiralama_ŞafakDemir
{
    public partial class AraçList : Form
    {
        ProjectContext db;
        SqlCommand cmd;

        public AraçList()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
      

        void griddoldur()
        {
            con = new SqlConnection(@"Server=DESKTOP-D6TBA31\SQLEXPRESS;Database=AraçKiralama;Integrated Security=true ");
            da = new SqlDataAdapter("Select * From AracBilgis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "AracBilgis");
            dataGridView1.DataSource = ds.Tables["AracBilgis"];
            con.Close();
        }

        private void AraçList_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Seri.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_Model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Renk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Km.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Yakıt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_Ücret.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_durum.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from AracBilgis where Id=" + txt_Id.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update AracBilgis set Plaka='" + txt_Plaka.Text + "',Marka='" + txt_marka.Text + "',ModelYıl='" + txt_Model.Text + "',Renk='" + txt_Renk.Text + "',Km='" + txt_Km.Text + "',Yakıt='" + txt_Yakıt.Text + "',KiraÜcreti='" + txt_Ücret.Text + "',AracDurumu='" + txt_durum.Text +  "' where Id =" + txt_Id.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}
