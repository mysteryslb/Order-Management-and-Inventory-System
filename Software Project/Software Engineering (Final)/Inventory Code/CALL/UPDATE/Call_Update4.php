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
<?php include ('Button.php');echo "Enter ID of item you want updated:<br/>"; ?>
<form action="Call_Update.php" method="POST">

<table border="0">
<tr>
	<td>Item ID</td>
	<td align="center"><input type="text" name="ID" size="30" /></td>
</tr>

<tr>
<td colspan="2" align="right">
<input type="submit" name="submit" value="Send" />
</td>
</tr>

</table>
</form>
<?php 

	include('Call_All2.php');
?>
</body>
</html>