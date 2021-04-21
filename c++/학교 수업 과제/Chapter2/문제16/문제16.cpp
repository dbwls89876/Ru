#include <iostream>
#include <time.h>
using namespace std;

int main() {
	double cash = 50;
	int bets = 0, win = 0;
	srand(time(NULL));
	cout << "초기 금액 $" << cash << endl;
	cout << "목표 금액 $250" << endl;
	while (true) { // 승리할시 1원증가 패배할시 1원감소
		bets++; // 베팅횟수
		if ((double)rand() / RAND_MAX < 0.5) { // 반반의 확률로 승/패
			win++; // 승리횟수
			cash++; 
		}
		else
			cash--; 
		
		if (cash == 250 || cash == 0) // 목표금액에 도달 또는 파산할시 중지
			break;
	}
	cout << bets << " 중의 " << win << "번 승리" << endl;
	cout << "이긴 확률 = " << (win / (double)bets)*100 << endl;
	return 0;
}