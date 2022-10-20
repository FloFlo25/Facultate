# To use in this project: Decision making, Loops
# Make a "Higher or Lower" guessing game for a random number

import math
from random import random

numbToGuess = math.floor(random()*10**2)
running = True

while(running):
    user_input = int(input("Try to guess the number: "))
    if user_input == numbToGuess:
        print("Hooray! You guessed the number!")
        break
    if user_input < numbToGuess:
        print("Higher")
    if user_input > numbToGuess:
        print("Lower")
    
