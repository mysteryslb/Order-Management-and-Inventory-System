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
    if(empty($_POST['ID'])|| !ctype_digit($_POST['ID'] )){
	$data_missing[] = 'ID';}
    else{
        $t_ID = trim($_POST['ID']);
    }
if(empty($data_missing)){
			include ('mysqli_connect.php');
			$nquery = "Select * FROM workers WHERE ID = $t_ID ORDER BY ID";
			$nresponse = @mysqli_query($dbc, $nquery);
		if(mysqli_num_rows($nresponse) >0){
			include('Call_work2.php');
		}else{
		mysqli_close($dbc);

		include ('Call_work4.php');
	}	
		}
	else{

		include ('Call_work.php');
	}	
}

?>

</body>
</html>