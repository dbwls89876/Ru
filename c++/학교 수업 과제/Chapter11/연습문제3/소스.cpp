#include <iostream>
#include <string>
using namespace std;

class Animal {
	string name;
public:
	Animal(string name) { cout << "����(������)(string)\n"; }
	~Animal() { cout << "����(�Ҹ���)\n"; }
};

class Lion : public Animal {
public:
	Lion(string name) : Animal(name) { cout << "����(������)\n"; }
	~Lion() { cout << "����(�Ҹ���)\n"; }
};

int main() {
	Lion lion1("King");
	return 0;
}