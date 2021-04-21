#include <iostream>
#include <string>
using namespace std;

class MyClass {
public:
	MyClass(const char*str);
	~MyClass();
	MyClass(const MyClass &m1);
	void print();
private:
	char* stored;
};

MyClass::MyClass(const char* str) {
	stored = new char[strlen(str) + 1];
	strcpy_s(stored, strlen(str)+1, str);
}

MyClass::~MyClass() {
	delete[] stored;
}

MyClass::MyClass(const MyClass &m1) {
	stored = new char[strlen(m1.stored) + 1];
	strcpy_s(stored, strlen(m1.stored)+1 ,m1.stored);

}

void MyClass::print() {
	int len = strlen(stored);
	for (int i = 0; i < len; i++)
		cout << stored[i];
}

int main() {
	char a[3] = "12";
	MyClass m1(a);
	cout << "°´Ã¼1 : ";
	m1.print();
	cout << endl;
	cout << "°´Ã¼2 : ";
	MyClass m2(m1);
	m2.print();
	cout << endl;
	return 0;
}
