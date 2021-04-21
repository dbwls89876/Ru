#include <iostream>
using namespace std;

class Box {
private:
	double length; // 길이
	double width; // 넓이
	double height; // 높이
public:
	Box(double l = 0, double w=0, double h=0) : length{l}, width{w}, height{h}{}
	double getVolume(void) {
		return length * width * height;
	}
	double getLength() { return length; }
	double getWidth() { return width; }
	double getHeight() { return height; }

	Box operator+(const Box& b2); // 1번문제
	bool operator==(const Box& b2); // 2번문제
	bool operator<(const Box& b2); // 3번문제
	friend void printBox(Box b); // 4번문제
};

Box Box::operator+(const Box& b2) { // +연산자 중복정의
	Box b;
	b.length = this->length + b2.length;
	b.width = this->width + b2.width;
	b.height = this->height + b2.height;
	return b;
}
bool Box::operator==(const Box& b2) { // == 연산자 중복정의
	return (this->length == b2.length) && (this->width == b2.width) && (this->height == b2.height);
}

bool Box::operator<(const Box& b2) { // < 연산자 중복정의
	return (this->length < b2.length) && (this->width < b2.width) && (this->height < b2.height);
}

void printBox(Box b) { // friend 함수를 이용하여 박스 정보 출력
	cout << "상자의 길이 : " << b.length << endl;
	cout << "상자의 너비 : " << b.width << endl;
	cout << "상자의 높이 : " << b.height << endl;
	cout << "상자의 부피 : " << b.getVolume() << endl;
}

int main() {
	Box a(10, 10, 10);
	Box b(20, 20, 20);
	Box c;
	c = a + b;
	cout << "상자 #1" << endl;
	printBox(a);

	cout << "상자 #2" << endl;
	printBox(b);
	
	cout << "상자 #3" << endl;
	printBox(c);
	/*
	cout.setf(cout.boolalpha);  cout << (a < b) << endl; // <연산자 중복정의 확인
	cout.setf(cout.boolalpha);  cout << (a == b) << endl; // ==연산자 중복정의 확인 
	*/
	return 0;
}