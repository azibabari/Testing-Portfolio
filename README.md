# Basic-Html
This is a basic html webpage
<!doctype html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Easy Thor</title>
	<style>
body {
  margin: 0;
  font-family: Arial, Helvetica, sans-serif;
}

.topnav {
  overflow: hidden;
  
}

.topnav a {
  float: left;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

.topnav a:hover {
  background-color: #ddd;
  color: black;
}

.topnav a.active {
  
  color: white;
}

img {
  display: block;
  margin-left: auto;
  margin-right: auto;
  border-radius: 30%;
}

* {
  box-sizing: border-box;
}

.column {
  float: left;
  width: 33.33%;
  padding: 10px;
  height: 400px;
}

.row:after {
  content: "";
  display: table;
  clear: both;
}
@media screen and (max-width: 600px) {
  .column {
    width: 100%;
  }
}
	.inset {border-style: inset;}
	.outset {border-style: outset;}
</style>
</head>

<body bgcolor="#F8F0E3">
	<h1 style="font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, 'sans-serif';color: #808080" > THOR NETWORKS <div class="topnav" align="right" >
  <a class="active" href="#home" style="color:#808080 ">Home</a>
  <a href="#news" style="color:#808080 ">News</a>
  <a href="#contact"style="color:#808080 ">Contact</a>
  <a href="#about"style="color:#808080 ">About</a>
</div></h1>

<img src= "networking.jpg" class= "center"  height= "250" style="width:30%;"/>

<div class="row">
  <div class="column inset" style="background-color:#87CEEB;" >
    <h2>Background and History </h2>
    <p>Thor Networks was found in 2022 by Azibabari, a Topcoder Member and QA Engineer. Some months ago, Azibabari graduated as a Computer Technologist from Babcock University. <br>
	<br>Azibabari got interested in e-commerce networking and decided to bring a wide range of companies together to sell their products on the Thor Networks website. The name 'Thor' sprung up from a Topcoder skillbuilder challenge.</p>
  </div>
  <div class="column inset" style="background-color:#87CEEB;">
    <h2>Services</h2>
    <p> <b>We offer: </b>
	<ul>
  <li>Patnership with Big Business companies</li>
  <li>Virtual shops for small business owners</li>
  <li>Wholesale sales to consumers</li>
  <li> Retail sales to consumers</li>
</ul>>
 </p>
  </div>
  <div class="column inset" style="background-color:#87CEEB;">
    <h2>Contact Us </h2>
    <<form action="/action_page.php">
  <label for="fname">First name:</label><br>
  <input type="text" id="fname" name="fname" ><br>
  <label for="lname">Last name:</label><br>
  <input type="text" id="lname" name="lname" ><br>
  <label for="email">Email:</label><br>
  <input type="text" id="emal" name="email" ><br>
  <label for="comment">Enquiry:</label><br>
  <textarea rows="4" cols="50" name="comment" >
Tell us what's on your mind...</textarea>
  <input type="submit" value="Submit">
</form> 
  </div>
</div>
</body>
</html>
