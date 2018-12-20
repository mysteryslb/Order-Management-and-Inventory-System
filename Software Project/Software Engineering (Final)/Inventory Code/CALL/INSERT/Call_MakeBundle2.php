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
<?php include('button.php')?>
<?php
if(isset($_POST['submit'])){
		require_once('mysqli_connect.php');
	 $data_missing = array();
    if(empty($_POST['INGR'])|| !ctype_digit($_POST['INGR'] )){
        $data_missing[] = 'Menu ID';
    } 
	else{
        $t_INGR = trim($_POST['INGR']);
    }
	if(empty($_POST['ITEM'])){
        $data_missing[] = 'ITEM';
    } 
	else{
        $t_ITEM = trim($_POST['ITEM']);
    }
    if(empty($data_missing)){$query = "Select * FROM inventory  WHERE ID = $t_INGR ORDER BY ID";
			$response = @mysqli_query($dbc, $query);
			$row = mysqli_fetch_array($response);
	if(mysqli_num_rows($response) >0 && $row['CAT'] == 'MENU'){
			$t_ITEMS =  str_replace(' ', '_', $t_ITEM);
			$query = "INSERT INTO $t_ITEMS(ID,INGR_ID) VALUES(NULL,?)";
			$stmt = mysqli_prepare($dbc, $query)or die(mysqli_error($dbc));
			mysqli_stmt_bind_param($stmt, 's', $t_INGR);
			mysqli_stmt_execute($stmt);
			echo "Data Enetered Successfully";
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
	}else
{
echo "<b>Enter valid ID of the Item you want to add </b><br/>";
}
	}
	else{
		echo "<br/><br/><br/><b>You need to comply with the following data requirements:</b> <br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing <br/>";
			}
		}
							}

?>
<form action="Call_MakeBundle2.php" method="POST">

<table border="0">
<td><b>Enter valid data:</b></td>
<tr>
	<td>For Bundle:</td>
	<td align="center"><input type="text" name="ITEM" size="30" readonly value = "<?php echo htmlspecialchars($t_ITEM);?>" /></td>
</tr> 
<tr>
	<td>Menu ID</td>
	<td align="center"><input type="text" name="INGR" size="30" /></td>
</tr> 

<tr>
<td colspan="2" align="right">
<input type="submit" name="submit" value="Send" />
</td>
</tr>

</table>
</form>
<?php include ('Call_Menu.php');?>
</body>
</html>