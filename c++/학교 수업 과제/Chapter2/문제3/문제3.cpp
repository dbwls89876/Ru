#include <iostream>
using namespace std;

int main() {
	int days[] = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // ���� �ִ��ϼ� ����
	for (int i = 1; i <= 12; i++) {
		cout << i << "���� " << days[i - 1] << "�ϱ��� �ֽ��ϴ�." << endl; // ���� �ش�Ǵ� �ϼ� ���
	}
	
	return 0;
}