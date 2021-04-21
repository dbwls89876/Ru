#include <iostream>
using namespace std;

template <typename T>
T min(const T x, const T y) {
	if (x > y) return y;
	else return x;
}

int main() {
	int a = 2, b = 1;
	cout << min<int>(a, b) << endl;
	int l = min(5, 6);
	cout << l << endl;
	double f = min<double>(6.78, 3.52);
}