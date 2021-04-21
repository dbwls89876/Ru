#include <iostream>
using namespace std;
void prime(int n) {
	int count = 0;
	for (int i = 2; i < n; i++) { // 1과 n을 제외한 숫자
		if (n%i == 0) {
			count++; // 1과 n 이외의 수로 나뉘어져있을때 count상승
			break; // 연산과정줄이기
		}
	}
	if (count == 0) // count가 증가하지않았을때 출력
		cout << n<<" ";

}
int main() {
	for (int i = 2; i <= 100; i++) // 2부터 100까지의 숫자중에서 소수 판별
		prime(i);
	cout << endl;
}