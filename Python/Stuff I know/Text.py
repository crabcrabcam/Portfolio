print("Hello and welcome to this text based adventure. It is written in python.")
while True:
print("What is your name?")
name = input()
print("So your name is %s") % (name)
in = input("Enter (y)es or (n)o: ") 
 if in == "yes" or in == "y": 
  print("Ok") 
	break
 elif in == "no" or in == "n": 
continue
print("You are in a 3 by 3 grid of rooms with doors")
print("You are facing North")
print("")
print("Ok, you are in room 1, it has 4 doors and is in the middle of the grid.")