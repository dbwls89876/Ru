#include <iostream>
#include <string>
using namespace std;

class Employee {
public:
	string name;
	int age;
	int salary;
};

int main() {
	Employee obj;
	cout << "Employee1 : " << endl;
	cout << (obj.name = "��ö��") << endl; // �̸� �ʱ�ȭ&���
	cout << (obj.age = 38) << endl; // ���� �ʱ�ȭ&���
	cout << (obj.salary = 2000000) << endl; // ���� �ʱ�ȭ&���
	return 0;
}