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

		$query ="Select * FROM workers WHERE ID = $t_ID";
		$response = @mysqli_query($dbc, $query);
		if($response)
		{
			if(mysqli_affected_rows($dbc)>0){
			include('buttonp.php');
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
				$Item = $row['NAME'];
				$QI = $row['CN']; 
				$QO = $row['ADDR'];
				$QC = $row['EMAIL'] ;
				$QU = $row['COMPANY_POSITION'] ;
				$PB = $row['DEPARTMENT'];
				$PS = $row['PAY'];
				$C = $row['PAYC'];
				
			}
		}else{
			echo "Item does not exist<br/>";
			$Item = "";
				$QI = ""; 
				$QO = "";
				$QC = "";
				$QU = "" ;
				$PB = "";
				$PS = "";
				$C = "";
			mysqli_close($dbc);
			
		}
		
		}
else{
echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);

		}			



?>
<form action="Call_work3.php" method="POST">

<table border="0">
<tr><td><b>Enter the updated values</b></td></tr>
<tr>

	<td>ID</td>
	<td align="center"><input readonly type="text" name="ID" size="30" value = "<?php echo htmlspecialchars($t_ID); ?>"/></td>
</tr>

<tr>
	<td>Worker Name</td>
	<td align="center"><input type="text" name="ITEM" size="30" value="<?php echo htmlspecialchars($Item);?>"/></td>
</tr>

<tr>
	<td>Contact Number</td>
	<td align="center"><input type="text" name="QTY_IN" size="30" value = "<?php echo htmlspecialchars($QI);?>" /></td>
</tr>
<tr>
	<td>Address</td>
	<td align="center"><input type="text" name="QTY_CNST" size="30" value = "<?php echo htmlspecialchars($QO);?>" /></td>
</tr>
<tr>
	<td>Email</td>
	<td align="center"><input type="text" name="QTY_UNIT" size="30" value = "<?php echo htmlspecialchars($QC);?>" /></td>
</tr>
<tr>
	<td>Position</td>
	<td align="center"><input type="text" name="PRICE_BUY" size="30" value = "<?php echo htmlspecialchars($QU);?>" />
<select name = "CAT">
  <option value="OWNER">Owner</option>
  <option value="FINANCE">Finance</option>
  <option value="CUSTOMER_SUPPORT">Customer Suppport</option>
</select></td>
</tr>
<tr>
	<td>Pay</td>
	<td align="center"><input type="text" name="PAY" size="30" value = "<?php echo htmlspecialchars($PS);?>"  />
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
<?php mysqli_close($dbc); ?>
</body>
</html>