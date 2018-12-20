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
<body>
<?php include ('Buttonp.php'); echo "Select what is to be changed:<br/>"; ?>
<form action="pass2.php" method="POST">
<select name = "option">
  <option value="admin">Admin</option>
  <option value="user">Encoders</option>
</select>
<table border="0">
<tr>
	<td>Old Password</td>
	<td align="center"><input type="text" name="old" size="30" /></td>
	</tr>
	<tr>
	<td>New Password</td>
	<td align="center"><input type="text" name="new" size="30" /></td>
</tr>
<tr>
	<td>Hint</td>
	<td align="center"><input type="text" name="hint" size="30" /></td>
</tr>

<tr>
<td colspan="2" align="right">
<input type="submit" name="submit" value="Send" />
</td>
</tr>

</table>
</form>
</body>
</html>