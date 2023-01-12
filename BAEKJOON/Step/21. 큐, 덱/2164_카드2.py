# 첫번째

count = 0
n = int(input())
list = []
num = 0

for i in range(1, n+1):
  list.append(i)

while(len(list) != 1):
  print(list)
  if count%2==0:
    del list[0]
    count += 1
  else:
    list.append(list[0])
    del list[0]
    count += 1
  # print("count : " + str(count))
  # print(list)

print(list[0])

##시간초과로 실패



# 두번째

count = 1
n = int(input())

while((2 ** (count + 1)) < n):
  count += 1

if(n==1):
  num = 1
if(n==2):
  num = 2

print(2 * (n - (2 ** count)))


# 세번째

count = 1
n = int(input())

while((2 ** (count + 1)) < n):
  count += 1

print(n if n <=2 else 2 * (n - (2 ** count)))

# 번외

n = int(input())
deq = deque()

for i in range(1, n+1):
  deq.append(i)

while(len(deq) > 1):
  deq.popleft()
  deq.rotate(-1)

print(deq[0])
