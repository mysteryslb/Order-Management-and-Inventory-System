<?php 
require_once('mysqli_connect.php');
$query = "Select PASS FROM LOGIN WHERE ID = 3";

$response = @mysqli_query($dbc, $query);
$row = mysqli_fetch_array($response);
if ($row['PASS'] == 'admin')
{
	include ('Call_AddRemoveW.php');}
else{
	include ('YSNP.php');
}

?>