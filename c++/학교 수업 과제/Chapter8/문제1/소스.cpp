#include <iostream>
using namespace std;


int main() {
	int num;
	cout << "�󸶳� ���� �̸��� �Է� �Ͻðڽ��ϱ�? ";
	cin >> num;
	string *arr = new string[num]; // �����迭 ����
	for (int i = 0; i < num; i++) {
		cout << "�̸� �Է� # " << i+1 << ": ";
		cin >> arr[i]; // ���� �迭 �Է¹�İ� ����
	}
	cout << endl;
	cout << "������ �̸� ����Դϴ�" << endl;
	for (int i = 0; i < num; i++)
		cout << "�̸� # "<<i+1<<": "<< arr[i] << endl; // �迭�� ��� ���� ���

	return 0;
}