n = int(input())
str = []

for i in range (n):
  str.append(input())

str = set(str)

for i in sorted(str, key = lambda x : (len(x), x)) :
  print(i)
