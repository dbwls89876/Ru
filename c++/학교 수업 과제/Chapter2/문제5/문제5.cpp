#include <iostream>
using namespace std;

int main() {
	int num = 0, sum = 0;
	for (; ;) { // ������ ���⿡ ���ѷ���
		cout << "������ �Է��Ͻÿ� : ";
		cin >> num;
		if (num == 0) // 0�� �Է��ϸ� �ݺ��� ����
			break;
		sum += num; // num�� ���� sum�� ���Ѵ�
	}
	cout << "�հ� : " << sum << endl; // ���հ� ���
}