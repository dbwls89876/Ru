#include <iostream>
#include <string>
using namespace std;

int main() {
	string s;
	int counter[256] = { 0 }; 
	cout << "문자열을 입력하시오 : ";
	getline(cin, s); // 한줄 전체 입력

	for (int i = 0; i < s.size(); i++) {
		counter[s[i]]++; // 문자가 해당되는 유니코드 숫자에 배열값 입력
	}
	for (char i = 'a'; i <= 'z'; i++) { // a부터 z까지의 빈도 출력
		cout << i << " : " <<counter[i] << endl;
	}
	return 0;
}