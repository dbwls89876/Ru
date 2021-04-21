#include <iostream>
#include <time.h>
using namespace std;

int main() {
	int user, computer, result;
	srand(time(NULL)); // rand함수 초기화
	computer = (rand() % 3)+1;
	cout << "가위, 바위, 보 중에 하나를 선택하시오(1, 2, 3) : ";
	cin >> user;
	cout << "컴퓨터 : " << computer << endl;
	if (user == computer) // (-1) = 비김, 0 = 패배, 1 = 승리
		result = -1; 
	else if (user == 1) { // 가위
		if (computer == 2)
			result = 0;
		else
			result = 1;
	}
	else if (user == 2) { // 바위
		if (computer == 3)
			result = 0;
		else
			result = 1;
	}
	else if (user == 3) { // 보
		if (computer == 1)
			result = 0;
		else
			result = 1;
	}
	
	if (result == 1) // 결과에 따라 문자 출력
		cout << "사용자 승!" << endl;
	else if(result == 0)
		cout << "컴퓨터 승!" << endl;
	else
		cout << "비겼습니다" << endl;
	return 0;
}