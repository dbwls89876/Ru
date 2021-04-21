#include <iostream>
#include <string> // 스트링 함수를 사용하기위해 불러온 헤더파일
using namespace std;

int main() {
	string s1;
	string s2;
	cout << "첫 번째 문자열 : ";
	cin >> s1;
	cout << "두 번째 문자열 : ";
	cin >> s2;
	if (s1 == s2) // 두개의 문자열을 비교해서 같을시에 실행
		cout << "2개의 문자열은 같습니다" << endl;
	else // 같지않을시에 실행
		cout << "2개의 문자열은 다릅니다" << endl;
	return 0;
}