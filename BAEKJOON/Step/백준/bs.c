#include <stdio.h>
	static int arr [] = {1, 2, 3, 4, 6};
int bs(int arr[], int f, int l, int n){
	int mid;
	if(f>l){
		return -1;
	}
	mid = (f+l)/2;	

	if(arr[mid]==n){
		return mid;
	}
	else if(arr[mid]>n){
		return bs(arr, f, mid-1, n);
	}
	else{

		return bs(arr, mid+1, l, n);
	}	
}

int main(){
	int n;
	int idx;
	scanf("%d", &n);
	idx = bs(arr, 0, (sizeof(arr)/sizeof(int)), n);
	printf("%d", idx);

//반복문 
//	int mid;
//	int first=0;
//	int last=sizeof(arr)/sizeof(int);
//	int r;
//	scanf("%d", &n);
//	while(first<=last){
//		mid = (first + last) / 2;
//		if(arr[mid]==n){
//			r = mid;	
//			break;
//		}
//		else if(arr[mid] > n){
//			last = mid-1;
//		}
//		else{
//			first = mid+1;
//		}
//		// 배열의 끝과 끝의 중간값을 target과 비교
//		// 중간값 <target 오른쪽 >왼쪽
//		// 동일할 때 값을 반환
//	} 
//	printf("%d", r+1);
//	
}
