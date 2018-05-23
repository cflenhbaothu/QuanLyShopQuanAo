<?php
	$sql_moinhat="select * from sanpham order by idsanpham desc limit 0,24";
	$row_moinhat=mysql_query($sql_moinhat);
	
?>
	<div class="tieude">Sản Phẩm Mới Nhất</div>
                	<ul class="product">
                    <?php
					while($dong_moinhat=mysql_fetch_array($row_moinhat)){
					?>
                    	<li><a href="?quanly=chitietsp&idloaisp=<?php echo $dong_moinhat['loaisp'] ?>&id=<?php echo $dong_moinhat['idsanpham'] ?>">
                        	<img src="admincp/modules/quanlysanpham/uploads/<?php echo $dong_moinhat['hinhanh'] ?>" width="129px" height="172px" />
                            <p style="color:skyblue"><?php echo $dong_moinhat['tensp'] ?></p>
                            <p style="color:red;font-weight:bold; border:1px solid #d9d9d9; width:150px;
                            height:30px; line-height:30px;margin-left:35px;margin-bottom:5px;"><?php echo number_format($dong_moinhat['giadexuat']).' '.''?></p>
                        </a></li>
                      <?php
					}
					  ?>
                    </ul>
                 <div class="clear"></div>
                 
 <?php
 
