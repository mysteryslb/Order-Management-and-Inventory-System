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
include('BUTTON.php');
if(isset($_POST['submit'])){
	 $data_missing = array();
    if(empty($_POST['ITEM']) || ctype_digit($_POST['ITEM'] )){
        $data_missing[] = 'Item Name';
    } 
	else{
        $t_ITEM = trim($_POST['ITEM']);
    }
    if(empty($_POST['SC']) || ctype_digit($_POST['SC'] )){
        $data_missing[] = 'Food Type';
    } 
	else{
        $t_SC= trim($_POST['SC']);
    }
    if(empty($_POST['QTY_IN']) || !ctype_digit($_POST['QTY_IN'] )){
        $data_missing[] = 'In Stock';

    } else {
        $t_IN = trim($_POST['QTY_IN']);
    }
    if(empty($_POST['QTY_OUT']) || !ctype_digit($_POST['QTY_OUT'] )){
		$data_missing[] = 'Reference number of needed item';
    } else {
        $t_OUT = trim($_POST['QTY_OUT']);
    }
    if(empty($_POST['QTY_UNIT']) || ctype_digit($_POST['QTY_UNIT'] )){
        $data_missing[] = 'Unit of Item';
    } else {
        $t_UNIT = trim($_POST['QTY_UNIT']);
    }
    if(empty($_POST['PRICE_BUY']) || !ctype_digit($_POST['PRICE_BUY'] )){
        $data_missing[] = 'Price from  supplier';
    } else {
        $t_BUY = trim($_POST['PRICE_BUY']);
    }
	    if(empty($_POST['PRICE_SELL']) || !ctype_digit($_POST['PRICE_SELL'] )){
        $data_missing[] = 'Price to sell';
    } else {
        $t_SELL = trim($_POST['PRICE_SELL']);
    }
    if(empty($_POST['CAT']) || ctype_digit($_POST['CAT'] )){
        $data_missing[] = 'Category';
    } else {
        $t_CAT = trim($_POST['CAT']);
    }
    if(empty($data_missing)){
		$t_CNST = $t_OUT - $t_IN;
     	require_once('mysqli_connect.php');
			$query ="INSERT INTO inventory(ID,ITEM ,QTY_IN,QTY_OUT,QTY_CNST,QTY_UNIT,PRICE_BUY,PRICE_SELL,SC,CAT,DATE) VALUES(NULL,?,?,?,?,?,?,?,?,?,now() )";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "siiisiiss", $t_ITEM,$t_IN,$t_OUT, $t_CNST,$t_UNIT,$t_BUY,$t_SELL,$t_SC,$t_CAT);
			mysqli_stmt_execute($stmt);
			echo "Data Enetered Successfully";
			echo mysqli_error($dbc);
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
				}
	else{
		echo "<b>You need to comply with the following data requirements: <b/><br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing<br/>";
			}
		echo "<br/><b>Enter valid data:<b/><br/>";
		}
							}

?>
<form action="Call_Insert.php" method="POST">

<table border="0">
<tr>
	<td><b>Enter valid data:<b/></td>
</tr>
<tr>
	<td>Item Name</td>
	<td align="center"><input type="text" name="ITEM" size="30" /></td>
</tr>

<tr>
	<td>In Stock</td>
	<td align="center"><input type="text" name="QTY_IN" size="30" /></td>
</tr>
<tr>
	<td>Reference Stock</td>
	<td align="center"><input type="text" name="QTY_OUT" size="30"  /></td>
</tr>
<tr>
	<td>Unit of Item</td>
	<td align="center"><input type="text" name="QTY_UNIT" size="30"  /></td>
</tr>
<tr>
	<td>Price from supplier</td>
	<td align="center"><input type="text" name="PRICE_BUY" size="30"  /></td>
</tr>
<tr>
	<td>Food Type</td>
	<td align="center"><input type="text" name="SC" size="30"  /></td>
</tr>
<tr>
	<td>Category</td>
	<td align="center"><input type="text" name="CAT" size="30" readonly value = "INGR"  /></td>
</tr>

<tr>
<td colspan="2" align="right">
<input type="submit" name="submit" value="Send" />
</td>
</tr>

</table>
</form>
</body>
</html>