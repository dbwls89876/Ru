#include <iostream>
using namespace std;
//????????????????
int main(){
	long n, i, r;
	cin>>n;
	
	for(i = 0, r = 0; i<n;){
		r++;
		i+=r;
	}
	if(r%2==1)	
		cout<<i-n+1<<"/"<< r-(i-n);
	else
		cout<<r-(i-n)<<"/"<<i-n+1;
}
