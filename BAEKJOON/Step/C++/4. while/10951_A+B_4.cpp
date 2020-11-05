#include <iostream>
using namespace std;

int main(){
	int a, b;
	
	while(1){
		cin>>a;
		cin>>b;
		if(cin.eof())
			break;
		cout<<a+b<<"\n";
}
	return 0;
}
