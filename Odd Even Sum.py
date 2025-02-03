import math
n = int(input())
sum1 = 0
sum2 = 0
order = bool(True)

for i in range(n):
    number = int(input())
    if order:
        sum1 += number
        order = False
    else:
        sum2 += number
        order = True

if sum1 == sum2:
    print(f"Yes\nSum = {sum1}")
else:
    print(f"No\nDiff = {abs(sum1 - sum2)}")
