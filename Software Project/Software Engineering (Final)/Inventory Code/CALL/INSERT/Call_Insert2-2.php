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
<head>
<title>Add Item</title>
</head>
<body>

<?php

if(isset($_POST['submit'])){
	 $data_missing = array();
    if(empty($_POST['ITEM'])|| ctype_digit($_POST['ITEM'] )){
        $data_missing[] = 'Item Name';
    } 
	else{
        $t_ITEM = trim($_POST['ITEM']);
    }

    if(empty($_POST['QTY_IN']) || !ctype_digit($_POST['QTY_IN'] )){
        $data_missing[] = 'In Stock';

    } else {
        $t_IN = trim($_POST['QTY_IN']);
    }
    if(empty($_POST['QTY_OUT'])|| !ctype_digit($_POST['QTY_OUT'] )){
        $data_missing[] = 'Reference number of needed item';
    } else {
        $t_OUT = trim($_POST['QTY_OUT']);
    }
    if(empty($_POST['QTY_UNIT']) || ctype_digit($_POST['QTY_UNIT'] )){
        $data_missing[] = 'Unit of Item';
    } else {
        $t_UNIT = trim($_POST['QTY_UNIT']);
    }
    if(empty($_POST['PRICE_BUY'])|| !ctype_digit($_POST['PRICE_BUY'] )){
        $data_missing[] = 'Price from  supplier';
    } else {
        $t_BUY = trim($_POST['PRICE_BUY']);
    }
    if(empty($_POST['PRICE_SELL'])|| !ctype_digit($_POST['PRICE_SELL'] )){
        $data_missing[] = 'Price to sell/for rent';
    }else {
        $t_SELL = trim($_POST['PRICE_SELL']);
    }
    if(empty($_POST['CAT'])|| ctype_digit($_POST['CAT'] )){
        $data_missing[] = 'Category';
    } else {
        $t_CAT = trim($_POST['CAT']);
    }
	  if(empty($_POST['SC'])|| ctype_digit($_POST['SC'] )){
        $data_missing[] = 'SubCategory';
    } else {
        $t_SC = trim($_POST['SC']);
    }
    if(empty($data_missing)){
		include('BUTTON.php');
		$t_CNST = $t_OUT - $t_IN;
     	require_once('mysqli_connect.php');
			$query ="INSERT INTO inventory(ID,ITEM ,QTY_IN,QTY_OUT,QTY_CNST,QTY_UNIT,PRICE_BUY,PRICE_SELL,SC,CAT,DATE) VALUES(NULL,?,?,?,?,?,?,?,?,?,now() )";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "siiisiiss", $t_ITEM,$t_IN,$t_OUT, $t_CNST,$t_UNIT,$t_BUY,$t_SELL,$t_SC,$t_CAT);
			mysqli_stmt_execute($stmt);
			echo "Data Enetered Successfully";
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
				}
	else{
			echo "<br/><br/><br/><b>You need to comply with the following data requirements: <b/><br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing<br/>";
			}
		include ('Call_Insert2.php');
		}
							}

?>
</body>
</html>