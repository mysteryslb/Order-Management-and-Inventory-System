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
<?php include('BUTTON.php')?>
<form action="Call_Insert3-3.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>Menu Item Name</td>
	<td align="center"><input type="text" name="ITEM" size="30" /></td>
</tr> 
<tr>
	<td>Price to be sold</td>
	<td align="center"><input type="text" name="PRICE_SELL" size="30"  /></td>
</tr>
<tr>
	<td>Food Type</td>
	<td align="center"><input type="text" name="UNIT" size="30"  /></td>
</tr>
<tr>
	<td>Category</td>
	<td align="center"><input type="text" name="CAT" size="30" readonly value = "MENU"  /></td>
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