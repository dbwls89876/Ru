#include <iostream>
#include <string>
using namespace std;

class Person {
private :
	string name;
	int age;
public:
	void setPerson(string n, int a); // �ʱ�ȭ�� ���� �Լ�
	void print(); // ����� ���� ���
};
void Person::setPerson(string n, int a) {
	name = n;
	age = a;
	}

void Person::print() {
	cout << "�̸� : " << name << endl;
	cout << "���� : " << age << endl;
}

int main() {
	Person obj;
	obj.setPerson("��ö��", 21);
	obj.print();
}