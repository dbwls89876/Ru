package codingTest;

public class fifth {
	public static void main(String[] args) {
		int result = 0;
		int[][] arr = {{0,0,0,0,0,0,0,0,0,0}, //대칭이아니라서 일일히 추가함 ㅜ 방법이없나,,,
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
		for(int k=0; k<10; k++) // 일단은 무식하게 구현해보기
		for(int n=1; n<10; n++) { 
			for(int j=1; j<10; j++) {
				if(arr[n][j]==0) // 0은 계산할 필요가 없음
					continue;
				else { // if-else문 없앨 수 있는 방법 고민해보기
					boolean deep = true;
					if(arr[n][j]>arr[n][j-1])continue;
					else if(arr[n][j]>arr[n][j+1])continue;
					else if(arr[n][j]>arr[n-1][j])continue;
					else if(arr[n][j]>arr[n+1][j])continue;
					arr[n][j]+=1;
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
		//좀더 깔끔하게 구현해봅시다, 무식하게 구현 15분걸림 일단 정처기 치고....
		
	}
	
	
	
}
