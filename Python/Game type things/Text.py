import sys
import math

print("Hello and welcome to this text based adventure. It is written in python.")
#Input name
while True:
 print("What is your name?")
 name = raw_input()
 print("So your name is %s") % (name)
 yesNo = raw_input("Enter (y)es or (n)o: ") 
 if yesNo == "yes" or yesNo == "y": 
  print("Ok")
  break
  if yesNo == "no" or yesNo == "n": 
   continue

#Where you are
print("You are in a 3 by 3 grid of rooms with doors")#                              ___________
print("You are facing west")#                                                      |_a_|_b_|_c_|
print("Ok, you are in room 1, it has 4 doors and is in the middle of the grid.")#  |_d_|_e_|_f_|
#                                                                                  |_g_|_h_|_i_|
#Where do you want to go first code. You have nothing.
while True:
 print("Where do you want to go? ((N)orth, (E)ast, (S)outh or (W)est)")
 NEWSOne = raw_input()
 if NEWSOne == "s" or NEWSOne == "south":
     print("You have entered the room 'h'")
     print("There is a")
     continue
     #break when finished
     if NEWSOne == "w" or NEWSOne == "west":
      #keyA if to open room B
      keyA = True
      roomD = True
      print("You have entered the room 'D'")
      print("You pick up a key from the middle of the room")
      print("There is nothing more in this room")
      print("Going back to room E")
      continue
      if NEWSOne == "n" or NEWSOne == "north":
       print("The door is locked try another")
       continue
       if NEWSOne == "e" or NEWSOne == "east":
        print("The door is locked try another")
        continue

print("You are in the starting room")
print("Where do you want to go?(N, E, S or W)")
NEWSTwo = raw_input()
if keyA is True:
 if NEWSTwo is "n" or "north":
  roomB = True
  print("You have entered room 'B'")
  print("There are two doors")
  print("Do you want to go East or West?")
  #NEWSThree = raw_input()
  #break
  #while True:
  #if NEWSTwo = 

