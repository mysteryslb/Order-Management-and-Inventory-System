<!DOCTYPE html>
<html>
<head>
	    <meta charset="UTF-8"></meta>
        <meta name="viewport" content="width=device-width, initial-scale=1"></meta>
        <title>J&J KITCHEN CATERING COMPANY</title>
        <link rel="shortcut icon" href="1.2.jpg">
	<link href="https://fonts.googleapis.com/css?family=Fjalla+One">
	<link rel="stylesheet" type="text/css" href="login.css">
<title>J&J's Catering Company</title>

</head>
<body>
<div class="container">  
  <form id="contact" action="call_check2.php" method="POST">
  <h4>Wrong Username/Password! Number of tries: <?php echo htmlspecialchars($try);?></h4>
    <fieldset>
      <input placeholder="Username" type="text" name="name"  tabindex="1" autofocus>
      <span class="error"></span>
    </fieldset>
    <fieldset>
      <input placeholder="<?php echo htmlspecialchars($hint);?>" type="text" name="pass" tabindex="2">
      <span class="error"></span>
    </fieldset>
	<fieldset>
      <input value="<?php echo htmlspecialchars($try);?>" type="hidden" name="try" tabindex="2">
      <span class="error"></span>
    </fieldset>
    <fieldset>
      <button name="submit" type="submit" id="POST">Login</button>
    </fieldset>
    <div class="success"></div>
  </form>
</div>
</body>
</html>