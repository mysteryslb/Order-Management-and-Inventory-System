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
	$data_missing[] = 'ID of Worker you want to delete';}
    else{
        $t_ID = trim($_POST['ID']);
    }
	if(empty($data_missing)){
		require_once('mysqli_connect.php');
		$query ="DELETE FROM workers WHERE ID =$t_ID";
		$stmt = mysqli_prepare($dbc, $query);
		mysqli_stmt_execute($stmt);
		if (mysqli_affected_rows($dbc)>0)
		{
			echo "</br></br></br>Deletetion Successful";
			mysqli_close($dbc);
		}
		else{
			echo "</br></br></br>Worker does not exist";
			mysqli_close($dbc);
		}
	}
	else{
		require_once('mysqli_connect.php');
	}
}
?> 
<?php include ('buttonp.php');
echo "Enter ID of worker you want deleted in the database:<br/>";
?>
<form action="Call_work1.php" method="POST">

<table border="0">
<tr>
	<td>Worker ID</td>
	<td align="center"><input type="text" name="ID" size="30" /></td>
</tr>

<tr>
<td colspan="2" align="right">
<input type="submit" name="submit" value="Send" />
</td>
</tr>

</table>
</form>
<?php include('Call_Workers2.php');?>
</body>
</html>