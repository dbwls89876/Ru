#include <iostream>
using namespace std;
//���丮��? 
int main(){
	int n, i, r;
	cin>>n;
	
	for(i = 1; n>0; i++){
		r = n%i;
		n/=i;
	}
	cout<<i<<"/"<< r ;
}
