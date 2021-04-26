#include <iostream>
using namespace std;

int main(){
	int n, a, b;
	int num[100];
	cin>>n;
	for(int i=0; i<n; i++){
		cin>>a;
		cin>>b;
		num[i]=a+b;
	}
	
	for(int i = 0; i<n; i++)
		cout<<num[i]<<endl;
		
	return 0;
}
