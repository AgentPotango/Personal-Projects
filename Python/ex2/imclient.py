import im
import random
import time
import sys

server = im.IMServerProxy('http://potnoodle.cs.man.ac.uk/~hussaim2/IMServer.php')

user = 'User1'
talkingTo = 'User2'
messaging = True
numberOfSecondsElapsed = 0;

if server[user] != "" and server[talkingTo] != "":
 del server[user]
 del server[user + 'm']
 del server[talkingTo]
 del server[talkingTo + 'm'] 

if server[user] == "":
 server[user] = 'talking'
else:
 user = 'User2'
 talkingTo = 'User1'
 server[user] = 'waiting'

while messaging == True:
 while server[user] == 'waiting':
  time.sleep(1)
  numberOfSecondsElapsed = numberOfSecondsElapsed + 1
  if numberOfSecondsElapsed == 20:
   print talkingTo + " has not responded in 20 seconds or never connected!"
   print "Chat will now close!"
   #can remove below disconnected statement
   server[user] = 'disconnected'
   sys.exit()
  if server[talkingTo] == 'waiting':
   print talkingTo + " says: " + server[talkingTo + 'm']
   server[user] = 'talking'
   server[talkingTo] = 'waiting'
 
 while server[user] == 'talking':
   myMessage = raw_input('Message to send to ' + talkingTo + ' : ')
   #can remove below if else statement
   if server[talkingTo] == 'disconnected':
     print talkingTo + ' has disconnected'
     print 'Chat will now close'
     time.sleep(3)
     sys.exit()
   else:
     server[user + 'm'] = myMessage
     server[talkingTo] = 'talking'
     server[user] = 'waiting'
   
     
 




