#include <iostream>
using namespace std;

int main() {
	int num = 0, sum = 0;
	for (; ;) { // 조건이 없기에 무한루프
		cout << "정수를 입력하시오 : ";
		cin >> num;
		if (num == 0) // 0을 입력하면 반복문 종료
			break;
		sum += num; // num의 값을 sum에 더한다
	}
	cout << "합계 : " << sum << endl; // 총합계 출력
}