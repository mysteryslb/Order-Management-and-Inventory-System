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
<?php include('BUTTONw.php')?>
<form action="Call_Work1.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>Worker Name</td>
	<td align="center"><input type="text" name="ITEM" size="30" /></td>
</tr>

<tr>
	<td>Contact Number</td>
	<td align="center"><input type="text" name="QTY_IN" size="30" /></td>
</tr>
<tr>
	<td>Address</td>
	<td align="center"><input type="text" name="QTY_CNST" size="30"  /></td>
</tr>
<tr>
	<td>Email</td>
	<td align="center"><input type="text" name="QTY_UNIT" size="30"  /></td>
</tr>
<tr>
	<td>Position</td>
	<td align="center"><input type="text" name="PRICE_BUY" size="30"  />
<select name = "CAT">
  <option value="OWNER">Owner</option>
  <option value="FINANCE">Finance</option>
  <option value="CUSTOMER_SUPPORT">Customer Suppport</option>
</select></td>
</tr>
<tr>
	<td>Pay</td>
	<td align="center"><input type="text" name="PAY" size="30"   />
<select name = "PAYC">
  <option value="MONTHLY">Monthly</option>
  <option value="TWICE_A_MONTH">Every 2 Weeks</option>
  <option value="PER_WORK_DAY">Per Work Day</option>
</select></td>
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