package codingTest;

public class fifth {
	public static void main(String[] args) {
		int result = 0;
		int[][] arr = {{0,0,0,0,0,0,0,0,0,0}, // 희소행렬?
				{0,0,0,0,1,0,0,0,0,0},
				{0,0,0,1,1,1,0,0,0,0},
				{0,1,1,1,1,1,1,0,0,0},
				{0,1,1,1,1,1,1,1,1,0},
				{0,1,1,1,1,1,1,1,1,0},
				{0,0,1,1,1,1,1,1,0,0},
				{0,0,0,1,1,1,1,0,0,0},
				{0,0,0,0,1,0,0,0,0,0},
				{0,0,0,0,0,0,0,0,0,0}
		};
		for(int k=0; k<3; k++) // 3중 반복문 없애는 방법 생각해보기
		for(int n=1; n<10; n++) {  // 행
			for(int j=1; j<10; j++) { // 열
				if(arr[n][j]==0) // 0은 계산할 필요가 없음
					continue;
				else { 
					if(arr[n][j]>arr[n][j-1])continue;
					else if(arr[n][j]>arr[n][j+1])continue;
					else if(arr[n][j]>arr[n-1][j])continue;
					else if(arr[n][j]>arr[n+1][j])continue;
					arr[n][j]+=1; // 인접한 행렬들의 값이 같거나 높을 때 1 증가
				}
			}
		}
		
		for(int i = 0; i<10; i++) {
			for(int j = 0; j<10; j++) {
				System.out.print(arr[i][j]);
				result += arr[i][j];
			}
			System.out.println();
		}
		System.out.println("result = " + result); 
		
	}
	
	
	
}
