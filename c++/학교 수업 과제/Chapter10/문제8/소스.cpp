#include <iostream>
#include <math.h>
using namespace std;

class Complex {
private:
	double real, imag;
public:
	Complex() { real = 0.0, imag = 0.0;  }
	Complex(double r, double i) : real{r}, imag{i} {}
	Complex operator+(const Complex&); // ����1
	Complex operator-(const Complex&);
	void operator+=(const Complex&); // ����4
	void operator-=(const Complex&);
	operator double(); // ����6
	friend ostream& operator<<(ostream& os, const Complex& c); // ����8
	friend istream& operator>>(istream& os, Complex& c);
	bool operator==(const Complex&); // ����9
	bool operator!=(const Complex&);
	
};

Complex Complex::operator+(const Complex& c2) { // +������ �ߺ�����
	Complex c;
	c.real = this->real + c2.real;
	c.imag = this->imag + c2.imag;
	return c;
}

Complex Complex::operator-(const Complex& c2) { // -������ �ߺ�����
	Complex c;
	c.real = this->real - c2.real;
	c.imag = this->imag - c2.imag;
	return c;
}

void Complex::operator+=(const Complex& c2) { // +=������ �ߺ�����
	this->real = this->real + c2.real;
	this->imag = this->imag + c2.imag;
}

void Complex::operator-=(const Complex& c2) { // -=������ �ߺ�����
	this->real = this->real - c2.real;
	this->imag = this->imag - c2.imag;
}

Complex::operator double() { // ����ȯ ������ �ߺ�����
	double n;
	n = (this->real *  this->real) + (this->imag*this->imag);
	return sqrt(n);
}

ostream& operator<<(ostream& os, const Complex& c) { // <<������ �ߺ�����
	if (c.imag >= 0) // ����κ��� 0�̻��϶� ���
		os << c.real << "+" << c.imag << "i" << endl;
	else
		os << c.real << "-" << "(" <<c.imag << "i)" << endl;
	return os;
}

istream& operator>>(istream& os, Complex& c) { // >>������ �ߺ�����

	return os;
}

bool Complex::operator==(const Complex& c2) { // ==������ �ߺ�����
	return (this->real == c2.real) && (this->imag == c2.imag);
}
bool Complex::operator!=(const Complex& c2) { // !=������ �ߺ�����
	return (this->real != c2.real) && (this->imag != c2.imag);
}

int main() {
	cout.setf(cout.boolalpha);
	Complex c1(1.0, 7.0);
	Complex c2(3.0, 8.0);
	Complex c3, c4;
	c3 = c1 + c2; // ����2
	c4 = c1.operator+(c2); // ����3
	cout << "c3 = c1 + c2 : " << c3;
	cout << "c4 = c1.operator+(c2) : " << c4;
	c3 += c3; // ����5
	cout << "(c3+=c3) : " << c3;
	cout << "c3==c4 : " <<(c3 == c4) << endl;
	cout << "c3!=c4 : " << (c3 != c4) << endl;
	cout << "���� ��� : " << (double)c1 << endl;
	

}