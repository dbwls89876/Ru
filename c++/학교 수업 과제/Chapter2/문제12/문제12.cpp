#include <iostream>
using namespace std;

int main() {
	for (int i = 1; i <= 100; i++) {
		cout << i << " "; // i�� ������� ���
		if (i % 3 == 0)
			cout << "�ڼ�" << " "; // 3�� ����϶� �ڼ� ���
	}
	cout << endl;
	return 0;
}