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
<?php include('BUTTONC.php')?>
<form action="Call_Cust2.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>Name</td>
	<td align="center"><input type="text" name="N" size="30" /></td>
</tr> 
<tr>
	<td>Contact Number</td>
	<td align="center"><input type="text" name="CN" size="30"  /></td>
</tr>
<tr>
	<td>Email</td>
	<td align="center"><input type="text" name="E" size="30" /></td>
</tr>
<tr>
	<td>Date</td>
	<td align="center"><input type="date" name="D" size="30"  /></td>
</tr>
<select name = "S">
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