#include <iostream>
#include <time.h>
using namespace std;

int main() {
	int user, computer, result;
	srand(time(NULL)); // rand�Լ� �ʱ�ȭ
	computer = (rand() % 3)+1;
	cout << "����, ����, �� �߿� �ϳ��� �����Ͻÿ�(1, 2, 3) : ";
	cin >> user;
	cout << "��ǻ�� : " << computer << endl;
	if (user == computer) // (-1) = ���, 0 = �й�, 1 = �¸�
		result = -1; 
	else if (user == 1) { // ����
		if (computer == 2)
			result = 0;
		else
			result = 1;
	}
	else if (user == 2) { // ����
		if (computer == 3)
			result = 0;
		else
			result = 1;
	}
	else if (user == 3) { // ��
		if (computer == 1)
			result = 0;
		else
			result = 1;
	}
	
	if (result == 1) // ����� ���� ���� ���
		cout << "����� ��!" << endl;
	else if(result == 0)
		cout << "��ǻ�� ��!" << endl;
	else
		cout << "�����ϴ�" << endl;
	return 0;
}