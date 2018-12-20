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
        $t_name = 'Anon';
    } 
	else{
        $t_name = trim($_POST['name']);
	 }}

    if(empty($_POST['email'])){
        $t_email = 'Anon';

    } else {
        $t_email = trim($_POST['email']);
    }
	if(!ctype_digit($_POST['phone'] ) && !empty($_POST['phone'])){
		$data_missing[] = 'Phone number';
	}else{
    if(empty($_POST['phone'])){
		   $t_phone = 0;
    }else {
        $t_phone = trim($_POST['phone']);
    }}
    if(empty($_POST['message'])){
        $data_missing[] = 'Enter your message';
    } else {
        $t_message = trim($_POST['message']);
    }
	$t_date = date("Y/m/d");
    if(empty($data_missing)){
     	require_once('mysqli_connect.php');
			$query ="INSERT INTO feedback(ID,Name,Email,Phone,Mes,Date) VALUES(NULL,?,?,?,?,?)";
			$stmt = mysqli_prepare($dbc, $query);
			mysqli_stmt_bind_param($stmt, "sssss", $t_name,$t_email,$t_phone, $t_message,$t_date);
			mysqli_stmt_execute($stmt);
			echo mysqli_error($dbc);
			mysqli_stmt_close ($stmt);
			mysqli_close($dbc);
			$mes = 'Feedback successfully sent';
			include ('feed.php');
				}
	else{
		$mes = 'Please fill in your message';
		include ('feed.php');
		}
							}
							
?>
</table>
</form>
</body>
</html>