<?php
	$sql = "select * from hieusp where idhieusp = '$_GET[id]'";
	$row=mysql_query($sql);
	$dong=mysql_fetch_array($row);
?>
<div style="width: 150px; height="300" class="button_themsp">
<a href="index.php?quanly=hieusp&ac=lietke">Liệt Kê Sản Phẩm</a> 
</div>
<form action="modules/quanlyhieusp/xuly.php?id=<?php echo $dong['idhieusp']?>" method="post" enctype="multipart/form-data">
<h3>&nbsp;</h3>
<table width="200" border="1">
  <tr>
    <td colspan="2" style="text-align:center;font-size:25px;">Sửa Hiệu Sản Phẩm</td>
  </tr>
  <tr>
    <td width="97">Tên Loại Sản Phẩm</td>
    <td width="87"><input type="text" name="hieusp" value="<?php echo $dong['tenhieusp'] ?>"></td>
  </tr>
  <tr>
    <td>Tình Trạng</td>
    <td><select name="tinhtrang">
      <?php
	if($dong['tinhtrang'] == 1){
	?>
      <option value="1" selected="selected">Kích Hoạt</option>
      <option value="2">Không Kích Hoạt</option>
      <?php
	}else{
	?>
      <option value="1">Kích Hoạt</option>
      <option value="2" selected="selected">Không Kích Hoạt</option>
      <?php
	}
	 ?>
      </select></td>
  </tr>
  <tr>
    <td colspan="2"><div align="center">
      <input type="submit" name="sua" value="Sửa">
    </div></td>
  </tr>
</table>
</form>


