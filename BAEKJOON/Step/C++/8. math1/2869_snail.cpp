#include <iostream>
using namespace std;

int main(){
	long a, b, v;
	cin>>a;
	cin>>b;
	cin>>v;
	if((v-a)%(a-b)==0)
	cout<<((v-a)/(a-b))+1;
	else
	cout<<((v-a)/(a-b))+2;
	return 0;
}
