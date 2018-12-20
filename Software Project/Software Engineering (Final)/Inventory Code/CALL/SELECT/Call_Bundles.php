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
<?php include ('BUTTON.php');?>
<form action="Call_BundleItems.php" method="POST">

<table border="0">

<tr><td><b>Enter ID of Bundle you want to view</b></td></tr>
<tr>
	<td>Bundle ID</td>
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
require_once('mysqli_connect.php');
$query = "Select * FROM inventory WHERE CAT = 'BUNDLE' ORDER BY ID";

$response = @mysqli_query($dbc, $query);

if($response){
$row = mysqli_fetch_array($response);
if( $row != null){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

<tr><td align="left"><b>ID</b></td>
<td align="left"><b>ITEM</b></td>
<td align="left"><b>PRINCIPAL COST</b></td>
<td align="left"><b>PRICE SOLD</b></td>
<td align="left"><b>TYPE</b></td>
<td align="left"><b>CATEGORY</b></td>
<td align="left"><b>LAST MODIFIED</b></td></tr>';
echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' . 
$row['PRICE_BUY'] . '</td><td align="left">' . 
$row['PRICE_SELL'] . '</td><td align="left">' .
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['CAT'] . '</td><td align="left">'.
$row['DATE'] . '</td><td align="left">';
while($row = mysqli_fetch_array($response)){

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' .
$row['PRICE_BUY'] . '</td><td align="left">' . 
$row['PRICE_SELL'] . '</td><td align="left">' .
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['CAT'] . '</td><td align="left">'.
$row['DATE'] . '</td><td align="left">';

echo '</tr>';
}

echo '</table>';

}else{
include ('../error.php');
	
}} else {

echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);

}

mysqli_close($dbc);

?>

</body>
</html>