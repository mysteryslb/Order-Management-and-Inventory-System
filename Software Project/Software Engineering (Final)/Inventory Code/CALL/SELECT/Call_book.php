
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
include ('buttonc.php');
require_once('mysqli_connect.php');
$query = "Select * FROM Book ORDER BY ID";

$response = @mysqli_query($dbc, $query);

if($response){$row = mysqli_fetch_array($response);
if( $row != null){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

<tr><td align="left"><b>ID</b></td>
<td align="left"><b>Name</b></td>
<td align="left"><b>Email</b></td>
<td align="left"><b>Contact Number</b></td>
<td align="left"><b>Date & Time</b></td>
<td align="left"><b>Status</b></td></tr>';

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['NAME'] . '</td><td align="left">' .
$row['EMAIL'] . '</td><td align="left">' . 
$row['CN'] . '</td><td align="left">' .
$row['DATE'] . '</td><td align="left">'.
$row['STATUS'] . '</td><td align="left">';

echo '</tr>';
while($row = mysqli_fetch_array($response)){

echo '<tr><td align="left">' . 
$row['ID'] . '</td><td align="left">' . 
$row['NAME'] . '</td><td align="left">' .
$row['EMAIL'] . '</td><td align="left">' . 
$row['CN'] . '</td><td align="left">' .
$row['DATE'] . '</td><td align="left">'.
$row['STATUS'] . '</td><td align="left">';

echo '</tr>';
}

echo '</table>';
include('Call_Book2.php');
}else{
include ('../error.php');
	
}
} else {

echo "Couldn't issue database query<br />";


}



?>
</body>
</html>