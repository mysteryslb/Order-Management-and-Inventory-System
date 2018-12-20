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
	if(empty($data_missing)){
		require_once('mysqli_connect.php');
		$query ="DELETE FROM feedback WHERE ID =$t_ID";
		$stmt = mysqli_prepare($dbc, $query);
		mysqli_stmt_execute($stmt);
		if (mysqli_affected_rows($dbc)>0)
		{
			include('buttonc.php');
			echo "deletetion successful<br/>";
			include('call_feedback4.php');
		}
		else{
			include('buttonc.php');
			echo "Item does not exist<br/>";
			include('call_feedback4.php');
		}
	}
	else{
		include('call_feedback1.php');
	}
	
	
}
?> 
</body>
</html>