#Excercise 1 - Assign a value to a variable and print it for every data type
aString: str = "A string"
anInt = 25
aFloat = 2.5
aComplex = 1j
aList = ["Mar", 25, "Para"]
aTuple = ("Raul", 25)
aRange = range(5)
aDict = {"RO": "Romania", "HU": "Hungary"}
aSet = {"banana", "apple", "pear"}
aBoolean = bool(True)
aByte = bytes(1)
aByteArray = bytearray(5)

#Excercise 2 - Make a script that takes the values typed by the user and show a message containing the value.
input = input("What is your name?")
print(f"Hello {input}")

#Excercise 3 - File size converter

BIT = 1
BYTE = BIT * 8
KB = 1024 * BYTE
MB = 1024 * KB
GB = 1024 * MB  
TB = 1024 * GB

def print_choices():
    print("1. TB")
    print("2. GB")
    print("3. MB")    

def size_chooser():
    print_choices()
    sizeInput: str = input("Enter the desired size: ")    
    if sizeInput == "1" or sizeInput.upper() == "TB": return TB
    if sizeInput == "2" or sizeInput.upper() == "GB": return GB
    if sizeInput == "3" or sizeInput.upper() == "MB": return MB
    return "Error"

 





input = input("Enter the amount of GB you want to convert: ")
