import sys
n = int(input())

total_sum = 0
max_number = -sys.maxsize - 1

for i in range(0, n, 1):
    number = int(input())
    total_sum += number
    if number > max_number:
        max_number = number

total_sum -= max_number  # Изваждаме най-голямото число

if total_sum == max_number:
    print(f"Yes\nSum = {total_sum}")
else:
    print(f"No\nDiff = {abs(max_number - total_sum)}")
