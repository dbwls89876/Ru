#include <iostream>
#include <string>
using namespace std;

class Person {
private :
	string name;
	int age;
public:
	void setPerson(string n, int a); // 초기화를 위한 함수
	void print(); // 저장된 정보 출력
};
void Person::setPerson(string n, int a) {
	name = n;
	age = a;
	}

void Person::print() {
	cout << "이름 : " << name << endl;
	cout << "나이 : " << age << endl;
}

int main() {
	Person obj;
	obj.setPerson("김철수", 21);
	obj.print();
}