
<div style="width: 150px; height="300" class="button_themsp">
<a href="index.php?quanly=tintuc&ac=lietke">Liệt Kê Tin Tức</a></div>
<form action="modules/quanlytintuc/xuly.php" method="post" enctype="multipart/form-data">
<h3>&nbsp;</h3>
<table width="600" border="1">
  <tr>
    <td colspan="2"  style="text-align:center;font-size:25px;">Thêm Tin Tức</td>
  </tr>
  <tr>
    <td width="97">Tên Tin Tức</td>
    <td width="87"><input type="text" name="tentintuc"></td>
  </tr>
  <tr>
    <td>Mã Tin</td>
    <td><input type="text" name="matin"></td>
  </tr>
  <tr>
    <td>Hình Ảnh</td>
    <td><input type="file" name="hinhanh" /></td>
  </tr>
  <tr>
    <td>Nội Dung</td>
    <td><textarea name="noidung" cols="40" rows="10"></textarea></td>
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
      <input type="submit" name="them" value="Thêm Tin">
    </div></td>
  </tr>
</table>
</form>


