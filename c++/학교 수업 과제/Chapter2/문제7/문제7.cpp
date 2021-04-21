#include <iostream>
using namespace std;

int main() {
	for (int i = 1; i <= 100; i++)
		if (i % 3 == 0) // 3의배수는 곧 3으로 나누어떨어지는 수
			cout << i << " ";
	cout << endl;
}