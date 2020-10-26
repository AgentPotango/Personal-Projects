

          

<!DOCTYPE html>
<html lang="en">
<head>
<?php include 'init.php'; 

$ID = $_SESSION['member_id'];

$getUserInfo = mysql_query("SELECT * FROM csUserInfo WHERE MemberID = $ID");
$getUsername = mysql_query("SELECT * FROM csLogin WHERE MemberID = $ID");
$getStats = mysql_query("SELECT * FROM csBetStats WHERE MemberID = $ID");

$getRecentEvents = mysql_query("SELECT EventID FROM csBetPlaced WHERE MemberID = $ID");

$recentEvents = array();

while($row = mysql_fetch_array($getRecentEvents)){
	echo $row['EventID'];
	$recentEvents[] = $row['EventID'];
}

$resultUserInfo = mysql_fetch_array($getUserInfo);
$resultUsername = mysql_fetch_array($getUsername);
$resultStats = mysql_fetch_array($getStats);


?>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
	<title><?php echo $resultUsername['Username'] . '\'s Profile';?></title>
	
    <link rel="stylesheet" type="text/css" href="style.css" media="all">
    <link rel="stylesheet" type="text/css" href="signupCSS.css" media="all">
    <link rel="stylesheet" type="text/css" href="profile.css" media="all">
    <script type="text/javascript" src="jquery.min.js"></script>
   <script type="text/javascript">
$(document).ready(function () {
$('.active-links').click(function () {
        if ($('#signin-dropdown').is(":visible")) {
            $('#signin-dropdown').hide()
			$('#session').removeClass('active');
        } else {
            $('#signin-dropdown').show()
			$('#session').addClass('active');
        }
		return false;
    });
	$('#signin-dropdown').click(function(e) {
        e.stopPropagation();
    });
    $(document).click(function() {
        $('#signin-dropdown').hide();
		$('#session').removeClass('active');
    });
});     
</script>
 <script type="text/javascript">
$(document).ready(function () {
$('.active-popup').click(function () {
        if ($('#signup-dropdown').is(":visible")) {
            $('#signup-dropdown').hide()
			$('#session').removeClass('active');
        } else {
            $('#signup-dropdown').show()
			$('#session').addClass('active');
        }
		return false;
    });
	$('#signup-dropdown').click(function(e) {
        e.stopPropagation();
    });
    $(document).click(function() {
        $('#signup-dropdown').hide();
		$('#session').removeClass('active');
    });
});     
</script>

</head>

<header>
<?php include 'header.php';
?>

</header>

<body>	
<div id="navigationLogo">

</div>

	
	<div id="profileContainer">
	<div id="content" class="clearfix">
		<section id="left">
			<div id="userStats" class="clearfix">
				<div class="pic">
				<?php 
				
				$image=$resultUserInfo['AvatarLocation'];
  
				echo "<img src='$image'  width='150' height='150' />"
				?>
				</div>
				
				<div class="data">
					<h1><?php echo $resultUsername['Username'];?></h1>
					
					<h3><?php echo '<strong>Country:</strong>' . ' ' . $resultUserInfo['Country'];?></h3>
					<h3><?php echo '<strong>Gender:</strong>' . ' ' . $resultUserInfo['Gender'];?></h3>
					<h3><?php echo '<strong>Join Date:</strong>' . ' ' . $resultUserInfo['JoinDate'];?></h3>
					<div class="socialMediaLinks">
						<a href="http://twitter.com/#" rel="me" target="_blank"><img src="img/twitter.png" alt="?" /></a>
						<a href="http://facebook.com/#" rel="me" target="_blank"><img src="img/facebook.png" /></a>
					</div>
					<div class="sep"></div>
					<ul class="numbers clearfix">
						<li>Bets Won<strong><?php echo $resultStats['BetsWon'];?></strong></li>
						<li>Total Bets<strong><?php echo $resultStats['BetsPlaced'];?></strong></li>
						<li class="nobrdr">Coins Left<strong><?php echo $resultStats['CurrentCoins'];?></strong>
						<!--<li class="nobrdr">Ranking<strong>#127</strong></li>-->
					</ul>
				</div>
			</div>
			
			<h1>Change Settings:</h1>
			<div id="commentOuter" >
				<div id="commentInner" style="height:700px;">
				<div id="changeSettings"> Avatar 
	
	
	
<form enctype="multipart/form-data" action="upload_file.php" method="post">
<input type="hidden" name="MAX_FILE_SIZE" value="10000000000">
<input type="file" name="pix" size="100000">
<br>
<input type="submit" name="upload" value="Upload image"></form></div>


          
          <!-- --------------------------------------------------------------- 
       -->
          


       
       

<!-- Change text based settings -->

				<div id="changeSettings">
				<?php echo'
				
				<form action="update.php" method="post">
				
				    <!--
		<br>
		<label class="Avatar">
                <span>Add Avatar:</span>
                <a href="#"><img src="img/user_avatar.jpg" width="100" height="100" ></a>
                </label>
                                              
               <br>  -->
                     	
     		<label class="Quote">
                <span>Add Quote:</span>
                <textarea id="Quote" name="Quote" value="" type="text" style:"width:200px; height: 150px;"></textarea>
                </label>
                
                <br>
                
                <label class="Email">
                <span>Change Email:</span>
                <input id="Email" name="Email" value="" type="text" autocomplete="on">
                </label>
                
                </br>
                
                <label class="Email2">
                <span>Retype Email:</span>
                <input id="Email2" name="Email2" value="" type="text" autocomplete="off">
                </label>
                
                <br>            
                
                <label class="password">
                <span>Change Password:</span>
                <input id="Password" name="Password" value="" type="password">
                </label>
                <br>  
                <label class="password">
                <span>Retype New Password:</span>
                <input id="Repassword" name="Repassword" value="" type="password">
                </label>
                <br>  
                <span>Change Birthday:</span>
                <select name="Day">
                <option value="">Day</option>';
                 for($day=1;$day<=31;$day++)
                {
                	echo '<option value="'.$day.'">'.$day.'</option>';
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
     		echo '<option value="'.$year.'">'.$year.'</option>';
     	}
     

     echo'</select>
    
     <label></label>
     <br>  
     <span>Change Gender:</span>
    
            <select class="select-style gender" name="Gender">
            <option value="">I Am...</option>
            <option value="Male">Male</option>
            <option value="Female">Female</option>
            <option value="Other">Other</option>
            </select>
          <br>
            <br>
            <label></label>
    	   <span>Change Country:</span>
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
        <br>
          <button class="submit button" input type="submit">Change Settings</button>
        </fiel
        </form> </div>'
        ;?>
				<!--	Username:<br>
						<input type ="text" name="Username">
					
				</ul>
						<input type="submit" value="update">
				</div>
			</div>
			
			<p>
			</p>
			
			
			
			<p>
			</p>-->
		</section>
		
		
		<section id="right">
			<div class="getcontent">
				<div class="head"><h1>My Bet Stats</h1></div>
				<div class="boxy">
					<h1></h1>
					
					<div class="betStats">
					
						<div class="Betlist clearfix">
						<div class="betStat">
						<h1>Accuracy:</h1>
							<span class="format"><a href="#"></a></span>
						</div>
						<div class="betStat">
						<h1><?php 
							$str = $resultStats['Accuracy'];
							$percent = round((float)$str * 100 ) . '%';
						echo $percent;?></h1>
							<span class="format"><a href="#"></a></span>
						</div>
						<div class="betStat">
						<h1>Win Streak:</h1>
							<span class="format"><a href="#"></a></span>
						</div>
						<div class="betStat">
						<h1><?php echo $resultStats['Streak'];?></h1>
							<span class="format"><a href="#"></a></span>
						</div>
						<div class="betStat">
						<h1>Coins Won:</h1>
							<span class="format"><a href="#"></a></span>
						</div>
						<div class="betStat">
						<h1><?php echo $resultStats['CoinsWon'];?></h1>
							<span class="format"><a href="#"></a></span>
						</div>
					</div>
					
					<span><a href="#">See all…</a></span>
				</div>
			</div>
			</div>
			
			<div class="getcontent">
				<div class="head"><h1>Recent Events</h1></div>
				<div class="boxy">
					<?php
					$ids = join(',',$recentEvents);
					
					$getEventName = mysql_query("SELECT EventName, EventID FROM csEvents WHERE EventID IN ($ids) ORDER BY 'EndtD&T' ASC");
					
					$i=0;
					while ($eventName = mysql_fetch_array($getEventName)){
						$i = $i + 1;				
			
 					 echo '<a href="EventPage.php?EventID=' .$eventName['EventID'].'"><h1>'.$eventName['EventName'].'</h1></a>';
 					 echo '<p></p>';
					}
					if ($i == 0){
					echo '<p>Your have no recent events.</p>';
					}
					
					?>
					<div class="friendslist clearfix">
					
						<!--<div class="friend">
							<a href="#"><img src="img/friend_avatar_default.jpg" width="30" height="30" alt="?" /></a><span class="friendly"><a href="#"></a></span>
						</div>
						
						<div class="friend">
							<a href="#"><img src="img/friend_avatar_default.jpg" width="30" height="30" alt="?" /></a><span class="friendly"><a href="#"></a></span>
						</div>
						
						<div class="friend">
							<a href="#"><img src="img/friend_avatar_default.jpg" width="30" height="30" alt="?" /></a><span class="friendly"><a href="#"></a></span>
						</div>
						
						<div class="friend">
							<a href="#"><img src="img/friend_avatar_default.jpg" width="30" height="30" alt="?" /></a><span class="friendly"><a href="#"></a></span>
						</div>
						
						<div class="friend">
							<a href="#"><img src="img/friend_avatar_default.jpg" width="30" height="30" alt="?" /></a><span class="friendly"><a href="#"></a></span>
						</div>
						
						<div class="friend">
							<a href="#"><img src="img/friend_avatar_default.jpg" width="30" height="30" alt="?" /></a><span class="friendly"><a href="#"></a></span>
						</div>-->
					</div>
					
					<span><a href="#">See all...</a></span>
				</div>
			</div>
		</section>
	</div>
</div>

</body>
</html>
