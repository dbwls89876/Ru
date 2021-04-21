#include <iostream>
#include <string>
using namespace std;

class Animal {
	string name;
public:
	Animal(string name) { cout << "동물(생성자)(string)\n"; }
	~Animal() { cout << "동물(소멸자)\n"; }
};

class Lion : public Animal {
public:
	Lion(string name) : Animal(name) { cout << "사자(생성자)\n"; }
	~Lion() { cout << "사자(소멸자)\n"; }
};

int main() {
	Lion lion1("King");
	return 0;
}