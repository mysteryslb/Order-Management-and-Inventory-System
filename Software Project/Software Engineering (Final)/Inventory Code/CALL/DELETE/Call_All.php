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
<?php
DEFINE ('DB_USER','root');
DEFINE ('DB_PASSWORD','john191191');
DEFINE ('DB_HOST','localhost');
DEFINE ('DB_NAME','inventory');

$dbc = @mysqli_connect(DB_HOST,DB_USER, DB_PASSWORD, DB_NAME)
OR die('Could not connect to MySQL' .mysqli_connect_error());

$query = "Select * FROM inventory ORDER BY ID";

$response = @mysqli_query($dbc, $query);

if($response){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

<tr><td align="left"><b>ID</b></td>
<td align="left"><b>ITEM</b></td>
<td align="left"><b>IN STOCK</b></td>
<td align="left"><b>USED STOCK THIS WEEK</b></td>
<td align="left"><b>STOCK NEEDED</b></td>
<td align="left"><b>STOCK UNIT</b></td>
<td align="left"><b>PRICE FROM SUPPLIER</b></td>
<td align="left"><b>PRICE SOLD</b></td>
<td align="left"><b>CATEGORY</b></td></tr>';

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
$row['CAT'] . '</td><td align="left">';

echo '</tr>';
}

echo '</table>';

} else {

echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);

}

mysqli_close($dbc);

?>
</body>
</html>