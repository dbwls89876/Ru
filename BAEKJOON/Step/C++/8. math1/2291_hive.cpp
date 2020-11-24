#include <iostream>
#include <cmath>
using namespace std;

int main(){
	int n, i, cnt=1;
	cin>>n;
	n-=1;
	for(i = 1; n>0; i++, cnt++){
		n-=6*i;
	
	}
	cout<<cnt;
}
