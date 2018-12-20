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
tables{
	position: absolute;
	left: 10px;
	top: 190px;
}
</style>
</head>
<body>
<?php

if(isset($_POST['submit'])){
	 $data_missing = array();
    if(empty($_POST['ID']) || !ctype_digit($_POST['ID'] )){
	$data_missing[] = 'ID';}
    else{
        $t_ID = trim($_POST['ID']);
    }
if(empty($data_missing)){

require_once('mysqli_connect.php');
$query = "Select * FROM inventory  WHERE ID = $t_ID ORDER BY ID";

$response = @mysqli_query($dbc, $query);
if(mysqli_num_rows($response) >0){
if($response){
$row = mysqli_fetch_array($response);

$t_Cat = trim($row['CAT']);
if ($t_Cat == 'MENU')
{
include('button.php');
echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

<tr><td align="left"><b>ID</b></td>
<td align="left"><b>ITEM</b></td>
<td align="left"><b>STOCK UNIT</b></td>
<td align="left"><b>PRINCIPAL COST</b></td>
<td align="left"><b>PRICE SOLD</b></td>
<td align="left"><b>CATEGORY</b></td></tr>';	
echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' .
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['PRICE_BUY'] . '</td><td align="left">' . 
$row['PRICE_SELL'] . '</td><td align="left">' .
$row['CAT'] . '</td><td align="left"></td>';
$t_Item = trim($row['ITEM']);
echo '</tr>';
echo '</table>';
echo '<br><br><br>';

$t_Items =  str_replace(' ', '_', $t_Item);
$query = "Select * FROM $t_Items ORDER BY ID";
$response = @mysqli_query($dbc, $query);
if($response){
	$row = mysqli_fetch_array($response);
if( $row != null){
echo '<tables><b>Ingredients included in this Menu:</b></tables>';
echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >
 <br><br><br> <br>
<tr><td align="left"><b>ID</b></td>
<td align="left"><b>ITEM</b></td>
<td align="left"><b>IN STOCK</b></td>
<td align="left"><b>REFERENCE STOCK NUMBER</b></td>
<td align="left"><b>STOCK NEEDED</b></td>
<td align="left"><b>STOCK UNIT</b></td>
<td align="left"><b>PRICE FROM SUPPLIER</b></td>
<td align="left"><b>PRICE SOLD</b></td>
<td align="left"><b>CATEGORY</b></td></tr>';
$ID = $row['INGR_ID'];
		$nquery = "Select * FROM inventory WHERE ID = $ID ORDER BY ID";
		$nresponse = @mysqli_query($dbc, $nquery);
		if($nresponse){
			while($row = mysqli_fetch_array($nresponse)){

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
$t_Item = trim($row['ITEM']);
echo '</tr>';
	while($row = mysqli_fetch_array($response)){
		$ID = $row['INGR_ID'];
		$nquery = "Select * FROM inventory WHERE ID = $ID ORDER BY ID";
		$nresponse = @mysqli_query($dbc, $nquery);
		if($nresponse){
			while($row = mysqli_fetch_array($nresponse)){

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
$t_Item = trim($row['ITEM']);
echo '</tr>';
}
} else {
echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);
}
	}
} 
}else{
	echo '<table align="left"cellspacing="5" cellpadding="8"><tr><td align = "left"><b>Item is not within the menu table</b></td>';
}
}else{
echo '<table align="left"cellspacing="5" cellpadding="8"><tr><td align = "left"><b>Empty Menu</b></td>';
	
}
} else {

echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);

}mysqli_close($dbc);
}
else{

		include ('Call_Menu.php');
		}
}
	else{

		include ('Call_Menu.php');
	}	
}else{
	
		include ('Call_Menu.php');
}}else{
		
		include ('Call_Menu.php');
}}



?>

</body>
</html>
