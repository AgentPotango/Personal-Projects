#!/usr/bin/env python

import urllib

#used to record the initial url
initialurl = "http://www.cs.manchester.ac.uk/ugt/2012/COMP18112/page3.html"
#used to check if a link is present (initially true)
linkPresent = True

#while link is present, decod the webpage into a text format and
#add any links
while linkPresent == True:
 url = initialurl
 data = urllib.urlopen(url)
 tokens = data.read().split()
 print ""

 #initializes the link list
 links = []
 #used to stored position of tokens
 index = 0
 #used to indicate when it is okay to print a token
 startPrinting = False
 #used to hold the text of the next token specified
 nextToken = ""

 #checks if each token satisfies any condition below. If they do not, it
 #prints the token and keeps track of every tokens position
 for token in tokens:
  if token == '<title>':
     print "Page Title:",
     startPrinting = True
  elif token == '</title>':
    startPrinting = False
    print ""
  
        
 
  elif token == '<h1>':
    print "Heading:",
    startPrinting = True
  elif token == '</h1>':
    startPrinting = False
    print ""

    
  elif token == '<p>':
    startPrinting = True
    print "Paragraph:",
  elif token == '</p>':
    startPrinting = False
    print ""
    
  elif token == '<em>' or token == '</em>':
    startPrinting = True
    print "*",
    
  elif token == '<a':
   startPrinting = False
   nextToken = tokens[index + 1]
   linkcut = nextToken[6:-2]
   links.append(linkcut) 
   
  elif token == nextToken:
    startPrinting = True
     
  elif token == '</a>':
    startPrinting = True
     
  else:
    if startPrinting == True:
      print token,
  
  index = index + 1 
 
 #used to initialize the link display number
 linkDisplayNumber = 1
 #used to display the links
 for link in links:
   print linkDisplayNumber,
   print (links[linkDisplayNumber -1])
   linkDisplayNumber += 1
 
 #if links exist, then set link present to true
 if len(links) != 0:
  linkPresent = True
 else:
  linkPresent = False
 
 #if the link is present, asks for a link and checks if that link
 #is one of the options displayed. If it is, it navigates to that page
 #and repeats the whole process above. If it is not, it displays an error
 #message and asks for the user to enter a correct link number
 if linkPresent == True:
   linkselected = raw_input("Select a link: ")
   if int(linkselected) <= len(links):
    requiredlink = links[int(linkselected) - 1][2:]
    initialurl = url[:-10] + requiredlink
   else:
     while int(linkselected) > len(links):
      print "Please enter a valid link number"
      linkselected = raw_input("Select a link: ")
      if int(linkselected) <= len(links):
        requiredlink = links[int(linkselected) - 1][2:]
        initialurl = url[:-10] + requiredlink 
 
  


    
     

   
   
   










            


