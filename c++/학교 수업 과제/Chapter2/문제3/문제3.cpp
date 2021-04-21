#include <iostream>
using namespace std;

int main() {
	int days[] = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // 월별 최대일수 저장
	for (int i = 1; i <= 12; i++) {
		cout << i << "월은 " << days[i - 1] << "일까지 있습니다." << endl; // 월에 해당되는 일수 출력
	}
	
	return 0;
}