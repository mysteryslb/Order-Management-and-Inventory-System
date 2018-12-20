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
     	require_once('mysqli_connect.php');
			$query ="INSERT INTO workers(ID,NAME,CN,ADDR,EMAIL,COMPANY_POSITION,DEPARTMENT,PAY,PAYC) VALUES(NULL,?,?,?,?,?,?,?,?)";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "ssssssis", $t_ITEM,$t_IN,$t_CNST, $t_UNIT,$t_BUY,$t_CAT,$t_PAY,$t_PAYC);
			mysqli_stmt_execute($stmt);
			include('Call_work.php');
			echo "Data Enetered Successfully";
			echo mysqli_error($dbc);
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
				}
	else{
		include('Call_work.php');
		echo "<b>You need to comply with the following data requirements: <b/><br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing<br/>";
			}
		}
		
		
							}

?>
</body>
</html>