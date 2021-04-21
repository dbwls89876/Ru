#include <iostream>
using namespace std;

void sayHello(int n = 1) { // 인수 미전달시 n은 1
	for (int i = 0; i < n; i++) { // n번만큼 Hello 출력
		cout << "Hello ";
	}
}

int main() {
	cout << "sayHello()->";
	sayHello(); // 인수 미전달시에 한번출력
	cout << endl; 
	cout << "sayHello(3)->";
	sayHello(3);
	cout << endl; // 3번출력
	return 0;
}