#include <iostream>
using namespace std;

int main() {
	for(int i=1; i<100; i++)
		for(int j=1; j<100; j++)
			for (int k = 1; k < 100; k++) { // 3�� �ݺ���
				if ((k*k) + (j*j) == (i*i)) // ��Ÿ����� ������ �����ϴ� ���� Ȯ��
					cout << k << " " << j << " " << i << endl;
			}
	return 0;
}