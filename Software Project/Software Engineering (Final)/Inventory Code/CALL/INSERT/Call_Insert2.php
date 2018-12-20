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
<form action="Call_Insert2-2.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>Item Name</td>
	<td align="center"><input type="text" name="ITEM" size="30" /></td>
</tr>

<tr>
	<td>In Stock</td>
	<td align="center"><input type="text" name="QTY_IN" size="30" /></td>
</tr>

<tr>
	<td>Reference Stock</td>
	<td align="center"><input type="text" name="QTY_OUT" size="30"  /></td>
</tr>
<tr>
	<td>Unit of Item</td>
	<td align="center"><input type="text" name="QTY_UNIT" size="30"  /></td>
</tr>
<tr>
	<td>Price from supplier</td>
	<td align="center"><input type="text" name="PRICE_BUY" size="30"  /></td>
</tr>
<tr>
	<td>Price to be sold</td>
	<td align="center"><input type="text" name="PRICE_SELL" size="30"  /></td>
</tr>
<tr>
	<td>Sub Category</td>
	<td align="center"><input type="text" name="SC" size="30"  /></td>
</tr>
<tr>
	<td>Category</td>
	<td align="center"><input type="text" name="CAT" size="30" readonly value = "TBL" /></td>
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