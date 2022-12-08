def solution(k, tangerine):
    answer = 0
    orange = 0
    arr = [0 for i in range (max(tangerine))]
    
    for i in range (len(tangerine)):
        arr[tangerine[i]-1] += 1
    arr.sort(reverse=True)
    
    for i in arr:
        orange += i
        answer += 1
        if(orange>=k):
            break
    return answer
