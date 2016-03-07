print("Hello World")
login = True
while True:
  login == True
  print("Login")
  loginName = input()
  print("Enter your password")
  passWord = input()
  logout = False
  DoThing = True
  break

while True:
  DoThing == True
  print("Hello", loginName)
  print("What would you like to do?")
  Action = input()
  DoThing = False
  break

while True:
  Action == "help"
  print("You can;")
  print("Make a text file with 'fileCreate'")
  print("You can use a calculator with 'Calculator'")
  DoThing = True

while True:
  Action != "Calculator" or Action != "fileCreate"
  print("That's not something you can do!")
  print("Type 'help' for help")
  DoThing = True

while True:
  file = True
  Action == "fileCreate"
  print("Please name your file")
  fileName = input()
  print("Your file is called",fileName)
    

while True:
  if Action == "calculator":
    calc = True
    
  print("Calculator")
  print("Please enter a number.")
  NoOne = input()
  print("Please enter another number.")
  NoTwo = input()
  print("Please enter an operation.(+-*/)")
  Operation = input()

  if Operation != "+" or Operation != "-" or Operation != "*" or Operation != "/":
    print("invalid Operation")
    
    if Operation == "+":
      print(NoOne + NoTwo)

  
    if Operation == "-":
      print(NoOne-NoTwo)


    if Operation == "*":
      print(NoOne*NoTwo)


    if Operation == "/":
      print(NoOne/NoTwo)
    break
    
    

while True:
  Action == "logout"
  print("Goodbye", loginName)
  login = True


while True:
  if loginName == "quit":
    print("Goodbye!")
  quit()
