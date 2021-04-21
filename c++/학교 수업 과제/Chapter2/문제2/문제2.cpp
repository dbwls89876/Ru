#include <iostream>
#include <string>
using namespace std;

int main() {
	string drink[] = { "콜라", "물", "스프라이트", "주스", "커피" }; // 각배열에 음료수 저장
	int i;
	cout << "콜라, 물, 스프라이트, 주수, 커피 중에서 하나를 선택하세요 : ";
	cin >> i; // 사용자로부터 음료수의번호를 입력받는다
	switch (i -= 1) {
	case 0 : case 1 : case 2 : case 3 : case 4 : // 음료가 들어있는 배열 번호를 구별
		cout << drink[i] << "를 선택하였습니다." << endl; // i로부터 받은 숫자에 해당되는 음료 출력
		break; // default실행 방지를위한 break문
	default :
		cout << "오류. 선택이 유효하지 않습니다. 돈을 반환합니다." << endl; // case에 해당되지않을시에 출력
	}

	return 0;
}