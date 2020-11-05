#include <iostream>
using namespace std;

int main(){
	int n;
	cin>>n;
	
	for(int j = n; j; j--){
		for(int i = 1; i<=n; i++){
			if(i>=j){
				cout<<"*";continue;
			}
			cout<<" ";
		}
		cout<<"\n";
	}
	return 0;
}
