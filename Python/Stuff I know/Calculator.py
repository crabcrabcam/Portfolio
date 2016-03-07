import math


print("Calculator")
Operation = input("Please enter an operation.(divide, multiply, add or subtract: ")

if Operation == "divide":
    float noOne = input("Please input your first number: ")
    print(noOne)#Loves you
    float noTwo = input("Please enter your second number: ")
    print(noTwo)
    float answer = noOne / noTwo
    print(answer)
elif Operation == "multiply":
    float noOne = input("Please input your first number: ")
    print(noOne)#Loves you
    float noTwo = input("Please enter your second number: ")
    print(noTwo)
    float answer = noOne * noTwo
    print(answer)
elif Operation == "add":
    float noOne = input("Please input your first number: ")
    print(noOne)#Loves you
    float noTwo = input("Please enter your second number: ")
    print(noTwo)
    float answer = noOne + noTwo
    print(answer)
elif Operation == "subtract":
    float noOne = input("Please input your first number: ")
    print(noOne)#Loves you
    float noTwo = input("Please enter your second number: ")
    print(noTwo)
    float answer = noOne - noTwo
    print(answer)
elif Operation != "subtract" or Operation != "add" or Operation != "multiply" or Operation != "divide":
    print("Aborted, please try again.")
    
