#include <iostream>
#include <math.h>
using namespace std;

class Complex {
private:
	double real, imag;
public:
	Complex() { real = 0.0, imag = 0.0;  }
	Complex(double r, double i) : real{r}, imag{i} {}
	Complex operator+(const Complex&); // 문제1
	Complex operator-(const Complex&);
	void operator+=(const Complex&); // 문제4
	void operator-=(const Complex&);
	operator double(); // 문제6
	friend ostream& operator<<(ostream& os, const Complex& c); // 문제8
	friend istream& operator>>(istream& os, Complex& c);
	bool operator==(const Complex&); // 문제9
	bool operator!=(const Complex&);
	
};

Complex Complex::operator+(const Complex& c2) { // +연산자 중복정의
	Complex c;
	c.real = this->real + c2.real;
	c.imag = this->imag + c2.imag;
	return c;
}

Complex Complex::operator-(const Complex& c2) { // -연산자 중복정의
	Complex c;
	c.real = this->real - c2.real;
	c.imag = this->imag - c2.imag;
	return c;
}

void Complex::operator+=(const Complex& c2) { // +=연산자 중복정의
	this->real = this->real + c2.real;
	this->imag = this->imag + c2.imag;
}

void Complex::operator-=(const Complex& c2) { // -=연산자 중복정의
	this->real = this->real - c2.real;
	this->imag = this->imag - c2.imag;
}

Complex::operator double() { // 형변환 연산자 중복정의
	double n;
	n = (this->real *  this->real) + (this->imag*this->imag);
	return sqrt(n);
}

ostream& operator<<(ostream& os, const Complex& c) { // <<연산자 중복정의
	if (c.imag >= 0) // 허수부분이 0이상일때 출력
		os << c.real << "+" << c.imag << "i" << endl;
	else
		os << c.real << "-" << "(" <<c.imag << "i)" << endl;
	return os;
}

istream& operator>>(istream& os, Complex& c) { // >>연산자 중복정의

	return os;
}

bool Complex::operator==(const Complex& c2) { // ==연산자 중복정의
	return (this->real == c2.real) && (this->imag == c2.imag);
}
bool Complex::operator!=(const Complex& c2) { // !=연산자 중복정의
	return (this->real != c2.real) && (this->imag != c2.imag);
}

int main() {
	cout.setf(cout.boolalpha);
	Complex c1(1.0, 7.0);
	Complex c2(3.0, 8.0);
	Complex c3, c4;
	c3 = c1 + c2; // 문제2
	c4 = c1.operator+(c2); // 문제3
	cout << "c3 = c1 + c2 : " << c3;
	cout << "c4 = c1.operator+(c2) : " << c4;
	c3 += c3; // 문제5
	cout << "(c3+=c3) : " << c3;
	cout << "c3==c4 : " <<(c3 == c4) << endl;
	cout << "c3!=c4 : " << (c3 != c4) << endl;
	cout << "절댓값 출력 : " << (double)c1 << endl;
	

}