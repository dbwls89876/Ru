#include <iostream>
#include <time.h>
using namespace std;

int main() {
	double cash = 50;
	int bets = 0, win = 0;
	srand(time(NULL));
	cout << "�ʱ� �ݾ� $" << cash << endl;
	cout << "��ǥ �ݾ� $250" << endl;
	while (true) { // �¸��ҽ� 1������ �й��ҽ� 1������
		bets++; // ����Ƚ��
		if ((double)rand() / RAND_MAX < 0.5) { // �ݹ��� Ȯ���� ��/��
			win++; // �¸�Ƚ��
			cash++; 
		}
		else
			cash--; 
		
		if (cash == 250 || cash == 0) // ��ǥ�ݾ׿� ���� �Ǵ� �Ļ��ҽ� ����
			break;
	}
	cout << bets << " ���� " << win << "�� �¸�" << endl;
	cout << "�̱� Ȯ�� = " << (win / (double)bets)*100 << endl;
	return 0;
}