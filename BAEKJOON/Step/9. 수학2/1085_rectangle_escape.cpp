#include <iostream>
using namespace std;

int main(){
	int x, y, w, h;
	cin>>x;
	cin>>y;
	cin>>w;
	cin>>h;
	int a, b, min;
	
	if((x*2)>w)
		a = w-x;
	else
		a = x;
	
	if((y*2)>h)
		b = h-y;
	else
		b = y;
	
	if(a>b)
		min = b;
	else
		min = a;
	cout<<min;
	
	return 0;
}
