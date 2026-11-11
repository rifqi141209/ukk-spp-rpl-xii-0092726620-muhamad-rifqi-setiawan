using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_csharp
{
    public partial class FormRegisterPetugas : Form
    {
        string koneksi = "server=localhost;port=3306;username=root;password=;database=db_spp_sekolah_xii";
        public FormRegisterPetugas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection k = new MySqlConnection(koneksi);
            try
            {
                k.Open();
                string query = "INSERT INTO petugas (username, password, nama_petugas, level) VALUES (@username, @password, @nama_petugas, @level)";
                MySqlCommand komando = new MySqlCommand(query, k);
                komando.Parameters.AddWithValue("@username", txtUsername.Text);
                komando.Parameters.AddWithValue("@password", txtPassword.Text);
                komando.Parameters.AddWithValue("@nama_petugas", txtNamaPetugas.Text);
                komando.Parameters.AddWithValue("@level", cmbLevel.SelectedItem.ToString());
                int result = komando.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data petugas berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data petugas.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                k.Close();
            }
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
