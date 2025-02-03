import math

n = int(input())

sum1 = 0
sum2 = 0

for i in range(n):
    number = int(input())
    sum1 += number

for i in range(n):
    number = int(input())
    sum2 += number

if sum1 == sum2:
    print(f"Yes, sum = {sum1}")
else:
    print(f"No, diff = {abs(sum1 - sum2)}")
