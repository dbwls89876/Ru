#include <iostream>
using namespace std;

int main() {
	for (int i = 1; i <= 7; i++) {
		for (int j = 1; j <= 7; j++) {
			if (i >= j) { // j�� i���� ������ j�� ���
				cout << j;
				continue; // ���ǽ����� ���ư��鼭 j�ǰ�����
			}
			cout << '*'; // i�� j���� Ŭ�� * ���
		}
		cout << endl; // �ѹ�������� ����
	}
}