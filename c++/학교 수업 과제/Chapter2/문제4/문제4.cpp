#include <iostream>
using namespace std;

int main() {
	int num, cnt = 0;
	
	cout << "5�� 5�� �Է����ּ���" << endl; // 5���Է��ϵ��� ��û
	for (int i = 0; i < 5; i++) {
		if (i > 0)
			cout << "5�� �Է����ּ���" << endl; // ����Է��ϵ��� ��û
		cin >> num;
		if (num == 5)
			cnt++; // 5���Է������� ī��Ʈ�� 1�ö�
	}

	if (cnt > 0) // count�� 1�̻��϶� ���
		cout << "5�� �Է��Ͽ�����! ��ǻ�� ��" << endl;
	else // ī��Ʈ�� 1�̻��� �ƴҶ� ���
		cout << "�γ����� ���մϴ�. ����� ��" << endl;

	return 0;
}