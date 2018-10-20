<?php
include "koneksi.php";

$nama=$_POST['nama'];
$buton=$_POST['jenis'];
$telpon=$_POST['tel'];
$email=$_POST['email'];
$alamat=$_POST['alamat'];
$bulan=$_POST['tang'];
$cat=$_POST['catat'];
$kota=$_POST['ko'];
$pos=$_POST['cod'];
$produkid = getautoid('Member_id','user','Audition');

$query="INSERT INTO `member`.`user` (`Member_id`,`Nama_lengkap`,`Jenis_kelamin`,`Tanggal_lahir`,`Telepon`,`Email`,`Alamat`,`Catatan`,`Kota`,`Kode_pos`) VALUES ('$produkid','$nama','$buton','$bulan','$telpon','$email','$alamat','$cat','$kota','$pos')";

mysql_query($query);

header("location:List.php");


?>