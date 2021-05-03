#include <iostream>
using namespace std;

int main(){
	int x1, x2, x3;
	int y1, y2, y3;
	
	cin >> x1 >> y1;
	cin >> x2 >> y2;
	cin >> x3 >> y3;
	
	int a, b;
	
	if(x1 == x2)
		a = x3;
	else if(x1 == x3)
		a = x2;
	else
		a = x1;
	
	if(y1 == y2)
		b = y3;
	else if(y1 == y3)
		b = y2;
	else
		b = y1;
	
	cout << a << " " << b;
	return 0;
}
