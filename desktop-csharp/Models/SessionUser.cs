using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Mysqlx.Notice.Warning.Types;

namespace desktop_csharp.Models
{
    
    internal class SessionUser
    {
        public SessionUser(int id_petugas, string username, string nama_petugas, string level, bool isLoggedIn)
        {
            this.id_petugas = id_petugas;
            this.username = username;
            this.nama_petugas = nama_petugas;
            this.level = level;
            IsLoggedIn = isLoggedIn;
        }

            public  int id_petugas { get; set; }
            public string username { get;  set; }
            public string nama_petugas { get; set; }
            public string level { get; set; }
            public bool IsLoggedIn { get; set; }

        public static void SetSession(int id_petugas, string username, string nama_petugas, string level)
        {

            if (id_petugas <= 0 || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(nama_petugas) || string.IsNullOrWhiteSpace(level))
            {
                throw new ArgumentException("Data session tidak valid.");
            }
            SessionUser session = new SessionUser(id_petugas, username, nama_petugas, level, true);
            id_petugas = session.id_petugas;
            username = session.username;
            nama_petugas = session.nama_petugas;
            level = session.level;

        }

        public static void ClearSession(int id_petugas, string username, string nama_petugas, string level, bool IsLoggedIn)
            {
                id_petugas = 0;
                username = null;
                nama_petugas = null;
                level = null;
                IsLoggedIn = false;
            }

            
        
        }

    }
