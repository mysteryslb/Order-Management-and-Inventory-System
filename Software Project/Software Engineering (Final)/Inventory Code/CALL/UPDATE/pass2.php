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
<body>
<?php
if(isset($_POST['submit'])){
		$pick = trim($_POST['option']);
	 $data_missing = array();
    if(empty($_POST['old'])){
	$data_missing[] = 'ID';}
    else{
        $told = trim($_POST['old']);
    }    if(empty($_POST['new'])){
	$data_missing[] = 'ID';}
    else{
        $tnew = trim($_POST['new']);
    }
	 if(empty($_POST['hint'])){
	$data_missing[] = 'ID';}
    else{
        $thint = trim($_POST['hint']);
    }
if(empty($data_missing)){
			include ('mysqli_connect.php');
			$query = "Select * FROM login  WHERE USER = '$pick'";
			$response = @mysqli_query($dbc, $query);
			$row = mysqli_fetch_array($response);
			$current = $row['ID'];
			$query = "Select * FROM login  WHERE ID = '$current'";
			$response = @mysqli_query($dbc, $query);
			$row = mysqli_fetch_array($response);
			$cpass = $row['PASS'];
			if ($cpass == $told){
				$query = "UPDATE login SET PASS = '$tnew' WHERE ID = '$current'";
				$response = mysqli_query($dbc, $query);
				$query = "UPDATE Hints SET HINT = '$thint' WHERE ID = '$current'";
				$response = mysqli_query($dbc, $query);
			include ('pass.php');
		echo "Successfully updated password for $pick!";
				
			}else{
		include ('pass.php');
		echo "Error please input correct old password!";
			}
		
		mysqli_close($dbc);
		}
	else{
		include ('pass.php');
		echo "Error please input valid inputs!";
	}	
}

?>

</body>
</html>