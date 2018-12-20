<!DOCTYPE html>
<html>
<head>
<title>J&J's Catering Company</title>
<?php
DEFINE ('DB_USER','admin');
DEFINE ('DB_PASSWORD','new_password');
DEFINE ('DB_HOST','localhost');
DEFINE ('DB_NAME','inventory');

$dbc = @mysqli_connect(DB_HOST,DB_USER, DB_PASSWORD, DB_NAME)
OR die('Could not connect to MySQL' .mysqli_connect_error());

?>
</body>
</html>