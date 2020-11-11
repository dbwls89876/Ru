#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int n, cNum;
	cin>>n;
	
	for(int i = 0; i<n; i++){
		char arr [20];
		cin>>cNum;
		cin>>arr;
		for(int j = 0; j<strlen(arr); j++){
			for(int k = 0; k<cNum; k++)
				cout<<arr[j];
		}
		cout<<"\n";
	}
}
