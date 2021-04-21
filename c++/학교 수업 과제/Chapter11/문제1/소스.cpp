#include <iostream>
using namespace std;

class Point {
private:
	int x, y;
public:
	Point(int x, int y) : x{ x }, y{ y } {}
	void setX(int x) { this->x = x; }
	void setY(int y) { this->y = y; }
	int getX() { return x; }
	int getY() { return y; }
};

class ThreeDPoint : Point {
private:
	int z;
public:
	ThreeDPoint(int x = 0, int y = 0, int z = 0) : Point(x, y), z{z}{}
	void print() {
		cout << "(" << getX()<<","<<getY()<<","<<z<<")"<< endl;
		
	}
	ThreeDPoint operator+(ThreeDPoint&);
};

ThreeDPoint ThreeDPoint::operator+(ThreeDPoint& tp2) {
	ThreeDPoint tp;
	tp.setX(this->getX() + tp2.getX());
	tp.setY(this->getY() + tp2.getY());
	tp.z = this->z + tp2.z;
	return tp;
}


int main() {
	ThreeDPoint p1(10, 10, 10);
	ThreeDPoint p2(10, 10, 10);
	ThreeDPoint p3 = p1 + p2;
	cout << "p1 : ";
	p1.print();
	cout << "p2 : ";
	p2.print();
	cout << "p1 + p2 : ";
	p3.print();
	return 0;
}