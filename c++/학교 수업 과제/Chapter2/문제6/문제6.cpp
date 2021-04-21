#include <iostream>
using namespace std;

int main() {
	for (int i = 1; i <= 7; i++) {
		for (int j = 1; j <= 7; j++) {
			if (i >= j) { // j가 i보다 작을때 j를 출력
				cout << j;
				continue; // 조건식으로 돌아가면서 j의값증가
			}
			cout << '*'; // i가 j보다 클때 * 출력
		}
		cout << endl; // 한문장출력후 엔터
	}
}