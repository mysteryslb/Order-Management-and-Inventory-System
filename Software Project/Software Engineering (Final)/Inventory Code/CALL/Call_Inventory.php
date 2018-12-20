
<?php
include ('BUTTONIN.php');
require_once('mysqli_connect.php');
$query = "SELECT * FROM inventory where CAT != 'BUNDLE' && CAT != 'MENU' && QTY_IN>0";

$response = @mysqli_query($dbc, $query);

if($response){
$row = mysqli_fetch_array($response);
if( $row != null){

echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >
<td align="left"><b>ITEM</b></td>
<td align="left"><b>IN STOCK</b></td>
<td align="left"><b>REFERENCE STOCK NUMBER</b></td>
<td align="left"><b>STOCK NEEDED</b></td>
<td align="left"><b>STOCK UNIT</b></td>
<td align="left"><b>CATEGORY</b></td>
<td align="left"><b>LAST MODIFIED</b></td></tr>';
echo '<tr><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' .
$row['QTY_IN'] . '</td><td align="left">' . 
$row['QTY_OUT'] . '</td><td align="left">' .
$row['QTY_CNST'] . '</td><td align="left">' . 
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['CAT'] . '</td><td align="left">'.
$row['DATE'] . '</td><td align="left">';
while($row = mysqli_fetch_array($response)){

echo '<tr><td align="left">' . 
$row['ITEM'] . '</td><td align="left">' .
$row['QTY_IN'] . '</td><td align="left">' . 
$row['QTY_OUT'] . '</td><td align="left">' .
$row['QTY_CNST'] . '</td><td align="left">' . 
$row['QTY_UNIT'] . '</td><td align="left">' .
$row['CAT'] . '</td><td align="left">'.
$row['DATE'] . '</td><td align="left">';

echo '</tr>';
}

echo '</table>';

}else{
echo "Empty<br />";
	
}} else {

echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);

}

mysqli_close($dbc);

?>

