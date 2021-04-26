#include <iostream>
using namespace std;

int main(){
	int arr[10] = {0}, a[3], n, check;
	for(int i = 0; i<3; i++)
		cin>>a[i];
	n = a[0]*a[1]*a[2];
	
	while(n){	
		arr[n%10] += 1;
		
		n/=10;
	}

	for(int i = 0; i<10; i++)
		cout<<arr[i]<<"\n";
	
	return 0;
}
