#include <iostream>
#include <string>
using namespace std;

class CellPhone {
public:
	bool on = false;
	string number, model, color;
	void setOn();
};

void CellPhone::setOn() { //온오프 조절
	if (on == false) { // on이 0일때 1로 변경후 true 출력
	on = 1;
	cout << "true" << endl;
	}
	else if (on == true) { // on이 1일때 0으로 변경후 false 출력
	on = 0;
	cout << "false" << endl;
	}

}

int main() {
	CellPhone obj; // 객체생성
	cout << "CellPhone1 : " << endl; 
	cout << (obj.number = "010-1234-5678") << endl; // 번호 초기화 및 출력
	cout << (obj.model = "Galaxy") << endl; // 모델 초기화 및 출력
	cout << (obj.color = "Black") << endl; // 색깔 초기화 및 출력
	obj.setOn(); // 전원온오프 및 상태출력
	return 0;
}