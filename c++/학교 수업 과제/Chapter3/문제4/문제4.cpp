#include <iostream>
using namespace std;
void prime(int n) {
	int count = 0;
	for (int i = 2; i < n; i++) { // 1�� n�� ������ ����
		if (n%i == 0) {
			count++; // 1�� n �̿��� ���� �������������� count���
			break; // ����������̱�
		}
	}
	if (count == 0) // count�� ���������ʾ����� ���
		cout << n<<" ";

}
int main() {
	for (int i = 2; i <= 100; i++) // 2���� 100������ �����߿��� �Ҽ� �Ǻ�
		prime(i);
	cout << endl;
}