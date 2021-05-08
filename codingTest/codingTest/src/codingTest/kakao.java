package codingTest;

public class kakao {
	public static void main(String[] args) {
		
		//2번문제, 넓이우선탐색법
		
		String[][] places = new String[5][5];
		int[] answer = new int[5];
        for(int t = 0; t<5; t++){
            int danger = 1; // 거리두기
            int[][] distance = new int[25][2]; // 사람이 앉은 자리
            int p = 0; //사람 수
            for(int i = 0; i<5; i++){
                for(int j = 0; j<5; j++){
                    if(places[t][i].charAt(j) == ('P')){ // 대기실 t번의 i열의 j자리에 누군가 앉아있을때
                        distance[p][0] = i; distance[p][1] = j; // 각각의 사람의 자리 위치 저장
                        p++;
                        for(int k = 0; k<distance.length-1; k++){
                            int num = Math.abs(distance[k][0]-i) + Math.abs(distance[k][1]-j);
                            if(num==1){ // 바로 옆에 누군가 앉아있음
                                danger = 0; // 거리두기 안지킴
                                break;
                            }else if(num>=3) // 멀어서 거리두기 규칙 엄수 상태
                                continue;
                            else{ // 2나 0일경우, 절대값이므로 음수가 없음
                                if(j==0 && i>0){
                                    if(places[t][i-1].charAt(j) != ('X') && places[t][i-1].charAt(j+1) == ('P')){
                                        danger = 0; break;
                                    }
                                }
                                if(j==4 && i>0){
                                    if(places[t][i-1].charAt(j) != ('X') && places[t][i-1].charAt(j-1) == ('P')){
                                        danger = 0; break;
                                    }
                                }
                                if(j == 2 || j == 1){ // 왼쪽 검사 필요 x
                                    if(places[t][i].charAt(j+1) != ('X') && places[t][i].charAt(j+2) == ('P')){ // 칸막이가 안 쳐져있고 사람이 건너편에 있음, 위험!
                                            danger = 0; break;
                                    }
                                    else if(i>=1){
                                        if(places[t][i-1].charAt(j) != ('X')){
                                            if(places[t][i-1].charAt(j+1) == ('P') || places[t][i-1].charAt(j-1) == ('P')){
                                                danger = 0; break;
                                            }
                                        }
                                    }
                                }
                                if(j == 2 || j == 3){ // 오른쪽 검사 필요 x
                                    if(places[t][i].charAt(j-1) != ('X') && places[t][i].charAt(j-2) == ('P')){
                                            danger = 0; break;
                                    }
                                    else if(i>=1){
                                        if(places[t][i-1].charAt(j) != ('X')){
                                            if(places[t][i-1].charAt(j+1) == ('P') || places[t][i-1].charAt(j-1) == ('P')){
                                                danger = 0; break;
                                            }
                                        }
                                    }
                                }
                                if(i>=2){
                                    if(places[t][i-1].charAt(j) != ('X') && places[t][i-2].charAt(j) == ('P')){
                                        danger = 0;
                                        break;
                                        }
                                    }
                            }
                        }
                    }
                    if(danger == 0)break; // 거리두기를 안지켜서 이후는 체크할 필요가 없음
                }
                answer[t] = danger;
            }
        }

		
		
		
		//1번
//		int answer = 0;
//        String num = "";
//        string engNum = "";
//        
//        for(char a : s){
//            if(Character.isDigit(a)){
//                String num += a;
//                continue;
//            }
//            engNum += a;
//            switch(engNum){
//                case "zero":num += "0"; engNum = ""; break;
//                case "one":num += "1"; engNum = ""; break;
//                case "two":num += "2"; engNum = ""; break;
//                case "three":num += "3"; engNum = ""; break;
//                case "four":num += "4"; engNum = ""; break;
//                case "five":num += "5"; engNum = ""; break;
//                case "six":num += "6"; engNum = ""; break;
//                case "seven":num += "7"; engNum = ""; break;
//                case "eight":num += "8"; engNum = ""; break;
//                case "nine":num += "9"; engNum = ""; break;
//            }
//            
//        }
//        answer = Integer.parseInt(num);
	}
}
