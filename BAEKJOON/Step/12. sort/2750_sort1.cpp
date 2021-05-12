#include <stdio.h>

int main(){
	int n;
	scanf("%d", &n);
	int arr[1000];
	
	for(int i = 0; i<n; i++){
		scanf("%d", arr+i);
	}
	
	for(int i = 0; i<n; i++){ // n^2 정렬 
		for(int j = 0; j<n; j++){
			if(arr[i]<arr[j]){ // 비교한 값이 클 때 
				int temp = arr[i]; // i값을 저장 
				arr[i] = arr[j]; // i와 j의 위치를 바꿈 
				arr[j] = temp;
			}
		}
	}
	
	for(int i = 0; i<n; i++)
		printf("%d\n", arr[i]);
	
	return 0;
}
