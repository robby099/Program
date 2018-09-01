/** Buat Database DB_SUHU **/
CREATE DATABASE DB_SUHU
GO

/** Gunakan Database DB_SUHU **/
USE DB_SUHU
GO

/** Buat Tabel tbl_suhu **/
CREATE TABLE tbl_suhu
(
id int PRIMARY KEY IDENTITY(1,1),
suhu float,
waktu datetime
)
GO

/** Seting format waktu ke tanggal-bulan-tahun jam:menit:detik **/
SET DATEFORMAT dmy;
GO

INSERT INTO tbl_suhu (suhu, waktu) VALUES(24, "20/10/2013 06:15:01")