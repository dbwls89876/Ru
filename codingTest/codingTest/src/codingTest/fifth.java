package codingTest;

public class fifth {
	public static void main(String[] args) {
		int result = 0;
		int[][] arr = {{0,0,0,0,0,0,0,0,0,0}, //��Ī�̾ƴ϶� ������ �߰��� �� ����̾���,,,
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
		for(int k=0; k<10; k++) // �ϴ��� �����ϰ� �����غ���
		for(int n=1; n<10; n++) { 
			for(int j=1; j<10; j++) {
				if(arr[n][j]==0) // 0�� ����� �ʿ䰡 ����
					continue;
				else { // if-else�� ���� �� �ִ� ��� ����غ���
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
		//���� ����ϰ� �����غ��ô�, �����ϰ� ���� 15�аɸ� �ϴ� ��ó�� ġ��....
		
	}
	
	
	
}
