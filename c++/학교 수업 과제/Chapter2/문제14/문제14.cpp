#include <iostream>
using namespace std;

int main() {
	int n1, n2, result=0;
	char c;
	cout << "연산의 종류 : ";
	cin >> c;
	cout << "숫자를 입력하시오 : ";
	cin >> n1 >> n2;
	if (c == '+') // 더하기
		result = n1 + n2;
	else if (c == '-') // 빼기
		result = n1 - n2;
	else if (c == '*') // 곱셈
		result = n1 * n2;
	else if (c == '/') // 나누기
		if (n2 == 0) 
		cout << "나눌 수 없습니다." << endl; // n2가 0일경우 오류표시후 프로그램종료
		else
			result = n1 / n2;
	if((c!='/')||(n2!=0))
	cout << "계산의 결과 : " << result << endl;

	return 0;
}