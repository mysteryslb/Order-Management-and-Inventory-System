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

if(isset($_POST['submit'])){require_once('mysqli_connect.php');
	
	 $data_missing = array();
    if(empty($_POST['ITEM'])|| ctype_digit($_POST['ITEM'] )){
        $data_missing[] = 'Item name';
    } 
	else{
        $t_ITEM = trim($_POST['ITEM']);
    }
    if($_POST['QTY_IN'] == Null && $_POST['QTY_IN'] != 0 || !ctype_digit($_POST['QTY_IN'] )){
        $data_missing[] = 'Quantity in stock';

    } else {
        $t_IN = trim($_POST['QTY_IN']);
    }
    if($_POST['QTY_OUT'] == Null && $_POST['QTY_OUT'] != 0 || !ctype_digit($_POST['QTY_OUT'] )){
        $data_missing[] = 'Quantity used in the week';

    } else {
        $t_OUT = trim($_POST['QTY_OUT']);
    }
    if($_POST['QTY_CNST'] == Null && $_POST['QTY_CNST'] != 0 || !ctype_digit($_POST['QTY_CNST'] )){
        $data_missing[] = 'Quantity needed in stock';
    } else {
        $t_CNST = trim($_POST['QTY_CNST']);
    }
    if(empty($_POST['QTY_UNIT'])|| ctype_digit($_POST['QTY_UNIT'] )){
        $data_missing[] = 'Unit of item';
    } else {
        $t_UNIT = trim($_POST['QTY_UNIT']);
    }
    if(empty($_POST['PRICE_BUY'])|| !ctype_digit($_POST['PRICE_BUY'] )){
        $data_missing[] = 'Price from supplier';
    } else {
        $t_BUY = trim($_POST['PRICE_BUY']);
    }
    if(empty($_POST['PRICE_SELL']) && ($_POST['CAT']  != 'TBL')|| !ctype_digit($_POST['PRICE_SELL'] )){
        $data_missing[] = 'Price to sell';
    } else {
        $t_SELL = trim($_POST['PRICE_SELL']);
    }
	  if(empty($_POST['SC'])|| ctype_digit($_POST['SC'] )){
        $data_missing[] = 'SubCategory';
    } else {
        $t_SC = trim($_POST['SC']);
    }
    if(empty($_POST['CAT'])|| ctype_digit($_POST['CAT'] )){
        $data_missing[] = 'Category';
    } else {
        $t_CAT = trim($_POST['CAT']);
    }
	if(empty($_POST['ID'])){
        $data_missing[] = 'ID';
    } else {
        $t_ID = trim($_POST['ID']);
    }
    if(empty($data_missing)){
     	
			$query ="UPDATE inventory SET ITEM = '$t_ITEM' ,QTY_IN = '$t_IN' ,QTY_OUT = '$t_OUT' ,QTY_CNST = '$t_CNST' ,QTY_UNIT = '$t_UNIT' ,PRICE_BUY = '$t_BUY' ,PRICE_SELL = '$t_SELL' ,SC = '$t_SC',CAT = '$t_CAT', DATE = now() WHERE ID = '$t_ID'";
		$response = mysqli_query($dbc, $query);
		if($response)
		{
		
			include ('Call_Update2.php');
				echo "Data Enetered Successfully";
	}
	else{
echo "</br></br></br>Error: Do not leave a blank field<br />";

	}
	
	}
	else{
		echo "</br></br></br>You need to comply with a valid value of the following data requirement/s: <br/>";
		foreach ($data_missing as $missing)
			{
			echo "$missing <br/>";
			}
			include('Call_Update2.php');
		}
							
}

?> 
</body>
</html>