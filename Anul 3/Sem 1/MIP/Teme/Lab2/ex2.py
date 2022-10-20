# Make a program that prints a sentence with each of it's word being reversed
# but at the same position as before
sentence = input("Enter a sentence: ")

# Basic way
words = sentence.split(" ")

result = ""
for word in words: 
    for letter in reversed(word):
        result+=letter
    result+=" "

print(result)

# Short way
print(*[i[::-1] for i in sentence.split(" ")])