#include <iostream>
#include <string>
using namespace std;

class Book {
public: // 직접적인 접근을 위한 설정
	string title;
	string author;
};

int main() {
	Book obj; // 객체생성
	
	cout << "책 이름 : " << (obj.title = "Great C++") << endl; // title초기화 및 출력
	cout << "책 저자 : " << (obj.author = "Bob") << endl; // author초기화 및 출력
	return 0;
}