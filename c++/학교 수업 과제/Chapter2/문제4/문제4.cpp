#include <iostream>
using namespace std;

int main() {
	int num, cnt = 0;
	
	cout << "5를 5번 입력해주세요" << endl; // 5를입력하도록 요청
	for (int i = 0; i < 5; i++) {
		if (i > 0)
			cout << "5를 입력해주세요" << endl; // 계속입력하도록 요청
		cin >> num;
		if (num == 5)
			cnt++; // 5를입력했을때 카운트가 1올라감
	}

	if (cnt > 0) // count가 1이상일때 출력
		cout << "5를 입력하였군요! 컴퓨터 승" << endl;
	else // 카운트가 1이상이 아닐때 출력
		cout << "인내심이 강합니다. 사용자 승" << endl;

	return 0;
}