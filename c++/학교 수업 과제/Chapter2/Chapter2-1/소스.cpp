#include <iostream>
#include <string> // ��Ʈ�� �Լ��� ����ϱ����� �ҷ��� �������
using namespace std;

int main() {
	string s1;
	string s2;
	cout << "ù ��° ���ڿ� : ";
	cin >> s1;
	cout << "�� ��° ���ڿ� : ";
	cin >> s2;
	if (s1 == s2) // �ΰ��� ���ڿ��� ���ؼ� �����ÿ� ����
		cout << "2���� ���ڿ��� �����ϴ�" << endl;
	else // ���������ÿ� ����
		cout << "2���� ���ڿ��� �ٸ��ϴ�" << endl;
	return 0;
}