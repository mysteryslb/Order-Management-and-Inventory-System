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

<form action="Call_MakeMenu2.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>For Menu Item:</td>
	<td align="center"><input type="text" name="ITEM" size="30" readonly value = "<?php echo htmlspecialchars($t_ITEM);?>" /></td>
</tr> 
<tr>
	<td>Ingredient ID</td>
	<td align="center"><input type="text" name="INGR" size="30" /></td>
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