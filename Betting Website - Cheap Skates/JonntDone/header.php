<?php
echo'

<div id="top-stuff">
	<div id="top-bar-out">
    	<div id="container">
    	<div id="navigationgap">
      	<div id="navigationbutton">
         <a href="Homepage.php"><strong>Home page</strong></a>
         </div>
         <div id="navigationbutton">
 <a href="Events.php"><strong>Events</strong></a>
   </div>
   <div id="navigationbutton">
 <a href="LeagueTable2.php"><strong>LeaderBoard</strong></a>
 </div>
 
 <div id="navigationbutton">
 <a href="Categories.php"><strong>Events</strong></a>
 </div>';
 
 $MyProfile="Profile.php?id=".$_SESSION['member_id'];
 if (isset($_SESSION['member_id'])) {
 echo '
 
 <div id="navigationbutton">
 <a href="createEvent.php"><strong>Create Event</strong></a>
 </div>
 
  <div id="navigationbutton">
 <a href="MyBets.php"><strong>My Bets</strong></a>
 </div>';
 
 //PROFILE LINK
 
 echo "
 
  <div id='navigationbutton'>
 <a href='$MyProfile'><strong>My Profile</strong></a>
 </div> ";
 
 echo '
 
  <div id="navigationbutton">
 <a href="BettingHistory.php"><strong>Bet History</strong></a>
 </div>
 
 <div id="navigationbutton">
 <a href="Settings.php"><strong>Settings</strong></a>
 </div>';
 }
 
 
 
 echo'<div id="navigationbutton">
 <a href="Search.php"><strong>Search</strong></a>
 </div>
 

 </div>
    	<div id="topnav">';
    	if (!isset($_SESSION['member_id'])){
echo'
    	<div class="active-popup">
    	<div id="session">	
    	<a id="signin-link" href="#" >
            <em>Don\'t Have an account?</em>
            <strong>Sign Up!</strong>
        </a> 
        </div>
        
        <div id="signup-dropdown">
        	
                <form method="post" class="signin" action="register.php">
                <fieldset class="textbox">
            	<label class="username">
                <span>Username</span>
                <input id="Username" name="Username" value="" type="text" autocomplete="on">
                </label>
                
                <label class="Email">
                <span>Email</span>
                <input id="Email" name="Email" value="" type="text" autocomplete="on">
                </label>
                            
                
                <label class="password">
                <span>Password</span>
                <input id="Password" name="Password" value="" type="password">
                </label>
                <label class="password">
                <span>Retype your Password</span>
                <input id="Repassword" name="Repassword" value="" type="password">
                </label>
                
                <span>Birthday:</span>
                <select name="Day">
                <option value="">Day</option>';
                 for($day=1;$day<=31;$day++)
                {
                	echo '<option value= '.$day.'>'.$day.'</option>';
                }
                
		
		
   	 echo' </select>

     <select name="Month">
     	<option value="">Month</option>
     	
	<option value="1">January</option>
	<option value="2">February</option>
	<option value="3">March</option>
	<option value="4">April</option>
	<option value="5">May</option>
	<option value="6">June</option>
	<option value="7">July</option>
	<option value="8">August</option>
	<option value="9">September</option>
	<option value="10">October</option>
	<option value="11">November</option>
	<option value="12">December</option>
     </select>
	
     <select name="Year">
     	<option value="">Year</option>';
     	for($year=1900;$year<=2003;$year++)
     	{
     		echo '<option value= '.$year.'>'.$year.'</option>';
     	}
     

     echo'</select>
    
     <label></label>
     <span>Gender:</span>
    
            <select class="select-style gender" name="Gender">
            <option value="select">I Am..</option>
            <option value="Male">Male</option>
            <option value="Female">Female</option>
            <option value="other">Other</option>
            </select>
            
            <label></label>
    	   <span>Select Country:</span>
            <select name="Country">
     	    <option value="">Select Country</option>
            ';
        
 $country_list = array(
		"Afghanistan",
		"Albania",
		"Algeria",
		"Andorra",
		"Angola",
		"Antigua and Barbuda",
		"Argentina",
		"Armenia",
		"Australia",
		"Austria",
		"Azerbaijan",
		"Bahamas",
		"Bahrain",
		"Bangladesh",
		"Barbados",
		"Belarus",
		"Belgium",
		"Belize",
		"Benin",
		"Bhutan",
		"Bolivia",
		"Bosnia and Herzegovina",
		"Botswana",
		"Brazil",
		"Brunei",
		"Bulgaria",
		"Burkina Faso",
		"Burundi",
		"Cambodia",
		"Cameroon",
		"Canada",
		"Cape Verde",
		"Central African Republic",
		"Chad",
		"Chile",
		"China",
		"Colombi",
		"Comoros",
		"Congo (Brazzaville)",
		"Congo",
		"Costa Rica",
		"Cote d'Ivoire",
		"Croatia",
		"Cuba",
		"Cyprus",
		"Czech Republic",
		"Denmark",
		"Djibouti",
		"Dominica",
		"Dominican Republic",
		"East Timor (Timor Timur)",
		"Ecuador",
		"Egypt",
		"El Salvador",
		"Equatorial Guinea",
		"Eritrea",
		"Estonia",
		"Ethiopia",
		"Fiji",
		"Finland",
		"France",
		"Gabon",
		"Gambia, The",
		"Georgia",
		"Germany",
		"Ghana",
		"Greece",
		"Grenada",
		"Guatemala",
		"Guinea",
		"Guinea-Bissau",
		"Guyana",
		"Haiti",
		"Honduras",
		"Hungary",
		"Iceland",
		"India",
		"Indonesia",
		"Iran",
		"Iraq",
		"Ireland",
		"Israel",
		"Italy",
		"Jamaica",
		"Japan",
		"Jordan",
		"Kazakhstan",
		"Kenya",
		"Kiribati",
		"Korea, North",
		"Korea, South",
		"Kuwait",
		"Kyrgyzstan",
		"Laos",
		"Latvia",
		"Lebanon",
		"Lesotho",
		"Liberia",
		"Libya",
		"Liechtenstein",
		"Lithuania",
		"Luxembourg",
		"Macedonia",
		"Madagascar",
		"Malawi",
		"Malaysia",
		"Maldives",
		"Mali",
		"Malta",
		"Marshall Islands",
		"Mauritania",
		"Mauritius",
		"Mexico",
		"Micronesia",
		"Moldova",
		"Monaco",
		"Mongolia",
		"Morocco",
		"Mozambique",
		"Myanmar",
		"Namibia",
		"Nauru",
		"Nepal",
		"Netherlands",
		"New Zealand",
		"Nicaragua",
		"Niger",
		"Nigeria",
		"Norway",
		"Oman",
		"Pakistan",
		"Palau",
		"Panama",
		"Papua New Guinea",
		"Paraguay",
		"Peru",
		"Philippines",
		"Poland",
		"Portugal",
		"Qatar",
		"Romania",
		"Russia",
		"Rwanda",
		"Saint Kitts and Nevis",
		"Saint Lucia",
		"Saint Vincent",
		"Samoa",
		"San Marino",
		"Sao Tome and Principe",
		"Saudi Arabia",
		"Senegal",
		"Serbia and Montenegro",
		"Seychelles",
		"Sierra Leone",
		"Singapore",
		"Slovakia",
		"Slovenia",
		"Solomon Islands",
		"Somalia",
		"South Africa",
		"Spain",
		"Sri Lanka",
		"Sudan",
		"Suriname",
		"Swaziland",
		"Sweden",
		"Switzerland",
		"Syria",
		"Taiwan",
		"Tajikistan",
		"Tanzania",
		"Thailand",
		"Togo",
		"Tonga",
		"Trinidad and Tobago",
		"Tunisia",
		"Turkey",
		"Turkmenistan",
		"Tuvalu",
		"Uganda",
		"Ukraine",
		"United Arab Emirates",
		"United Kingdom",
		"United States",
		"Uruguay",
		"Uzbekistan",
		"Vanuatu",
		"Vatican City",
		"Venezuela",
		"Vietnam",
		"Yemen",
		"Zambia",
		"Zimbabwe");
	foreach($country_list as $key=>$value)
	{
		
 	 echo '<option value="' . $value . '">' . $value . '</option>';
	}
	
     	echo '</select>
     
        <fieldset class="remb">
          <button class="submit button" input type="submit">Sign Up</button>
        </fieldset>
             
                
          </form>
         </div>
         </div>

      	<div class="active-links">
    	
        
            <div id="session">
            <a id="signin-link" href="#">
            <em>Have an account?</em>
            <strong>Sign in</strong>
            </a>
            </div>
            	<div id="signin-dropdown">
        	
                <form method="post" class="signin" action="login.php">
                <fieldset class="textbox">
            	<label class="username">
                <span>Username</span>
                <input id="Username" name="Username" value="" type="text" autocomplete="on">
                </label>
                
                <label class="password">
                <span>Password</span>
                <input id="Password" name="Password" value="" type="password">
                </label>
                </fieldset>
                
                <fieldset class="remb">
                <label class="remember">
                <input type="checkbox" value="1" name="remember_me" />
                <span>Remember me</span>
                </label>
                <button class="submit button" input type="submit">Sign in</button>
                </fieldset>
                <p>
                <a class="forgot" href="#">Forgot your password</a>
                </p>
                </form>
         	</div>
                </div>
             </div>
    	</div>
    </div>
</div>';
}
else{
echo '
<div id="session">	
    	<a id="signin-link" href="logout.php" >
            <em>Don\'t leave...</em>
            <strong>Log Out</strong>
        </a> 
        </div>
<div id="session">
            <a id="signin-link" href="#">
            <em>Welcome back</em>
            <strong>'. $_SESSION["username"] .'</strong>
            </a>
            </div>';
}
?>

