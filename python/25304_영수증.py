total = int(input())
num = int(input())
sum = 0

for i in range(num) :
    A, B = map(int, input().split())
    sum = sum + A * B
    

if sum == total :
    print("Yes")
else :
    print("No")