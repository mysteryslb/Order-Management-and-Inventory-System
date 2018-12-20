<!DOCTYPE html>
<html>
<div class="container">  
  <form id="contact" action="call_feedback.php" method="POST">
    <h3>Contact</h3>
    <h4>Contact us today, and get reply with in 24 hours!</h4>
	<h4><?php echo htmlspecialchars($mes);?></h4>
    <fieldset>
      <input placeholder="Your name" type="text" name="name"  tabindex="1" autofocus>
      <span class="error"></span>
    </fieldset>
    <fieldset>
      <input placeholder="Your Email Address" type="text" name="email" tabindex="2">
      <span class="error"></span>
    </fieldset>
    <fieldset>
      <input placeholder="Your Phone Number" type="text" name="phone" tabindex="3">
      <span class="error"></span>
    </fieldset>
    <fieldset>
      <textarea name="message"  value = <?php echo htmlspecialchars($t_message);?>>
      </textarea>
    </fieldset>
    <fieldset>
      <button name="submit" type="submit" id="contact-submit" data-submit="...Sending">Submit</button>
    </fieldset>
    <div class="success"></div>
  </form>
</div>
    <head>
        <meta charset="UTF-8"></meta>
        <meta name="viewport" content="width=device-width, initial-scale=1"></meta>
        <title>J&J KITCHEN CATERING COMPANY</title>
        <link rel="stylesheet" type="text/css" href="feed.css">
        <link rel="shortcut icon" href="1.2.jpg">
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Amatic+SC|Sedgwick+Ave">
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lobster|Poppins">
        <link rel="stylesheet" href=https://fonts.googleapis.com/css?family=Open+Sans>
    </head>  
    <body>
        <div class="selector">
           <div class="bar">
                <br></br>

                <a href="J&JKCC.html"><button id="btnhome">Home</button></a>
                <a href="events.html"><button id="btneven">Events</button></button></a>
                <a href="about.html"><button id="btnabou">About us</button></a>
                <a href="products.html"><button id="btnprod">Products and Offers</button></button></a>
                <a href="book.html"><button id="btnbook">Book and Order</button></button></a>
                <a href="feed.html"><button id="btnfeed">Feedback</button></button></a>
            </div>
    </body>
</html>