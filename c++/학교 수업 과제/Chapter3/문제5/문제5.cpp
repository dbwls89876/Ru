#include <iostream>
using namespace std;

void sayHello(int n = 1) { // �μ� �����޽� n�� 1
	for (int i = 0; i < n; i++) { // n����ŭ Hello ���
		cout << "Hello ";
	}
}

int main() {
	cout << "sayHello()->";
	sayHello(); // �μ� �����޽ÿ� �ѹ����
	cout << endl; 
	cout << "sayHello(3)->";
	sayHello(3);
	cout << endl; // 3�����
	return 0;
}