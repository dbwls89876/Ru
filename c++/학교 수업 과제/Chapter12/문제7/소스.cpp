#include <iostream>
using namespace std;
static const double PI = 3.14;

template <typename T>
class Circle {
private:
	T x, y;
	double rad;
public:
	Circle(T x, T y, double r) : x{ x }, y{ y }, rad{ r } {}

	double area() {
		return PI * rad * rad;
	}
	
};
int main() {
	Circle<double> circleA(0.0, 0.0, 10.0);
	cout << "¸éÀû : " << circleA.area() << endl;
	return 0;
}