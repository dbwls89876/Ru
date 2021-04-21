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
		cout << "����ڻ��� 1, ��������� 0 (���� Ctrl+c): ";
		cin >> n;
		if (n == 1) {
			Game player;
			cout << "���� ����ڼ� : " << Game::getCount() << endl;
			Re();
		}
		else
			break;
		cout << "���� ����ڼ� : " << Game::getCount() << endl;
	}
}

int main() {
	Re();
	return 0;
}