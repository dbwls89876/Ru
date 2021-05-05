#include <stdio.h>
#include <cmath>
int main(){
	int n, positionalNumber, m;
	
	scanf("%d", &n);
	int temp = n;
	for(positionalNumber = 1; temp>=10; positionalNumber++){ //자릿수 찾기 
		temp/=10;
		
	}
	temp = 9*positionalNumber; // 최소 수
	for(int j = n-temp; j<=n; j++){
		int arr[100] = {0}; // 초기화
		m = j;
		int k = 0;
		for(int i = positionalNumber-1; i>=0; i--){
			arr[k] = m/(int)pow(10, i); // 각 자리수를 배열에 저장 
			m %= (int)pow(10, i); // 이미 구한 자리수를 제외한 나머지를 m에 저장 
			k++;
			
		}
		m = j;
		for(int i = 0; i<k; i++)
			m += arr[i]; // 각 자리수를 더함 
		if(m==n){
			m = j;
			break;
		}
		if(j==n)
			m = 0; 
			
	}
	printf("%d", m);
		
}
