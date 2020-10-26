import im
import random
import time
import sys

server = im.IMServerProxy('http://potnoodle.cs.man.ac.uk/~hussaim2/IMServer.php')

user = 'User1'
talkingTo = 'User2'
messaging = True
previousMessage
if server[user] == "":
 server[user] = 'connected'
else:
 user = 'User2'
 talkingTo = 'User1'
 server[user] = 'connected'
 
while messaging == True:
  if server[talkingTo + 'm'] != "":
    print talkingTo + " says: " + server[talkingTo + 'm']
  time.sleep(2) 
  myMessage = raw_input('Message to send to ' + talkingTo + ' : ')
  server[user + 'm'] = myMessage
  
 

   
     
 




