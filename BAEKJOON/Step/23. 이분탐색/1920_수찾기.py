# 복습 겸 이론만 기억나는 상태로 구현해보기,, 어딘가 이상한 이분탐색 알고리즘이 되었음

def binary_search(list, num): # num의 값이 존재할 때 1, 아닐때 0 return
  mid = int(len(list)/2)
  start = 0
  last = int(len(list))-1
  
  # print("mid : " + str(mid))
  while(start < last):
    if(last - start <3): #작은값이 안되서
      for i in range(start, last+1):
        if (list[i] == num) : 
          return 1
      return 0

    if (list[mid] == num) : # 중간값과 num의 값이 같을 때
      return 1
    elif(num < list[mid]): # num이 중간값보다 작을 경우
      last = mid
      mid = int(mid/2)
    elif(num > list[mid]):  # num이 중간값보다 클 경우
      start = mid
      mid = mid + int((last - mid)/2 )

  return 0

Nlist = []
Mlist = []

n = int(input())

for i in input().split():
  Nlist.append(int(i))

m = int(input())
for i in input().split():
  Mlist.append(int(i))

count = [0 for i in range(m)]

Nlist.sort()

for i in range (len(Mlist)):
  count[i] = str(binary_search(Nlist, Mlist[i]))
         
for i in count:
  print(i)
