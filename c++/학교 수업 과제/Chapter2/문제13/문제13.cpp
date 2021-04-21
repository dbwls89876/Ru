#include <iostream>
using namespace std;

int main() {
	int n=0, n1=0, n2 = 1, temp=0;
	cout << "몇 항까지 구할까요 : ";
	cin >> n;
	for (int i = 0; i < n-2; i++) { // 첫번째 숫자 0, 1을 제외
		if (i == 0)
			cout << n1 << ", " << n2;
		temp = n1 + n2; // 더한값을 임시로 저장
		n1 = n2; // n2의 값을 n1으로 옮김
		n2 = temp; // 더한값을 n2에 저장
		cout << ", " << temp;
	}
	cout << endl;
	return 0;
}