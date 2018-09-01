/** Buat Database DB_SUHU **/
CREATE DATABASE DB_SENSOR
GO

/** Gunakan Database DB_SUHU **/
USE DB_SENSOR
GO

/** Buat Tabel tbl_suhu **/
CREATE TABLE tbl_sensor
(
id int PRIMARY KEY IDENTITY(1,1),
suhu_air float,
kekeruhan_air float,
ph_air float,
do_air float
)
GO

/** Seting format waktu ke tanggal-bulan-tahun jam:menit:detik **/
/**SET DATEFORMAT dmy;
GO**/

INSERT INTO tbl_sensor (suhu_air, kekeruhan_air, ph_air, do_air) VALUES(24, 25, 7, 0)