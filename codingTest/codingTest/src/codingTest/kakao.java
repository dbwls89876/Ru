package codingTest;

public class kakao {
	public static void main(String[] args) {
		
		//2������, ���̿켱Ž����
		
		String[][] places = new String[5][5];
		int[] answer = new int[5];
        for(int t = 0; t<5; t++){
            int danger = 1; // �Ÿ��α�
            int[][] distance = new int[25][2]; // ����� ���� �ڸ�
            int p = 0; //��� ��
            for(int i = 0; i<5; i++){
                for(int j = 0; j<5; j++){
                    if(places[t][i].charAt(j) == ('P')){ // ���� t���� i���� j�ڸ��� ������ �ɾ�������
                        distance[p][0] = i; distance[p][1] = j; // ������ ����� �ڸ� ��ġ ����
                        p++;
                        for(int k = 0; k<distance.length-1; k++){
                            int num = Math.abs(distance[k][0]-i) + Math.abs(distance[k][1]-j);
                            if(num==1){ // �ٷ� ���� ������ �ɾ�����
                                danger = 0; // �Ÿ��α� ����Ŵ
                                break;
                            }else if(num>=3) // �־ �Ÿ��α� ��Ģ ���� ����
                                continue;
                            else{ // 2�� 0�ϰ��, ���밪�̹Ƿ� ������ ����
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
                                if(j == 2 || j == 1){ // ���� �˻� �ʿ� x
                                    if(places[t][i].charAt(j+1) != ('X') && places[t][i].charAt(j+2) == ('P')){ // ĭ���̰� �� �����ְ� ����� �ǳ��� ����, ����!
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
                                if(j == 2 || j == 3){ // ������ �˻� �ʿ� x
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
                    if(danger == 0)break; // �Ÿ��α⸦ �����Ѽ� ���Ĵ� üũ�� �ʿ䰡 ����
                }
                answer[t] = danger;
            }
        }

		
		
		
		//1��
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
