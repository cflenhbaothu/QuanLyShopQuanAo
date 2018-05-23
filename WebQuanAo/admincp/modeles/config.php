<?php
	$tenmaychu='localhost';
	$tentaikhoan='root';
	$pass='';
	$csdl='BanHang';
	$conn=mysql_connect($tenmaychu,$tentaikhoan,$pass,$csdl) or die('Không Kết Nối Được');
	mysql_select_db($csdl,$conn);
?>