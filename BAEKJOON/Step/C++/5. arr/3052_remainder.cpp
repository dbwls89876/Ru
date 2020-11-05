#include <iostream>
using namespace std;

int main(){
	int arr[10], n, count = 0;
	cin.tie(NULL);
	for(int i = 0; i<10; i++){
		cin>>n;
		arr[i] = n%42;
	}
	
	for(int i = 0; i<10; i++){
		int n = 0;
		for(int j = i+1; j<10; j++){
			if(arr[i] == arr[j]){
				n++;break;
			}
		}
		if(n<1)
			count++;
	}
	cout<<count<<"\n";
}
