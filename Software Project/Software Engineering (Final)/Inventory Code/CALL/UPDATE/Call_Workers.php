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
require_once('mysqli_connect.php');
$query = "Select * FROM Workers ORDER BY ID";

$response = @mysqli_query($dbc, $query);

if($response){$row = mysqli_fetch_array($response);
if( $row != null){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

<tr><td align="left"><b>ID</b></td>
<td align="left"><b>CUSTOMER NAME</b></td>
<td align="left"><b>CONTACT NUMBER</b></td>
<td align="left"><b>ADDRESS OF EVENT</b></td>
<td align="left"><b>EMAIL</b></td>
<td align="left"><b>POSITION</b></td>
<td align="left"><b>DEPARTMENT</b></td>
<td align="left"><b>PAY</b></td>
<td align="left"><b>PAY CATEGORY</b></td></tr>';

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['NAME'] . '</td><td align="left">' .
$row['CN'] . '</td><td align="left">' . 
$row['ADDR'] . '</td><td align="left">' .
$row['EMAIL'] . '</td><td align="left">' . 
$row['COMPANY_POSITION'] . '</td><td align="left">' .
$row['DEPARTMENT'] . '</td><td align="left">' . 
$row['PAY'] . '</td><td align="left">' .
$row['PAYC'] . '</td><td align="left">';

echo '</tr>';
while($row = mysqli_fetch_array($response)){

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['NAME'] . '</td><td align="left">' .
$row['CN'] . '</td><td align="left">' . 
$row['ADDR'] . '</td><td align="left">' .
$row['EMAIL'] . '</td><td align="left">' . 
$row['COMPANY_POSITION'] . '</td><td align="left">' .
$row['DEPARTMENT'] . '</td><td align="left">' . 
$row['PAY'] . '</td><td align="left">' .
$row['PAYC'] . '</td><td align="left">';


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