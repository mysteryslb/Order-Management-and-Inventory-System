<!DOCTYPE html>
<html>
<head>
<title>J&J's Catering Company</title>
<style>
body{
background-image: url("../bg.jpg");
background-size:cover;
}
p.one{
	borderstyle: solid;
	border-color: #ff0000 #00ff00 #0000ff;
	table align="left"; cellspacing="5"; cellpadding="8";
	
}
</style>
</head>
<body><form action="transfer.php" method="POST">

<table border="0">

<tr><td><b>Enter ID of booking that ended</b></td></tr>
<tr>

	<td align="center"><input type="text" name="ID" size="30" /></td>
</tr>
<select name = "status">
  <option value="Served">Served</option>
  <option value="Cancelled">Cancelled</option>
</select>

<tr>
<td colspan="2" align="right">
<input type="submit" name="submit" value="Send" />
</td>
</tr>

</table>
</form>
</body>
</html>