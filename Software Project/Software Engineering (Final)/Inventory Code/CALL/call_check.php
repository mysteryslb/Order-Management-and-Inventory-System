<?php

if(isset($_POST['submit'])){
	$try = 5;
$hint = 'Password';
	 $data_missing = array();
    if(empty($_POST['name']) || ctype_digit($_POST['name'] )){
        $data_missing[] = 'name';
    } 
	else{
        $tname = trim($_POST['name']);
    }
if(empty($_POST['pass'])){
        $data_missing[] = 'name';
    } 
	else{
        $tpass = trim($_POST['pass']);
    }
	if(empty($data_missing)){
		require_once('mysqli_connect.php');
		$query = "Select * FROM login Where ID = 1";
		$response = @mysqli_query($dbc, $query);
		while($row = mysqli_fetch_array($response)){
		$qname = $row['USER'];
		$qpass = $row['PASS'];}
	if ($tname == $qname && $tpass == $qpass)	{
		$query = "UPDATE login SET PASS ='admin' Where ID = 3";
		$response = mysqli_query($dbc, $query);
		include('Main.php');
	}else{
	$query = "Select * FROM login Where ID = 2";
		$response = @mysqli_query($dbc, $query);
		while($row = mysqli_fetch_array($response)){
		$qname = $row['USER'];
		$qpass = $row['PASS'];}
	if ($tname == $qname && $tpass == $qpass)
	{
	$query = "UPDATE login SET PASS = 'user' Where ID = 3";
		$response = mysqli_query($dbc, $query);
		$check = 1;
		include('Main.php');
	}else{
		$try=$try-1;
		include('login2.php');
	}
	
	}
	
	}
	else{
		$try--;
		include ('login2.php');
	}
	
}
?>