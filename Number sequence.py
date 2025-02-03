import sys
n = int(input())
max_number = -sys.maxsize - 1
min_number = sys.maxsize
for i in range(0, n):
    number = int(input())
    if number > max_number:
        max_number = number
    if number < min_number:
        min_number = number
print(f'Max number: {max_number}\nMin number: {min_number}\n')
