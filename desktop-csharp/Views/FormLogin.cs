using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_csharp.Config;
using desktop_csharp.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Expect;

namespace desktop_csharp
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterScreen;
                this.AcceptButton = btnLogin; 
                txtPassword.UseSystemPasswordChar = true;
            }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong ", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            MySqlConnection k = Koneksi.Getkoneksi();
            try
            {
                k.Open();
                string query = "SELECT * FROM petugas WHERE username = @username AND password = @password";
               MySqlCommand komando = new MySqlCommand(query, k);
                MySqlDataReader reader = komando.ExecuteReader();
                if (reader.Read())
                {
                    int id_petugas = reader.GetInt32("id_petugas");
                    string username = reader.GetString("username");
                    string nama_petugas = reader.GetString("nama_petugas");
                    string level = reader.GetString("level");
                    SessionUser.SetSession(id_petugas, username, nama_petugas, level);
                    MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormDashboard dashboardForm = new FormDashboard();
                    dashboardForm.Show();
                }
                else
                {
                    k.Close();
                    MessageBox.Show("Username atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegisterPetugas registerForm = new FormRegisterPetugas();
           registerForm.Show();
           
        }
    }
}
