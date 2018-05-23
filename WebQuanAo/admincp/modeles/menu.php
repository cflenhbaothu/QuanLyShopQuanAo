<?php
	if(isset($_POST['logout'])){
		unset($_SESSION['dangnhap']);
		header('location:login.php');
	}
?>

<div class="menu">
    	<ul>
        	<li style="width: 200px"><a href="index.php?quanly=loaisp&ac=them">Quản Lý Loại Sản Phẩm</a></li>
             <li style="width: 200px"><a href="index.php?quanly=hieusp&ac=them">Quản Lý Hiệu Sản Phẩm</a></li>
            <li style="width: 200px"><a href="index.php?quanly=sanpham&ac=them">Quản Lý Sản Phẩm</a></li>
            
            <li style="width: 200px"><a href="index.php?quanly=tintuc&ac=them">Quản Lý Tin Tức</a></li>

            <form action="" method="post" enctype="multipart/form-data">
            <input type="submit" name="logout" value="Đăng xuất" style="background:#06F;color:#fff;width:200px;height:40px;" />
            </form>
        </ul>
</div>

    <form action="index.php?quanly=timkiem&ac=sp" method="post" enctype="multipart/form-data">
        <p><input type="text" name="masp" placeholder="Nhập mã sản phẩm..." id="timkiem" required="required" /></p>
        <button type="submit"  name="timkiem" class="button-search"> <i class="fa fa-search"></i></button>   
    </form>