#include <iostream>
using namespace std;

int main() {
	for (int i = 1; i <= 100; i++)
		if (i % 3 == 0) // 3�ǹ���� �� 3���� ����������� ��
			cout << i << " ";
	cout << endl;
}