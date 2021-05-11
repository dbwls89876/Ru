#include <stdio.h>
#include <math.h>
int main(){
	int n, result=0, num=0; // 찾을 개수, 마지막 값,  찾아낸 개수 
	int check; // 666 확인 
	int i = 0; // 자리수 계산 
	scanf("%d", &n);
	int temp; // 666을 찾아내기 위해 대입할 값
	
	
	for(int j = 666; j<=10000000; j++){ // 첫번째 값 666부터 시작 
		if(num == n) // n개의 숫자를 찾았을 때 탈출 
			break;
		temp = j; //자릿수 찾기 
		check = 0;
		
		for(i = 0; temp>=10; i++){
		temp/=10; // temp를 10씩 나눠 자릿수를 찾음 
		}
		temp = j; // 666을 포함한 숫자 찾기 
		for(; i>=0; i--){ // 자릿수만큼 나누기를 반복 
			if(temp/(int)pow(10, i) == 6) // 나눈 값이 6일때 
				check++; // 6을 체크
			else
				check = 0; // 6이 연속되지않음 
			temp%=(int)pow(10, i); // 나머지값을 저장 
		
			if(check==3){ // 6이 연속해서 3개 나왔을 때 
			result = j; // j값을 저장 
			num++; // 발견한 수 증가 
			break;
			}
		}
		
		
	}
	printf("%d" ,result);
}
