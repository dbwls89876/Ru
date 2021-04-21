#include <iostream>
using namespace std;

class TwoDimension {
	double x, y;
public:
	TwoDimension(double i, double j) : x{ i }, y{ j }{}
};

class ThreeDimension : TwoDimension {
	double z;
public:
	ThreeDimension(double i, double j, double k) : TwoDimension(i, j), z{ k } {}

};


int main() {
	return 0;
}