import sys
import time
from datetime import datetime
from ex3utils import Server

# Create an echo server class
class EchoServer(Server):

	def onStart(self):
		self.users = []
		self.socket = {}
		self.clients = 0
		print "Echo server has started"
		
	def onMessage(self, socket, message):
		# split up the message from a space
		(command, sep, parameter) = message.strip().partition(' ')
		
		
		registered = False
		if command == 'HELP':
		    socket.send("HELP :- Displays a list of all functions and a"
		                + "small description of their uses")
		    socket.send("REGISTER <username> :- Registers a username"
		    	      + " which is required for chatting")
		    socket.send("MESSAGEALL <message> :- Sends a message to all"
		              + " the users in the room")
		    socket.send("LIST :- Displays a list of all the currently"
		              + " connected users")
		    socket.send("MESSAGE <username> :- <message> : Sends all"
		              + " the text after the colon to the specified" 
			      + " user")
		    socket.send("POKE <username> :- displays the seconds the"
		              + " user has been idle for")
		    socket.send("CHANGENICK <username> :- Allows you to change"
		              + " your nickname")
		    socket.send("MESSAGEGROUP <list all usernames> : <message>"
		              + " sends all the text after the colon"
		              + "to the specified user(s)")
		    		
				
		if command == 'REGISTER':
		  if parameter == "":
		    socket.send("Please Enter a Username")
		  elif parameter in self.users:
		      socket.send("This username is already taken; please"
		                + " choose another")
	          else:
		    if socket.username in self.users:
		      self.users.remove(socket.username)
		      del self.socket[socket.username]
		      socket.send("If you wish to change your nickname, please"
		                + " use the CHANGENICK command in the future")
		    socket.username = parameter
		    self.users.append(parameter)
		    self.socket[socket.username] = socket
		    for key in self.socket:
		      self.socket[key].send(socket.username + " has joined"
		          + " the chat room")
		    socket.registered = True
		    
		      		      
		if socket.registered != True:
		  socket.send("Please use the REGISTER function to first" 
		            + " register a username. Type HELP for more info.")
		else:
		     
		  if command == 'MESSAGEALL' or command == 'HELP' \
		     or command == 'LIST' or command == 'MESSAGE' \
		     or command == 'POKE' or command == 'REGISTER' \
		     or command == 'CHANGENICK':
		    socket.idle = datetime.now()
		  elif command == "":
		    socket.idle = datetime.now()
		  else:
		    socket.send("No such function exists: Please type HELP for"
		              + " a list of available functions")
		    
		  
		  if command == 'MESSAGEALL':
		    if parameter == "":
		      socket.send("Please enter a message after the command")
		    else:
		      for key in self.socket:
		        self.socket[key].send(socket.username + ": " + parameter)
		     #socket.send(socket.username + ": " + parameter)	    
		  
		  elif command == 'LIST':
		    socket.send("There are currently " + str(self.clients) + 
		                " users online")
		    socket.send("The users are: ")
		    socket.send( ', '.join(self.users))
		    
		  elif command == 'MESSAGE':
		    if parameter == "":
		      socket.send("Please enter a username followed by the"
		                + " message you wish to send. Type HELP for"
				+ " more information")
		    text = parameter.split()
		    user = text[0]
		    if user in self.users:
		      del text[0]
		      if user in self.socket:
		        self.socket[user].send("Private:- " + socket.username 
			                       + ": " + ' '.join(text))
	              
		    else:
		      socket.send("No such user found")
		      
		  elif command == "POKE":
		    if parameter == "":
		      socket.send("Please enter a username to find their idle" 
		                + " time. Type HELP for more information")
		    text = parameter.split()
		    user = text[0]
		    if user in self.users:
		      del text[0]
		      timeNow = datetime.now()
		      userLastAction = self.socket[user].idle
		      idleTime = timeNow - userLastAction
	              socket.send(user + " has been idle for " 
		                + str(idleTime.seconds) + " seconds" )
	            else:
		      socket.send("No such user found")
	 	  elif command == "CHANGENICK":
		    if parameter == "":
		      socket.send("Please enter a username to change your" 
		                + " username too. Type HELP for more" 
				+ " information")
		    else:
		      newnick = parameter
		    if newnick in self.users:
		      socket.send("That nickname is already in use; please" 
		                + " choose another")
		    else:
		      for key in self.socket:
		        self.socket[key].send(socket.username + " has changed" 
		                + " name to " 
		                + newnick)
		      self.users.remove(socket.username)
		      del self.socket[socket.username]
		      socket.username = newnick
		      self.users.append(newnick)
		      self.socket[newnick] = socket
		      
			
		# Signify all is well
		return True
	
	def onConnect(self, socket):
		self.clients +=1
		socket.idle = datetime.now()
		socket.registered = False
		socket.username = "none"
		#for key in self.socket:
		  #self.socket[key].send("A User has connected: There are now" 
		  #      + " " + str(self.clients) + " clients connected")
		  #self.socket[key].send("Users online: " + str(self.clients))
		socket.send("To start chatting, type 'REGISTER <Username>'"
		          + " (if you haven't already)")
		socket.send("1. Replace <Username> with your username of" 
		          + " choice")
		socket.send("2. Type HELP for a list of all functions.")
		
	def onDisconnect(self, socket):
		self.clients -=1
		for key in self.socket:
		   self.socket[key].send(socket.username + " has disconnected" \
		      + " There are" \
		      + " now " + str(self.clients) \
		      + " clients connected")
		if not self.users == False:
		  self.users.remove(socket.username)
		  del self.socket[socket.username]
		

#Parse the IP address and port you wish to listen on.
ip = sys.argv[1]
port = int(sys.argv[2])

# Create an echo server.
server = EchoServer()

# If you want to be an egomaniac, comment out the above command, 
#and uncomment the
# one below...
#server = EgoServer()

# Start server
server.start(ip, port)
