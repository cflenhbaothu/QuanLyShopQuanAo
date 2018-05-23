
<?php
	if(isset($_GET['trang'])){
		$trang=$_GET['trang'];
	}else{
		$trang='';
	}
	if($trang =='' || $trang =='1'){
		$trang1=0;
	}else{
		$trang1=($trang*5)-5;
	}
	$sql_lietkesp="select * from sanpham,hieusp,loaisp where loaisp.idloaisp=sanpham.loaisp and hieusp.idhieusp=sanpham.nhasx order by sanpham.idsanpham desc limit $trang1,5 ";
	$row_lietkesp=mysql_query($sql_lietkesp);

?>
<div style="width: 150px; height="300" class="button_themsp">
<a href="index.php?quanly=sanpham&ac=them">Thêm Mới</a> 
</div>

<table width="100%" height="100%" border="2">
  <tr>
    <td>ID</td>
    <td>Tên Sản Phẩm</td>
    <td>Mã Sản Phẩm</td>
    <td>Hình Ảnh</td>
    <td>Giá Đề Xuất</td>
    <td>Giảm Giá</td>
    <td>Số Lượng</td>
    <td>Loại Hàng</td>
    <td>Nhà Sản Xuất</td>
    <td>Tình Trạng</td>
    <td colspan="2">Quản Lý</td>
  </tr>
  <?php
  $i=1;
  while($dong=mysql_fetch_array($row_lietkesp)){

  ?>
  <tr>
  	
    <td><?php  echo $i;?></td>
    <td><?php echo $dong['tensp'] ?></td>
    <td><?php echo $dong['masp'] ?></td>
    <td><img src="modules/quanlysanpham/uploads/<?php echo $dong['hinhanh'] ?>" width=64.5px height=86px />
    <a href="index.php?quanly=gallery&ac=lietke&id=<?php echo $dong['idsanpham'] ?>" style="text-align:center;text-decoration:none; font-size:18px;color:#06F;">Gallery</a>
    </td>
    <td><?php echo number_format($dong['giadexuat']) ?></td>
    <td><?php echo number_format($dong['giagiam']) ?></td>
    <td><?php echo $dong['soluong'] ?></td>
    <td><?php echo $dong['tenloaisp'] ?></td>
    <td><?php echo $dong['tenhieusp'] ?></td>
    <td><?php $sql_tinhtrang = "select tinhtrang from sanpham";
	$row_tinhtrang = mysql_query($sql_tinhtrang);
	$dong_tinhtrang=mysql_fetch_array($row_tinhtrang);
	if($dong_tinhtrang['tinhtrang'] == 1 ){
		echo 'Kích Hoạt';
	}elseif($dong_tinhtrang['tinhtrang'] ==2){
		echo 'Không Kích Hoạt';
	}
    ?></td>
    <td><a href="index.php?quanly=sanpham&ac=sua&id=<?php echo $dong['idsanpham'] ?>" ><center><img src="../imgs/edit.png" width=32.25px height=43px /></center></a></td>
    <td><a href="modules/quanlysanpham/xuly.php?id=<?php echo $dong['idsanpham']?>" class="delete_link"><center><img src="../imgs/delete.png" width=32.25px height=43px   /></center></a></td>
  </tr>
  <?php
  $i++;
  }
  ?>
</table>
<div class="trang">
	Trang :
    <?php
	$sql_trang=mysql_query("select * from sanpham");
	$count_trang=mysql_num_rows($sql_trang);
	$a=ceil($count_trang/5);
	for($b=1;$b<=$a;$b++){
		
		if($trang==$b){
		
		echo '<a href="index.php?quanly=sanpham&ac=lietke&trang='.$b.'" style="text-decoration:underline;color:red;">'.$b.' ' .'</a>';
        
	}else{
		echo '<a href="index.php?quanly=sanpham&ac=lietke&trang='.$b.'" style="text-decoration:none;color:#000;">'.$b.' ' .'</a>';
	}
	}
	?>
</div>
