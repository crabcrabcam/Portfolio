import time


print("Birthday/Anniversary Script")

myName = input("What is your name?")
Occasion = input("What is the occasion?")
otherNames = input("Other people involved. (Leave blank for no more)")


if otherNames != "":
  print(" ")
  print("Happy",Occasion, myName,"and", otherNames,"!")
  time.sleep(5)
else:
  print("Happy",Occasion, myName,"!")
  time.sleep(5)

