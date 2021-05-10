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
			int n1 = 0; // W로 시작할 때, 반대상황 카운트 
			int n2 = 0; // B로 시작할 때
			for(int i = 0; i<8; i++){
				for(int j = 0; j<8; j++){
					if(i%2==0){ // i가 짝수일 때 
						if(j%2==0){ 
							if(arr[i+l][j+k] == 'B') // [0][0]이 W로 시작함 
								n1++; // 짝수열이 W가 아니므로 색칠 
							else
								n2++; // B로 시작하고 짝수열이 B가 아니므로 색칠 
						}else{ // 홀수열 체크 
							if(arr[i+l][j+k] == 'W') 
								n1++; // 홀수열이 B가 아니므로 색칠 
							else
								n2++; // 홀수열이 W가 아니므로 색칠 
						}
					}
					if(i%2==1){ // i가 홀수일 때, 반대로 
						if(j%2==0){ // 짝수 열 
							if(arr[i+l][j+k] == 'W') // [1][0]이 W로 시작함 , [1][1]은 B여야 함 
								n1++; // [0][1]이 B여야하기 때문에 W일 때 1증가 
							else // [0][0]이 B로 시작함 , [0][1]은 W여야 함 
								n2++; // [0][1]이 W여야하기 때문에 B일 때 1증가 
							}else{
							if(arr[i+l][j+k] == 'B') // [0][0]이 B로 시작함, [0][1]은 W여야 함 
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
