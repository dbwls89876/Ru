#include <iostream>
using namespace std;

int main() {
	int num;
	cout << "������ �Է��Ͻÿ� : ";
	cin >> num;
	for (int i = 1; i <= num; i++) { // 0���μ����ϸ� ����������⶧���� 1�� ����	
		if (num%i == 0)
			cout << i << " "; // num�� i�� ���� �������� 0�϶� i�� ���
	}
	cout << endl;
}