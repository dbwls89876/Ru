#include <iostream>
using namespace std;

int main() {
	int n, sum = 0;
	cout << "n�� ���� �Է��Ͻÿ� : ";
	cin >> n;
	for (int i = 1; i <= n; i++) 
		sum += (i*i); // n������ i^2�� sum�� ����
	cout << "��갪�� " << sum << "�Դϴ�." << endl;
}	