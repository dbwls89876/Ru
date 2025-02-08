class Solution {
    public boolean solution(String s) {
        boolean answer = true;
        try{
            Integer.parseInt(s); // 파서 실패 시 오류처리
            if(s.length() != 6 && s.length() != 4) // 6과 4가 아닐 경우
                return false;
           }
        catch(Exception e){return false;}
        
        return answer;
    }
}
