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
<?Php
$dbc = @mysqli_connect(DB_HOST,DB_USER, DB_PASSWORD, DB_NAME)
OR die('Could not connect to MySQL' .mysqli_connect_error());

$query = "Select * FROM customers ORDER BY ID";

$response = @mysqli_query($dbc, $query);

if($response){
$row = mysqli_fetch_array($response);
if( $row != null){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >
<td align="left"><b>Order ID</b></td>
<td align="left"><b>Name</b></td>
<td align="left"><b>Contact Number</b></td>
<td align="left"><b>Billing Address</b></td>
<td align="left"><b>Event Address</b></td>
<td align="left"><b>Date</b></td>
<td align="left"><b>Paid Amount</b></td>';
echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['NAME'] . '</td><td align="left">' .
$row['CN'] . '</td><td align="left">' . 
$row['B_ADD'] . '</td><td align="left">' .
$row['E_ADD'] . '</td><td align="left">' . 
$row['DATE'] . '</td><td align="left">' .
$row['PAY'] . '</td><td align="left">' ;
while($row = mysqli_fetch_array($response)){

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['NAME'] . '</td><td align="left">' .
$row['CN'] . '</td><td align="left">' . 
$row['B_ADD'] . '</td><td align="left">' .
$row['E_ADD'] . '</td><td align="left">' . 
$row['DATE'] . '</td><td align="left">' .
$row['PAY'] . '</td><td align="left">' ;

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