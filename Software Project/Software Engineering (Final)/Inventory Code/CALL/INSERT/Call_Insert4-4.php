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

if(isset($_POST['submit'])){
	 $data_missing = array();
    if(empty($_POST['ITEM'])|| ctype_digit($_POST['ITEM'] )){
        $data_missing[] = 'Item Name';
    } 
	else{
        $t_ITEM = trim($_POST['ITEM']);
    }
        $t_IN = 1;
        $t_OUT = 1;
        $t_CNST = 1;
	 if(empty($_POST['UNIT'])|| ctype_digit($_POST['UNIT'] )){
        $data_missing[] = 'Event';
    } 
	else{
        $t_UNIT= trim($_POST['UNIT']);
    }
     if(empty($_POST['BUY'])|| !ctype_digit($_POST['BUY'] )){
         $data_missing[] = 'Principal Cost';
    }else {
        $t_BUY = trim($_POST['BUY']);
    }
    if(empty($_POST['PRICE_SELL'])|| !ctype_digit($_POST['PRICE_SELL'] )){
         $data_missing[] = 'Price to sell';
    }else {
        $t_SELL = trim($_POST['PRICE_SELL']);
    }
    if(empty($_POST['CAT'])|| ctype_digit($_POST['CAT'] )){
        $data_missing[] = 'Category';
    } else {
        $t_CAT = trim($_POST['CAT']);
    }
    if(empty($data_missing)){
		include('BUTTON.php');
		$t_SC = 'n/a';
     		require_once('mysqli_connect.php');
			$query ="INSERT INTO inventory(ID,ITEM ,QTY_IN,QTY_OUT,QTY_CNST,QTY_UNIT,PRICE_BUY,PRICE_SELL,SC,CAT,DATE) VALUES(NULL,?,?,?,?,?,?,?,?,?,now() )";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "siiisiiss", $t_ITEM,$t_IN,$t_OUT, $t_CNST,$t_UNIT,$t_BUY,$t_SELL,$t_SC,$t_CAT);
			mysqli_stmt_execute($stmt);
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
			include ('../Create/Call_MakeMenu.php');
			echo "Bundle Created";
			include ('Call_MakeBundle.php');
			include ('Call_Menu.php');
			
				}
	else{
			echo "<br/><br/><br/><b>You need to comply with the following data requirements: <b/><br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing<br/>";
			}
			include ('Call_Insert4.php');
		}
							}
?>
</body>
</html>