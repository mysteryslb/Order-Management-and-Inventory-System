<html>
<head>
<title>Add Item</title>
</head>
<body>
<?php
if(isset($_POST['submit'])){
	 $data_missing = array();
	 if(ctype_digit($_POST['name'])){
		 $data_missing[] = 'name';
	 }
	 else{
    if(empty($_POST['name'])){
$data_missing[] = 'name';
    } 
	else{
        $t_name = trim($_POST['name']);
	 }}

    if(empty($_POST['email'])){
        $data_missing[] = 'email';
    } else {
        $t_email = trim($_POST['email']);
    }
	if(!ctype_digit($_POST['phone'] ) || empty($_POST['phone'])){
		$data_missing[] = 'Phone number';
	}else{
        $t_phone = trim($_POST['phone']);
    }
	
	if(empty($_POST['date']) ){
		 $data_missing[] = 'Invalid Date';
	}else{
		$tdate = trim($_POST['date']);
	}
	
	
	
    if(empty($data_missing)){
     	require_once('mysqli_connect.php');
			$query ="INSERT INTO Book(ID,NAME,EMAIL,CN,DATE,STATUS) VALUES(NULL,?,?,?,?,'ongoing')";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "ssss", $t_name,$t_email,$t_phone, $tdate);
			mysqli_stmt_execute($stmt);
			echo mysqli_error($dbc);
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
			$mes = 'Booking successfully sent';
			include ('book.html');
				}
	else{
		$mes = 'Invalid field detected';
		include ('book.html');
		}
							}
?>
</table>
</form>
</body>
</html>