<div style="width: 150px; height="300" class="button_themsp">
<a href="index.php?quanly=loaisp&ac=lietke">Liệt Kê Sản Phẩm</a> 
</div>
<form action="modules/quanlyloaisp/xuly.php" method="post" enctype="multipart/form-data">
<h3>&nbsp;</h3>
<table width="200" border="1">
  <tr>
    <td colspan="2" style="text-align:center; font-size:25px">Loại Sản Phẩm</td>
  </tr>
  <tr>
    <td width="97">Tên Sản Phẩm</td>
    <td width="87"><input type="text" name="loaisp"></td>
  </tr>
  <tr>
    <td>Tình Trạng</td>
    <td><select name="tinhtrang">
      <option value="1">Kích Hoạt</option>
      <option value="2">Không Kích Hoạt</option>
      </select></td>
  </tr>
  <tr>
    <td colspan="2"><div align="center">
      <input type="submit" name="them" value="Thêm">
    </div></td>
  </tr>
</table>
</form>


