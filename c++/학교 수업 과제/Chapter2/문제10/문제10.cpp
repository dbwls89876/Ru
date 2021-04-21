#include <iostream>
using namespace std;

int main() {
	for(int i=1; i<100; i++)
		for(int j=1; j<100; j++)
			for (int k = 1; k < 100; k++) { // 3중 반복문
				if ((k*k) + (j*j) == (i*i)) // 피타고라스의 정리가 성립하는 숫자 확인
					cout << k << " " << j << " " << i << endl;
			}
	return 0;
}