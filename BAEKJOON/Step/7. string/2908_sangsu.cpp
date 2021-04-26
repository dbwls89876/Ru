#include <iostream>
#include <cstdlib>
using namespace std;

int reverse(int n){
	char tmp[3];
	int r;
	for(int i = 0; i<3; i++){
		tmp[i] = (('0'+n%10));
		n/=10;
	}
	r = atoi(tmp);
	return r;
}

int main(){
	int a, b;
	cin>>a;
	cin>>b;
	int big;
	a = reverse(a); b = reverse(b);
	
	if(a>b)
		big=a;
	else
		big=b;
	cout<<big;
}
