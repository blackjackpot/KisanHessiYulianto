<?php
include"koneksi.php";
$id=$_GET['id'];
$query="delete from user where Member_id='$id'";
mysql_query($query);
header("location:List.php");



?>