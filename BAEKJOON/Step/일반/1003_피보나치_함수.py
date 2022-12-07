def fibonacci(n, arr):
  if n == 1 or n == 2:
    return 1
  elif(arr[n-1] != 0):
    return arr[n-1]
  else:
    arr[n-1] = fibonacci(n-1, arr) + fibonacci(n-2, arr)
    return arr[n-1]


t = int(input())

for i in range (t):
  n = int(input())
  arr = [0 for i in range(n)]
  if (n == 0) :
    print("1 0")
  elif(n == 1):
    print("0 1")
  else:
    print(str(fibonacci(n-1, arr)) + " " + str(fibonacci(n, arr)))
    
