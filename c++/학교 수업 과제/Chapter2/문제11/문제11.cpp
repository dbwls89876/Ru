#include <iostream>
using namespace std;

int main() {
	int n, sum = 0;
	cout << "n의 값을 입력하시오 : ";
	cin >> n;
	for (int i = 1; i <= n; i++) 
		sum += (i*i); // n까지의 i^2를 sum에 더함
	cout << "계산값은 " << sum << "입니다." << endl;
}	