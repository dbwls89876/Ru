#include <iostream>
using namespace std;

int main() {
	for (int i = 1; i <= 100; i++) {
		cout << i << " "; // i를 순서대로 출력
		if (i % 3 == 0)
			cout << "박수" << " "; // 3의 배수일때 박수 출력
	}
	cout << endl;
	return 0;
}