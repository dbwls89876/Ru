#include <iostream>
#include <time.h>
using namespace std;
int Random_MAX();

int main() {
	int max = Random_MAX();
	cout << "가장 많이 생성된 수 : " << max << endl;
	return 0;
}

int Random_MAX() {
	srand(time(NULL)); // 시간이 변경될때마다 다른값 생성
	int num[10] = {0}; // 배열을 0으로초기화
	
	for (int i = 0; i < 100; i++) {
		int random = rand() % 10; // 9이하의 난수 발생
		for (int j = 0; j<10; j++)
			if(j==random) // j와 random의 값이 동일할때 해당되는배열값 증가
				num[j]++;
	}
	int temp = num[0], max=0; // 비교값 초기화 및 큰 숫자 저장
	for (int i = 1; i < 10; i++) {
		if (num[i] > temp){ // temp의 값이 num[i]보다 작을때 num[i]값 저장
			temp = num[i]; 
			max = i; // 해당되는 i의 숫자 기록
		}
	}
	return max; // 가장 많이 생성된 수 반환
}