#include <iostream>
#include <time.h>
using namespace std;
int Random_MAX();

int main() {
	int max = Random_MAX();
	cout << "���� ���� ������ �� : " << max << endl;
	return 0;
}

int Random_MAX() {
	srand(time(NULL)); // �ð��� ����ɶ����� �ٸ��� ����
	int num[10] = {0}; // �迭�� 0�����ʱ�ȭ
	
	for (int i = 0; i < 100; i++) {
		int random = rand() % 10; // 9������ ���� �߻�
		for (int j = 0; j<10; j++)
			if(j==random) // j�� random�� ���� �����Ҷ� �ش�Ǵ¹迭�� ����
				num[j]++;
	}
	int temp = num[0], max=0; // �񱳰� �ʱ�ȭ �� ū ���� ����
	for (int i = 1; i < 10; i++) {
		if (num[i] > temp){ // temp�� ���� num[i]���� ������ num[i]�� ����
			temp = num[i]; 
			max = i; // �ش�Ǵ� i�� ���� ���
		}
	}
	return max; // ���� ���� ������ �� ��ȯ
}