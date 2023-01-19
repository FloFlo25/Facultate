# Write a python program that takes all words from a file and shows the "abreviation" of those words in a string
f = open('Teme\Lab6\\text.txt')
file_content = f.read().replace(',', '')

arr_of_words = [word.capitalize() for word in file_content.split(' ')]

arr_of_letters = [word[0] for word in arr_of_words]

print(*arr_of_letters)
