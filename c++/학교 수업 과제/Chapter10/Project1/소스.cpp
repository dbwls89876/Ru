#include <iostream>
using namespace std;

class Box {
private:
	double length; // ����
	double width; // ����
	double height; // ����
public:
	Box(double l = 0, double w=0, double h=0) : length{l}, width{w}, height{h}{}
	double getVolume(void) {
		return length * width * height;
	}
	double getLength() { return length; }
	double getWidth() { return width; }
	double getHeight() { return height; }

	Box operator+(const Box& b2); // 1������
	bool operator==(const Box& b2); // 2������
	bool operator<(const Box& b2); // 3������
	friend void printBox(Box b); // 4������
};

Box Box::operator+(const Box& b2) { // +������ �ߺ�����
	Box b;
	b.length = this->length + b2.length;
	b.width = this->width + b2.width;
	b.height = this->height + b2.height;
	return b;
}
bool Box::operator==(const Box& b2) { // == ������ �ߺ�����
	return (this->length == b2.length) && (this->width == b2.width) && (this->height == b2.height);
}

bool Box::operator<(const Box& b2) { // < ������ �ߺ�����
	return (this->length < b2.length) && (this->width < b2.width) && (this->height < b2.height);
}

void printBox(Box b) { // friend �Լ��� �̿��Ͽ� �ڽ� ���� ���
	cout << "������ ���� : " << b.length << endl;
	cout << "������ �ʺ� : " << b.width << endl;
	cout << "������ ���� : " << b.height << endl;
	cout << "������ ���� : " << b.getVolume() << endl;
}

int main() {
	Box a(10, 10, 10);
	Box b(20, 20, 20);
	Box c;
	c = a + b;
	cout << "���� #1" << endl;
	printBox(a);

	cout << "���� #2" << endl;
	printBox(b);
	
	cout << "���� #3" << endl;
	printBox(c);
	/*
	cout.setf(cout.boolalpha);  cout << (a < b) << endl; // <������ �ߺ����� Ȯ��
	cout.setf(cout.boolalpha);  cout << (a == b) << endl; // ==������ �ߺ����� Ȯ�� 
	*/
	return 0;
}