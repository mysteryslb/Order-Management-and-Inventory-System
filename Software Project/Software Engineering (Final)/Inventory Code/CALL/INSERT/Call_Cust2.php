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
    if(empty($_POST['N'])|| ctype_digit($_POST['N'] )){
        $data_missing[] = 'Customer Name';
    } else{
        $tN = trim($_POST['N']);
    }if(empty($_POST['CN'])|| !ctype_digit($_POST['CN'] )){
        $data_missing[] = 'Contact Number';
    } else{
        $tCN = trim($_POST['CN']);
    }if(empty($_POST['E'])){
        $data_missing[] = 'Email';
    } else{
        $tE = trim($_POST['E']);
    }if(empty($_POST['D'])){
        $data_missing[] = 'Date';
    } else{
        $tD = trim($_POST['D']);
    }
	$S = trim($_POST['S']);
	if(empty($data_missing)){
		include('BUTTONc.php');
     	require_once('mysqli_connect.php');
		$es = str_replace(' ', '_', $tE);
			$query ="INSERT INTO customers(ID,NAME,EMAIL,CN,DATE,STATUS) VALUES(NULL,?,?,?,?,?)";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "sssss", $tN,$es, $tCN, $tD,$S);
			mysqli_stmt_execute($stmt);
			echo mysqli_error($dbc);
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
			include ('Call_Cust.php');
			echo "Data Entered Successfully";

		}else{
			include ('Call_Cust.php');
			echo "<br>Enter Valid Data of the following:";
			foreach ($data_missing as $missing)
			{
			echo "<br>$missing";
			}
		}
	
	
}
	?>
</body>
</html>