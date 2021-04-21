#include <iostream>
#include <vector>
using namespace std;

class Game {
private:
	static int count;
public:
	Game() {
		count++;
	}
	~Game() { count--; }
	static int getCount() { return count; }
};

int Game::count = 0;

void Re() {
	for (;;) {
		int n;
		cout << "경기자생성 1, 경기자제거 0 (종료 Ctrl+c): ";
		cin >> n;
		if (n == 1) {
			Game player;
			cout << "현재 경기자수 : " << Game::getCount() << endl;
			Re();
		}
		else
			break;
		cout << "현재 경기자수 : " << Game::getCount() << endl;
	}
}

int main() {
	Re();
	return 0;
}