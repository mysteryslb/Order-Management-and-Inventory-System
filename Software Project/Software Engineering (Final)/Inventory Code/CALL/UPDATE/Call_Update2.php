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

		$query ="Select * FROM inventory WHERE ID = $t_ID";
		$response = @mysqli_query($dbc, $query);
		if($response)
		{
			if(mysqli_affected_rows($dbc)>0){
			include('button.php');
			echo '<table align="left"
cellspacing="5" cellpadding="8" borderstyle = "solid" bordercolor = "black" >

			<tr><td align="left"><b>ID</b></td>
<td align="left"><b>ITEM</b></td>
<td align="left"><b>IN STOCK</b></td>
<td align="left"><b>REFERENCE NUMBER</b></td>
<td align="left"><b>STOCK NEEDED</b></td>
<td align="left"><b>STOCK UNIT</b></td>
<td align="left"><b>PRINCIPAL COST</b></td>
<td align="left"><b>PRICE SOLD</b></td>
<td align="left"><b>SUBCATEGORY</b></td></tr>';
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
				$row['SC'] . '</td><td align="left">' ;
				echo '</tr>';
				$Item = $row['ITEM'];
				$QI = $row['QTY_IN']; 
				$QO = $row['QTY_OUT'];
				$QC = $row['QTY_CNST'] ;
				$QU = $row['QTY_UNIT'] ;
				$PB = $row['PRICE_BUY'];
				$PS = $row['PRICE_SELL'];
				$SC = $row['SC'];
				$C = $row['CAT'];
				
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
				$SC = "";
				$C = "";
			mysqli_close($dbc);
			
		}
		
		}
else{
echo "Couldn't issue database query<br />";

echo mysqli_error($dbc);

		}			



?>
<form action="Call_Update3.php" method="POST">

<table border="0">
<tr><td><b>Enter the updated values</b></td></tr>
<tr>

	<td>ID</td>
	<td align="center"><input readonly type="text" name="ID" size="30" value = "<?php echo htmlspecialchars($t_ID); ?>"/></td>
</tr>

<tr>

	<td>Item Name</td>
	<td align="center"><input type="text" name="ITEM" size="30"  value = "<?php echo htmlspecialchars($Item);?>" /></td>
</tr>

<tr>
	<td>In Stock</td>
	<td align="center"><input type="text" name="QTY_IN" size="30" value = "<?php echo htmlspecialchars($QI);?>" /></td>
</tr>

<tr>
	<td>Used Stock</td>
	<td align="center"><input type="text" name="QTY_OUT" size="30" value = "<?php echo htmlspecialchars($QO);?>"   /></td>
</tr>
<tr>
	<td>Constant Stock Needed</td>
	<td align="center"><input type="text" name="QTY_CNST" size="30"	 value = "<?php echo htmlspecialchars($QC);?>"  /></td>
</tr>
<tr>
	<td>Unit of Item</td>
	<td align="center"><input type="text" name="QTY_UNIT" size="30"  value = "<?php echo htmlspecialchars($QU);?>" /></td>
</tr>
<tr>
	<td>Price from supplier</td>
	<td align="center"><input type="text" name="PRICE_BUY" size="30"  value = "<?php echo htmlspecialchars($PB);?>" /></td>
</tr>
<tr>
	<td>Price to be sold</td>
	<td align="center"><input type="text" name="PRICE_SELL" size="30"  value = "<?php echo htmlspecialchars($PS);?>" /></td>
</tr>
<tr>
	<td>SubCategory</td>
	<td align="center"><input type="text" name="SC" size="30"  value = "<?php echo htmlspecialchars($SC);?>" /></td>
</tr>
<tr>
	<td>Category</td>
	<td align="center"><input type="text" name="CAT" size="30" readonly  value = "<?php echo htmlspecialchars($C);?>" /></td>
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