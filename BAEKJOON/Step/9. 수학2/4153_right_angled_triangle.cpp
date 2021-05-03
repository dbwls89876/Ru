#include <stdio.h>
#include <cmath>
#include <algorithm>


int main(){
	int arr[3];

	
	while(true){
		scanf("%d %d %d", arr, arr+1, arr+2); // 값 입력 
		std::sort(arr, arr+3); // 오름차순으로 정렬 

		if(arr[0]==0)break;
		if(arr[2] == sqrt(pow(arr[0], 2)+pow(arr[1], 2))) // 빗변의 길이는 가장 큼, 양 변의 길이의 제곱 = 빗변의 제곱근 
			printf("right\n");
		else
			printf("wrong\n");
	}
}
