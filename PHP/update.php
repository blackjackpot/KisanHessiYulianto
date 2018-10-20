<?php
include "koneksi.php";

$id =$_POST['id'];
$Name =$_POST['Nama'];
$buton=$_POST['Jenis'];
$Telpon=$_POST['Tel'];
$Email=$_POST['email'];
$Alamat=$_POST['alamat'];
$bulan=$_POST['tang'];
$Cat=$_POST['catat'];
$Kota=$_POST['ko'];
$Pos=$_POST['cod'];

$query="UPDATE user SET Nama_lengkap='$Name',Jenis_kelamin='$buton',Tanggal_lahir='$bulan',Telepon='$Telpon',Email='$Email',Alamat='$Alamat',Kota='$Kota',Kode_pos='$Pos',Catatan='$Cat' WHERE user='$id'";
mysql_query($query);
header("location:List.php");
?>

