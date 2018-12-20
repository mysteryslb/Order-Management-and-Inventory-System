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
select {
    position:relative;
    background-color: white;
	left:124px;
	top:118px;
}
</style>
</head>
<body>
<?php include('BUTTON.php')?>
<form action="Call_Insert4-4.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>Bundle Name</td>
	<td align="center"><input type="text" name="ITEM" size="30" /></td>
</tr> 
<tr>
	<td>Principal Cost</td>
	<td align="center"><input type="text" name="BUY" size="30"  /></td>
</tr>
<tr>
	<td>Price to be sold</td>
	<td align="center"><input type="text" name="PRICE_SELL" size="30"  /></td>
</tr>
<tr>
	<td>Event</td>
	<select name = "UNIT">
  <option value="Premium">Premium</option>
  <option value="Deluxe">Deluxe</option>
  <option value="Regular">Regular</option>
  <option value="Economy">Economy</option>
</select>
</tr>
<tr>
	<td>Category</td>
	<td align="center"><input type="text" name="CAT" size="30" readonly value = "BUNDLE"  /></td>
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