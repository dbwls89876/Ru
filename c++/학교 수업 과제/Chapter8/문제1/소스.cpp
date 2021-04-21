#include <iostream>
using namespace std;


int main() {
	int num;
	cout << "얼마나 많은 이름을 입력 하시겠습니까? ";
	cin >> num;
	string *arr = new string[num]; // 동적배열 생성
	for (int i = 0; i < num; i++) {
		cout << "이름 입력 # " << i+1 << ": ";
		cin >> arr[i]; // 기존 배열 입력방식과 동일
	}
	cout << endl;
	cout << "다음은 이름 목록입니다" << endl;
	for (int i = 0; i < num; i++)
		cout << "이름 # "<<i+1<<": "<< arr[i] << endl; // 배열에 담긴 문자 출력

	return 0;
}