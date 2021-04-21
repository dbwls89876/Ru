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

void Computer::setComputer(string n, int ram, double cs) { // ������� �ʱ�ȭ
	name = n;
	RAM = ram;
	cpu_speed = cs;
}

void Computer::print() { // ������� ���尪 ���
	cout << "�̸� : " << name << endl;
	cout << "RAM : " << RAM << endl;
	cout << "CPU �ӵ� : " << cpu_speed << endl;
}

int main() {
	Computer obj; // ��ü����
	obj.setComputer("���ǽ���ǻ��", 8, 4.2);
	obj.print();
}