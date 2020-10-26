#ALL PREVIOUS EX3 TASK STUFF INTACT

import sys
import time
from ex3utils import Server

# Create an echo server class
class EchoServer(Server):

	def onStart(self):
		self.users = []
		self.clients = 0
		print "Echo server has started"
		
	def onMessage(self, socket, message):
		print "User has sent a message";
		# split up the message
		(command, sep, parameter) = message.strip().partition(' ')
		print 'Command is ', command
		print 'Message is ',parameter
		socket.send(message)
		socket.send("socketNumber " + str(socket))
		self.send("What is this")
		# Signify all is well
		return True
	
	def onConnect(self, socket):
		self.clients +=1
		socket.username = none
		print "A User has connected: There are now " + str(self.clients) \
		      + " clients connected"
		socket.send("Users online: " + str(self.clients))
		socket.send("To start chatting, please type 'REGISTER <Username>' and " \
			    + "replacing <Username> with your username of choice. " \ 
			    + "Type HELP for a list of all functions.")
	def onDisconnect(self, socket):
		self.clients -=1
		print "User has disconnected: There are now " + str(self.clients) \
		      + " clients connected"
		socket.send("A user disconnected" + str(self.clients) + " are left online")

#Parse the IP address and port you wish to listen on.
ip = sys.argv[1]
port = int(sys.argv[2])

# Create an echo server.
server = EchoServer()

# If you want to be an egomaniac, comment out the above command, and uncomment the
# one below...
#server = EgoServer()

# Start server
server.start(ip, port)
