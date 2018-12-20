<?php
$dbc = @mysqli_connect(DB_HOST,DB_USER, DB_PASSWORD, DB_NAME)
OR die('Could not connect to MySQL' .mysqli_connect_error());

$table ="CREATE TABLE IF NOT EXISTS `$t_ITEM` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `BUNDLE_ID` int NOT NULL,
  PRIMARY KEY (`ID`)
)";
$stmt = mysqli_prepare($dbc, $table);
mysqli_stmt_execute($stmt);
mysqli_close($dbc);
?>