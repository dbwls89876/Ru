#include <stdio.h>

int main(){
	int n;
	scanf("%d", &n);
	int arr[10001] = {0};
	
	for(int i = 0; i<n; i++){
		int num;
		scanf("%d", &num);
		arr[num]++;
	}
	
	for(int i = 0; i<10001; i++){
		while(arr[i]--)
			printf("%d\n", i);
	}
	return 0;
}
