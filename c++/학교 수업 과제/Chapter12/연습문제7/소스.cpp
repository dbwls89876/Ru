#include <iostream>
using namespace std;

template <typename T>
bool equal(T x, T y) {
	if (x == y) return true;
	else false;
}

int main() {
	bool b;
	cout.setf(cout.boolalpha);
	cout << (b = equal(1, 2)) << endl;
	cout << (b = equal(1.2, 1.3)) << endl;
	return 0;
}