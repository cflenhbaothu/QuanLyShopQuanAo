<?php
	$sql_lietkesp="select * from hieusp order by idhieusp desc ";
	$row_lietkesp=mysql_query($sql_lietkesp);

?>
<div style="width: 150px; height="300" class="button_themsp">
<a href="index.php?quanly=hieusp&ac=them">Thêm Sản Phẩm</a> 
</div>

<table width="100%" border="1">
  <tr>
    <td>ID</td>
    <td>Hiệu Sản Phẩm</td>
    <td>Tình Trạng</td>
    <td colspan="2">Quản Lý</td>
  </tr>
  <?php
  $i=1;
  while($dong=mysql_fetch_array($row_lietkesp)){

  ?>
  <tr>
    <td><?php  echo $i;?></td>
    <td><?php echo $dong['tenhieusp'] ?></td>
    <td><?php
	if($dong['tinhtrang'] == 1 ){
		echo 'Kích Hoạt';
	}else{
		echo 'Không Kích Hoạt';
	}
    ?></td>
    <td><a href="index.php?quanly=hieusp&ac=sua&id=<?php echo $dong['idhieusp'] ?>"><center><img src="../imgs/edit.png" width="30" height="30" /></center></a></td>
    <td><a href="modules/quanlyhieusp/xuly.php?id=<?php echo $dong['idhieusp']?>" class="delete_link"><center><img src="../imgs/delete.png" width="30" height="30" /></center></a></td>
  </tr>
  <?php
  $i++;
  }
  ?>
</table>
