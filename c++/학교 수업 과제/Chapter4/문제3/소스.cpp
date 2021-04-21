#include <iostream>
using namespace std;

class Sum {
private:
	int n1, n2;
public:
	void init(int x, int y);
	int add();
};

void Sum::init(int x, int y) { // 초기화
	n1 = x;
	n2 = y;
}
int Sum::add() { // 초기화한 n1과 n2를 더한값을 리턴
	return n1 + n2;
}

int main() {
	Sum obj;
	int n1, n2;
	cout << "첫번째 정수 : "; // 사용자로부터 입력받음
	cin >> n1;
	cout << "두번째 정수 : ";
	cin >> n2;
	obj.init(n1, n2); // 입력받은 값을 전달
	cout << "연산결과 : " <<obj.add() << endl; // 값 출력 
}