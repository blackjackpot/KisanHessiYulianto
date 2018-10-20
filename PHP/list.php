<?php include "koneksi.php";?>
<div class="container">
  <center><h2>Membership</h2>
  <p>Play Converter</p>                                                                                      
         </center>
  <table width=85% border="3" align="center">
    <thead>
      <tr>
        <th >No</th>
        <th>nama lengkap</th>
		<th>Telepon</th>
        <th>E-mail</th>
        <th>Alamat</th>
		<th>Aksi kita </th>
      </tr>
    </thead>
    <tbody>
	
	<?php 
	$query = "select * from user";
	$res = mysql_query($query);
	$no=1;
	while($row=mysql_fetch_array($res)){
	?>
      <tr>
        <td align="center"><?php echo $row['Member_id'];?></td>
        <td align="center"><?php echo $row['Nama_lengkap'];?> </td>
        <td align="center"><?php echo $row['Telepon'];?></td>
        <td align="center"><?php echo $row['Email'];?></td>
		<td align="center"><?php echo $row['Alamat'];?></td>
        <td align="center"><a href="edit.php?mod=produk_form&id=<?php echo $row['Member_id'];?>"> edit</a> |<a href="deleteform.php?mod=produk_form &id=<?php echo $row['Member_id'];?>"> delete</a></td>
      </tr>
	<?php } ?>
	
	
    </tbody>
  </table><br><center>
  <button><a href="index.php">back</a></button>  </center>
  </div>
</div>