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
<?php
include ('BUTTON.php');
require_once('mysqli_connect.php');
$query = "Select * FROM inventory WHERE CAT = 'INGR' ORDER BY ID";

$response = @mysqli_query($dbc, $query);

if($response){$row = mysqli_fetch_array($response);
if( $row != null){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

<tr><td align="left"><b>ID</b></td>
<td align="left"><b>ITEM</b></td>
<td align="left"><b>IN STOCK</b></td>
<td align="left"><b>REFERENCE STOCK NUMBER</b></td>
<td align="left"><b>STOCK NEEDED</b></td>
<td align="left"><b>STOCK UNIT</b></td>
<td align="left"><b>PRICE FROM SUPPLIER</b></td>
<td align="left"><b>PRICE SOLD</b></td>
<td align="left"><b>FOOD TYPE</b></td>
<td align="left"><b>CATEGORY</b></td>
<td align="left"><b>LAST MODIFIED</b></td></tr>';

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' .
$row['QTY_IN'] . '</td><td align="left">' . 
$row['QTY_OUT'] . '</td><td align="left">' .
$row['QTY_CNST'] . '</td><td align="left">' . 
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['PRICE_BUY'] . '</td><td align="left">' . 
$row['PRICE_SELL'] . '</td><td align="left">' .
$row['SC'] . '</td><td align="left">'.
$row['CAT'] . '</td><td align="left">'.
$row['DATE'] . '</td><td align="left">';

echo '</tr>';
while($row = mysqli_fetch_array($response)){

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' .
$row['QTY_IN'] . '</td><td align="left">' . 
$row['QTY_OUT'] . '</td><td align="left">' .
$row['QTY_CNST'] . '</td><td align="left">' . 
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['PRICE_BUY'] . '</td><td align="left">' . 
$row['PRICE_SELL'] . '</td><td align="left">' .
$row['SC'] . '</td><td align="left">'.
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
<body>
</body>
</html>