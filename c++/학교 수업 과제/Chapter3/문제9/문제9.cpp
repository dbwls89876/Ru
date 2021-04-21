#include <iostream>
#include <time.h>
using namespace std;

int Rand_dice();
void win_or_defeat(int n);

int main() {
	srand(time(NULL));
	int dice1 = Rand_dice()+1; // 주사위값 1~6
	int dice2 = Rand_dice()+1;
	int result = dice1 + dice2; // 두 다이스를 합한 값
	
	cout << "사용자의 주사위 : " << dice1 << "+" << dice2 << "=" << result << endl;
	win_or_defeat(result); // 누가 승리하였는지 메세지 출력
	return 0;
}

int Rand_dice() { return rand() % 6; } //  5이하의 숫자중 난수 발생
void win_or_defeat(int n) {
	if (n == 7 || n == 11) // 두 주사위의 합이 7이나 11일시에 사용자승리
		cout << "사용자가 이겼습니다." << endl;
	else if (n == 2 || n == 3 || n == 12) // 합이 2, 3, 12 일때 컴퓨터 승리
		cout << "사용자가 졌습니다." << endl;
	else // 아무도 이기지못했을때
		cout << "그 누구도 승리하지 않았습니다." << endl;
}