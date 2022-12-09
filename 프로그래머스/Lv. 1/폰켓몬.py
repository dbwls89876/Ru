def solution(nums):
    answer = 0
    count = []
    
    for i in nums:
        if str(i) not in count:
            check = False
            for j in count:
               if(i == j):
                check = True
            if check == False:
                answer += 1
                count.append(i)
        if(answer == (len(nums)/2)):
            break;
    return answer
