from sys import argv

script, filename = argv

print("we're going to erase",filename)
print("If you don't want that, hit CTRL-C (^C)")
print("If you do want that hit RETURN")

raw_input("?")

print("Opening the file...")
target = open(filename, 'w')

print("Trunicating the file. Goodbye!")
target.trunicate()
#Truncate means it is making the file blank

print("Now i'm going to ask you for 3 lines")

line1 = input("line one:")
line2 = input("line two:")
line3 = input("line three")

print("I'm going to write these to the file")

target.write(line1)
target.write("\n")
target.write(line2)
target.write("\n")
target.write(line3)
target.write("\n")

print("And finally, we close it")
target.close()
