#include <iostream>
#include <string>
using namespace std;

int main() {
	string drink[] = { "�ݶ�", "��", "��������Ʈ", "�ֽ�", "Ŀ��" }; // ���迭�� ����� ����
	int i;
	cout << "�ݶ�, ��, ��������Ʈ, �ּ�, Ŀ�� �߿��� �ϳ��� �����ϼ��� : ";
	cin >> i; // ����ڷκ��� ������ǹ�ȣ�� �Է¹޴´�
	switch (i -= 1) {
	case 0 : case 1 : case 2 : case 3 : case 4 : // ���ᰡ ����ִ� �迭 ��ȣ�� ����
		cout << drink[i] << "�� �����Ͽ����ϴ�." << endl; // i�κ��� ���� ���ڿ� �ش�Ǵ� ���� ���
		break; // default���� ���������� break��
	default :
		cout << "����. ������ ��ȿ���� �ʽ��ϴ�. ���� ��ȯ�մϴ�." << endl; // case�� �ش���������ÿ� ���
	}

	return 0;
}