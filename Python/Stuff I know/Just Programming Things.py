print("This is a tournament generator.")
print("How many people are in this game (2, 4, 8, 16, 32)")
while True:
 players = input()
 if players is "2":
  print("You have only a final")
  break
  if players is "4":
   print("You have a semi-final and a final")
   break
   if players is "8":
    print("You have 3 rounds")
    break
    if players is "16":
     print("You have 4 rounds")
     break
     if players is "32":
      print("You have 5 rounds")
      break
      if players != "2" or if players != "4" or if players != "8" or if players != "16" or if players != "32":
       print("Please only enter 2, 4, 8, 16 or 32")
       continue
