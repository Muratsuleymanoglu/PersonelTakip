using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace personel_kayit_programi
{
    public partial class Frmgrafik : Form
    {
        public Frmgrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=RASIT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void Frmgrafik_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutg1 = new SqlCommand("sp_GrafikSehirPersonelSayisi", baglanti);
                komutg1.CommandType = CommandType.StoredProcedure; 
                SqlDataReader dr1 = komutg1.ExecuteReader();
                while (dr1.Read())
                {
                    chart1.Series["sehirler"].Points.AddXY(dr1[0], dr1[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehir grafiği yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            try
            {
                baglanti.Open();
                SqlCommand komutg2 = new SqlCommand("sp_GrafikMeslekOrtalamaMaas", baglanti);
                komutg2.CommandType = CommandType.StoredProcedure; 
                SqlDataReader dr2 = komutg2.ExecuteReader();
                while (dr2.Read())
                {
                    chart2.Series["meslek-maas"].Points.AddXY(dr2[0], dr2[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Meslek-Maaş grafiği yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}
