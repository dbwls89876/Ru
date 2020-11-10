#include <iostream>
using namespace std;

int main(){
	int n, sum = 0;
	char arr[101];
	cin>>n;
	for(int i = 0; i<n; i++)
		cin>>arr[i];
	for(int i = 0; i<n; i++){
		sum += (arr[i]-'0');
	}
	cout<<sum;
	return 0;
}
