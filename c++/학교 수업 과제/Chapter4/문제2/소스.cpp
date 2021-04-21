#include <iostream>
#include <string>
using namespace std;

class Computer {
private:
	string name;
	int RAM;
	double cpu_speed;
public:
	void setComputer(string n, int ram, double cs);
	void print();
};

void Computer::setComputer(string n, int ram, double cs) { // 멤버변수 초기화
	name = n;
	RAM = ram;
	cpu_speed = cs;
}

void Computer::print() { // 멤버변수 저장값 출력
	cout << "이름 : " << name << endl;
	cout << "RAM : " << RAM << endl;
	cout << "CPU 속도 : " << cpu_speed << endl;
}

int main() {
	Computer obj; // 객체생성
	obj.setComputer("오피스컴퓨터", 8, 4.2);
	obj.print();
}