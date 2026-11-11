using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace desktop_csharp.Config
{
    internal class Koneksi
    {
        static string koneksi = "server=localhost;port=3306;username=root;password=;database=db_spp_sekolah_xii";
        public static MySqlConnection Getkoneksi()
        {
            try { 
            MySqlConnection k = new MySqlConnection(koneksi);
            k.Open();
            return k;
        }catch(Exception e)
            {
                Console.WriteLine("Koneksi Gagal: " + e.Message);
                return null;
            }
        }
    }
}
