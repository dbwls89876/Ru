#include <iostream>
using namespace std;

int main() {
	int n=0, n1=0, n2 = 1, temp=0;
	cout << "�� �ױ��� ���ұ�� : ";
	cin >> n;
	for (int i = 0; i < n-2; i++) { // ù��° ���� 0, 1�� ����
		if (i == 0)
			cout << n1 << ", " << n2;
		temp = n1 + n2; // ���Ѱ��� �ӽ÷� ����
		n1 = n2; // n2�� ���� n1���� �ű�
		n2 = temp; // ���Ѱ��� n2�� ����
		cout << ", " << temp;
	}
	cout << endl;
	return 0;
}