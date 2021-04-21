#include <iostream>
using namespace std;

int main() {
	int num;
	cout << "정수를 입력하시오 : ";
	cin >> num;
	for (int i = 1; i <= num; i++) { // 0으로설정하면 오류가생기기때문에 1로 설정	
		if (num%i == 0)
			cout << i << " "; // num을 i로 나눈 나머지가 0일때 i를 출력
	}
	cout << endl;
}