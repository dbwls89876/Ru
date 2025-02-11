// 면접 코딩 문제
// 집와서 2분만에풀어서 더 민망해짐

import java.util.Arrays;

class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int count = 0;
        Arrays.sort(d);
        
        for(int i = 0; i<d.length; i++){
            if(count > budget)
                break;
            
            count += d[i];
            answer++;
        }
        
        if(count > budget)
            answer--;
        
        return answer;
    }
}
