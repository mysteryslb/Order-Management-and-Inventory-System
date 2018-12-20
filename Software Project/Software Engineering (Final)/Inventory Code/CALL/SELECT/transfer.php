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
	$data_missing[] = 'ID of Item you want to delete';}
    else{
        $t_ID = trim($_POST['ID']);
    }
	$s= trim($_POST['status']);
	if(empty($data_missing)){
		require_once('mysqli_connect.php');
		$query = "Select * FROM Book WHERE ID =$t_ID";
		$response = @mysqli_query($dbc, $query);
		if ($response){
		$row = mysqli_fetch_array($response);
		if ($row != null){
		$n=$row['NAME'];
		$e=$row['EMAIL'];
		$c=$row['CN'];
		$d=$row['DATE'];
		$query ="DELETE FROM Book WHERE ID =$t_ID";
		$stmt = mysqli_prepare($dbc, $query);
		mysqli_stmt_execute($stmt);
		if (mysqli_affected_rows($dbc)>0)
		{
			echo "</br></br></br>deletetion successful";
			$query ="INSERT INTO customers(ID,Name,EMAIL,CN,DATE,STATUS) VALUES(NULL,?,?,?,?,?)";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "sssss", $n,$e,$c, $d,$s);
			mysqli_stmt_execute($stmt);
		}
		else{
			echo "</br></br></br>Item does not exist";
			
		}}else{
			echo "</br></br></br>Item does not exist";
			
		}}else{
			echo "</br></br></br>Item does not exist";
			
		}
	}
	else{

		require_once('mysqli_connect.php');
	}
	include('Call_Book.php');
}
?> 
</body>
</html>