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
          echo "<img src='$image'  width='150' height='150' />";
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
			
			<h1>About Me:</h1>
			<div id="commentOuter" >
				<div id="commentInner">
				
				</div>
			</div>
			
			<p>
			</p>
			
			<h1>Quote:</h1>
			<div id="commentOuter">
				<!--<div id="commentInner">-->
				<div id="quote">
				<p><?php echo $resultUserInfo['Quote'];?></p>
				<p class="align-right"> <?php echo '- ' . $resultUsername['Username'];?></p>
				</div>
				
				<!--</div>-->
			</div>
			
			
			<p>
			</p>
			
			<h1>Comment History:</h1>
			<div id="commentOuter">
				<div class="commentAvatar">
				<!--Default Image = mg/friend_avatar_default.jpg -->
				<?php echo '<a href="#"><img src="' . $image . '" width="50" height="50" alt="?"></a></div>';?>
				
				<div id="commentInner">
				YO THERE
				CHECK OUT MY SICK COMMENT BRO
				JK NOT REALLY
				<p></p>
				</div>
			</div>
			
			<p>
			</p>
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
