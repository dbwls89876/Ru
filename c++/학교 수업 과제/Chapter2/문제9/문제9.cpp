#include <iostream>
using namespace std;

int main() {
	double f = 10.0;
		for (int i = 0; i <= 10; i++) { 
			double c = ((f*i) - 32.0)*5.0 / 9.0; // È­¾¾¸¦ ¼·¾¾·Î ¹Ù²Ù´Â ½Ä
			cout << f * i << "                " << c << endl; // ¼·¾¾ Ãâ·Â
	}
	return 0;
}