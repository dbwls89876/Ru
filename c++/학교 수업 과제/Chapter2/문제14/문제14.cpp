#include <iostream>
using namespace std;

int main() {
	int n1, n2, result=0;
	char c;
	cout << "������ ���� : ";
	cin >> c;
	cout << "���ڸ� �Է��Ͻÿ� : ";
	cin >> n1 >> n2;
	if (c == '+') // ���ϱ�
		result = n1 + n2;
	else if (c == '-') // ����
		result = n1 - n2;
	else if (c == '*') // ����
		result = n1 * n2;
	else if (c == '/') // ������
		if (n2 == 0) 
		cout << "���� �� �����ϴ�." << endl; // n2�� 0�ϰ�� ����ǥ���� ���α׷�����
		else
			result = n1 / n2;
	if((c!='/')||(n2!=0))
	cout << "����� ��� : " << result << endl;

	return 0;
}