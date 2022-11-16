import math

# Aria cercului
pi = math.pi

radius = int(input("Enter the radius of the circle: "))

result = math.floor(pi * math.pow(radius, 2))

print(f"Area of the circle is: {result}")
