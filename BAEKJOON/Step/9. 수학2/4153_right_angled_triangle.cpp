#include <stdio.h>
#include <cmath>
#include <algorithm>


int main(){
	int arr[3];

	
	while(true){
		scanf("%d %d %d", arr, arr+1, arr+2); // �� �Է� 
		std::sort(arr, arr+3); // ������������ ���� 

		if(arr[0]==0)break;
		if(arr[2] == sqrt(pow(arr[0], 2)+pow(arr[1], 2))) // ������ ���̴� ���� ŭ, �� ���� ������ ���� = ������ ������ 
			printf("right\n");
		else
			printf("wrong\n");
	}
}
