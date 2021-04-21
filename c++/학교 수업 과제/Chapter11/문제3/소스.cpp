#include <iostream>
#include <string>
using namespace std;

class Employee {
private:
	string name;
	int salary;
public:
	Employee(string n, int s) : name{n}, salary{s}{} 
	void setName(string name) { this->name = name; }
	void setSalary(int salary) { this->salary = salary; }
	string getName() { return name; }
	int getSalary() { return salary; }
	int computeSalary() { return salary; };
};

class Manager : public Employee {
private:
	int bonus;
public:
	Manager(string n, int s, int b) : Employee(n, s), bonus{b} {}
	void setBonus(int b) { bonus=b; }
	int getBonus() { return bonus; }
	int computeSalary() { return bonus + getSalary(); }
};


int main() {
	Manager m("��ö��", 200, 100);
	cout << "�̸� : " << m.getName() << endl;
	cout << "���� : " << m.getSalary() << endl;
	cout << "���ʽ� : " << m.getBonus() << endl;
	cout << "��ü �޿� : " << m.computeSalary() << endl;
}