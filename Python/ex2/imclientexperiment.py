import im
import random
import time

server =im.IMServerProxy('http://potnoodle.cs.man.ac.uk/~hussaim2/IMServer.php')

user = 'User1'
talkingTo = 'User2'
messaging = True
numberOfSecondsElapsed = 0;
userCheck = 0
checkValue = 0

if server[user] == "":
 server[user] = 'talking'
 server[user + 'c'] = str(userCheck)
 server[talkingTo + 'c'] = str(userCheck)
 server[user + 'check'] = str(checkValue)
 server[talkingTo + 'check'] = str(checkValue)
elif server[user] != "" and server[talkingTo] == "":
 user = 'User2'
 talkingTo = 'User1'
 server[user] = 'waiting'
else:
  if int(server[talkingTo + 'check']) > int(server[talkingTo + 'c']) :
   if int(server[user + 'check']) == int(server[user + 'c']):
    checkValue = checkValue + 1
    user = 'User2'
    talkingTo = 'User1'
  elif int(server[talkingTo + 'check']) == int(server[talkingTo + 'c']):
   if int(server[user + 'check']) >= int(server[user + 'c']):
    checkValue = checkValue + 1
    user = 'User2'
    talkingTo = 'User1'


while messaging == True:
 while server[user] == 'waiting':
  time.sleep(1)
  if server[talkingTo] == 'waiting':
   print talkingTo + " says: " + server[talkingTo + 'm']
   server[user] = 'talking'
   server[talkingTo] = 'waiting'
 
 while server[user] == 'talking':
   checkValue = checkValue + 1
   server[user + 'check'] = str(int(server[user + 'check']) + 1)
   myMessage = raw_input('Message to send to ' + talkingTo + ' : ')
   server[user + 'm'] = myMessage
   server[talkingTo] = 'talking'
   server[user] = 'waiting'
   userCheck = int(server[user + 'c']) + 1
   server[user + 'c'] = str(userCheck)
   
   
     
 




