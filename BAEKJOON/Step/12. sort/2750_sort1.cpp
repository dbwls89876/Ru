#include <stdio.h>

int main(){
	int n;
	scanf("%d", &n);
	int arr[1000];
	
	for(int i = 0; i<n; i++){
		scanf("%d", arr+i);
	}
	
	for(int i = 0; i<n; i++){ // n^2 ���� 
		for(int j = 0; j<n; j++){
			if(arr[i]<arr[j]){ // ���� ���� Ŭ �� 
				int temp = arr[i]; // i���� ���� 
				arr[i] = arr[j]; // i�� j�� ��ġ�� �ٲ� 
				arr[j] = temp;
			}
		}
	}
	
	for(int i = 0; i<n; i++)
		printf("%d\n", arr[i]);
	
	return 0;
}
