#include <stdio.h>
//static int one, zero;
static int arr[41];
int fibo(int n){
	
	if(arr[n]==-1){
		arr[n]=fibo(n-1) + fibo(n-2);
	}
	return arr[n];
}


int main(){
	int i;
	int result; 
	for(i = 0; i<41; i++){
		arr[i] = -1;
	}
	arr[0] = 0;
	arr[1] = 1;
	int n;
	scanf("%d", &n);
//	while(t!=0){
//		zero=0; one=0;
//		scanf("%d", &n);
//		result = fibo(n);
//		t--;
//	}
	result = fibo(n);
	printf("%d", result);
}
