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
	cout << (obj.name = "김철수") << endl; // 이름 초기화&출력
	cout << (obj.age = 38) << endl; // 나이 초기화&출력
	cout << (obj.salary = 2000000) << endl; // 월급 초기화&출력
	return 0;
}