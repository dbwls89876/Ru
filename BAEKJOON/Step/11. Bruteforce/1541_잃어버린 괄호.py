s = input()
b = ""
c = 0
check = False
result = 0

for a in s :
  
  if a == '+':
    c += int(b)
    b = ""
    
    continue
  elif a == '-':
    c += int(b)
    if(check):
      result -= c
      b = ""
      c = 0
      continue
    else:
      result += c
      check = True
      b = ""
      c = 0
      continue
    
  b += a


c += int(b)

if check == False:
  result += c
else:
  result -= c

print(result)
