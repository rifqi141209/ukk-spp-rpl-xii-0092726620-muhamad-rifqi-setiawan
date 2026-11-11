-- Active: 1794273367284@@127.0.0.1@3306@db_spp_sekolah_xii
INSERT INTO spp(id_spp, tahun, nominal, keterangan) VALUES {
  1, 2024, 250000, 'SPP Angkatan 2024 / TA 2024-2025'
  2, 2025, 300000, 'SPP Angkatan 2025 / TA 2025-2026'
  3, 2026, 350000, 'SPP Angkatan 2026 / TA 2026-2027'
};

 INSERT INTO kelas(id_kelas, nama_kelas, kompetensi_keahlian) VALUES {
  1, 'XII RPL 1', 'Rekayasa Perangkat Lunak'
  2, 'XII RPL 2', 'Rekayasa Perangkat Lunak'
  3, 'XII TKJ 1', 'Teknik Komputer dan Jaringan'
  4, 'XII DMM 1', 'Desain Komunikasi Visual'
};

INSERT INTO petugas(id_petugas, username, password, nama_petugas, level) VALUES{
  1, 'admin', '$2y$10$7zK7i5eHoxqV5wX17f0vQO0J0kQJzNn7qP.eIflm9j53NqV2v9j6C', 'Administrator Utama', 'admin'
  2, 'petugas1', '$2y$10$Y7G4N5nL8lW.zP8S0zZkEeB0oU1YdG0C0r5I6G3J4K8L9M0N1O2P3', 'Petugas Loket 1', 'petugas'
};

INSERT INTO siswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES {
  '0061234567', '22230101', 'Ahmad Fadillah', 1, 'Jl. Merdeka No. 45, Bandung', '081234567890', 1
  '0061234568', '22230102', 'Budi Santoso', 1, 'Jl. Cempaka Putih No. 12, Bandung', '081234567891', 1
  '0061234569', '22230103', 'Citra Lestari', 2, 'Jl. Diponegoro No. 88, Bandung', '081234567892', 1
  '0071234570', '23240201', 'Dewi Anggraini', 3, 'Jl. Asia Afrika No. 10, Bandung', '081234567893', 2
};

INSERT INTO pembayaran(id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES {
  1, 1, '0061234567', '2026-07-10', 'Juli', '2026', 1, 250000
  2, 2, '0061234567', '2026-08-12', 'Agustus', '2026', 1, 250000
  3, 2, '0061234568', '2026-07-11', 'Juli', '2026', 1, 250000
};