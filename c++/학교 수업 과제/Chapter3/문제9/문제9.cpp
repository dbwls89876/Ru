#include <iostream>
#include <time.h>
using namespace std;

int Rand_dice();
void win_or_defeat(int n);

int main() {
	srand(time(NULL));
	int dice1 = Rand_dice()+1; // �ֻ����� 1~6
	int dice2 = Rand_dice()+1;
	int result = dice1 + dice2; // �� ���̽��� ���� ��
	
	cout << "������� �ֻ��� : " << dice1 << "+" << dice2 << "=" << result << endl;
	win_or_defeat(result); // ���� �¸��Ͽ����� �޼��� ���
	return 0;
}

int Rand_dice() { return rand() % 6; } //  5������ ������ ���� �߻�
void win_or_defeat(int n) {
	if (n == 7 || n == 11) // �� �ֻ����� ���� 7�̳� 11�Ͻÿ� ����ڽ¸�
		cout << "����ڰ� �̰���ϴ�." << endl;
	else if (n == 2 || n == 3 || n == 12) // ���� 2, 3, 12 �϶� ��ǻ�� �¸�
		cout << "����ڰ� �����ϴ�." << endl;
	else // �ƹ��� �̱�����������
		cout << "�� ������ �¸����� �ʾҽ��ϴ�." << endl;
}