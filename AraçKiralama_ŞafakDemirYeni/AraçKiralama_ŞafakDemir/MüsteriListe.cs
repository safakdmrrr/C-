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
    public partial class MüsteriListe : Form
    {
        ProjectContext db;
        SqlCommand cmd;
        public MüsteriListe()
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
            da = new SqlDataAdapter("Select * From MüsteriBilgi", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "MüsteriBilgi");
            dataGridView1.DataSource = ds.Tables["MüsteriBilgi"];
            con.Close();
        }


        private void MüsteriListe_Load(object sender, EventArgs e)
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
            txt_Tc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Mail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Adres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

    private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from MüsteriBilgi where Id=" + txt_Id.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update MüsteriBilgi set AdSoyad='" + txt_AdSoyad.Text + "',Tel='" + txt_Tel.Text + "',Mail='" + txt_Mail.Text + "',Tc='" + txt_Tc.Text + "',Adres='" + txt_Adres.Text + "' where Id =" + txt_Id.Text+ "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}
