#include <stdio.h>
#include <algorithm>

int main(){
	int n, m;
	scanf("%d %d", &n, &m);
	char arr[n][m];
	for(int i = 0; i<n; i++)
		scanf("%s", arr[i]);
	int min = 1000;
	for(int l = 0; l<=n-8; l++){
		for(int k = 0; k<=m-8; k++){
			int n1 = 0; // W�� ������ ��, �ݴ��Ȳ ī��Ʈ 
			int n2 = 0; // B�� ������ ��
			for(int i = 0; i<8; i++){
				for(int j = 0; j<8; j++){
					if(i%2==0){ // i�� ¦���� �� 
						if(j%2==0){ 
							if(arr[i+l][j+k] == 'B') // [0][0]�� W�� ������ 
								n1++; // ¦������ W�� �ƴϹǷ� ��ĥ 
							else
								n2++; // B�� �����ϰ� ¦������ B�� �ƴϹǷ� ��ĥ 
						}else{ // Ȧ���� üũ 
							if(arr[i+l][j+k] == 'W') 
								n1++; // Ȧ������ B�� �ƴϹǷ� ��ĥ 
							else
								n2++; // Ȧ������ W�� �ƴϹǷ� ��ĥ 
						}
					}
					if(i%2==1){ // i�� Ȧ���� ��, �ݴ�� 
						if(j%2==0){ // ¦�� �� 
							if(arr[i+l][j+k] == 'W') // [1][0]�� W�� ������ , [1][1]�� B���� �� 
								n1++; // [0][1]�� B�����ϱ� ������ W�� �� 1���� 
							else // [0][0]�� B�� ������ , [0][1]�� W���� �� 
								n2++; // [0][1]�� W�����ϱ� ������ B�� �� 1���� 
							}else{
							if(arr[i+l][j+k] == 'B') // [0][0]�� B�� ������, [0][1]�� W���� �� 
								n1++;
							else
								n2++;
						}
					}
				}			
			}
			min = std::min(min, n2);
			min = std::min(min, n1);
		}
	}
	printf("%d", min);
}
