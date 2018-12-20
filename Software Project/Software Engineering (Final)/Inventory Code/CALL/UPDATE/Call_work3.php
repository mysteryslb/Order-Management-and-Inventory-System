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

if(isset($_POST['submit'])){require_once('mysqli_connect.php');
	
	 $data_missing = array();
	 $t_ID = trim ($_POST['ID']);
   if(empty($_POST['ITEM']) || ctype_digit($_POST['ITEM'] )){
        $data_missing[] = 'Worker Name';
    } 
	else{
        $t_ITEM = trim($_POST['ITEM']);
    }

    if(empty($_POST['QTY_IN']) || !ctype_digit($_POST['QTY_IN'] )){
        $data_missing[] = 'Contact Number';

    } else {
        $t_IN = trim($_POST['QTY_IN']);
    }
    if(empty($_POST['QTY_CNST'])){
        $data_missing[] = 'Address of worker';
    } else {
        $t_CNST = trim($_POST['QTY_CNST']);
    }
    if(empty($_POST['QTY_UNIT'])){
        $data_missing[] = 'Email Address';
    } else {
        $t_UNIT = trim($_POST['QTY_UNIT']);
    }
    if(empty($_POST['PRICE_BUY']) || ctype_digit($_POST['PRICE_BUY'] )){
        $data_missing[] = 'Company Position';
    } else {
        $t_BUY = trim($_POST['PRICE_BUY']);
    }
        $t_CAT = trim($_POST['CAT']);
	    if(empty($_POST['PAY']) || !ctype_digit($_POST['PAY'] )){
        $data_missing[] = 'Amount to be paid';
    } else {
        $t_PAY = trim($_POST['PAY']);
    }
        $t_PAYC = trim($_POST['PAYC']);
    if(empty($data_missing)){
			$query ="UPDATE workers SET NAME = '$t_ITEM' ,CN = '$t_IN' ,ADDR = '$t_CNST' ,EMAIL = '$t_UNIT' ,COMPANY_POSITION = '$t_BUY' ,DEPARTMENT = '$t_CAT' ,PAY = '$t_PAY' ,PAYC = '$t_PAYC' WHERE ID = '$t_ID'";
		$response = mysqli_query($dbc, $query);
		if($response)
		{

			include ('Call_work2.php');
			echo "Data Enetered Successfully";
	}
	else{
echo " <br/> <br/> <br/>Error:Please enter valid inputs<br />";
include('Call_work2.php');
	}
	
	}
	else{
		echo "You need to comply with a valid value of the following data requirement/s: <br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing <br/>";
			}
			include('Call_work2.php');
		}
							
}

?> 
</body>
</html>