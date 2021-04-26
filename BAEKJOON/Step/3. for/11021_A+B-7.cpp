#include <iostream>

using namespace std;

int main(){
	int n, a, b;
	cin>>n;
	
	for(int i = 1; i<=n; i++){
		cin>>a; cin>>b;
		cout<<"Case #"<<i<<": "<<a+b<<"\n";
	}
	
	return 0;
}
