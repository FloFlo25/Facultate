# Make a python program that shows the product of two matrixes(size of 2x2)
import numpy as np

def print_matrix_without_brackets(two_dimensional_array):
    print(str(two_dimensional_array).replace(' [', '').replace('[', '').replace(']', ''))

matrixOne = np.array([[1, 2], [3, 4]])
matrixTwo = np.array([[1, 1], [2, 0]])
product = np.dot(matrixOne, matrixTwo)

print("Matrix 1")
print_matrix_without_brackets(matrixOne)
print("Matrix 2")
print_matrix_without_brackets(matrixTwo)

print()


print("Product of the two matrixes")
print_matrix_without_brackets(product)
