#include <iostream>
using namespace std;
#define __STDC_NO_VLA__

int main(){
	int n;
	double arr[1000], max = 0, result=0;
	
	cin>>n;
	
	for(int i = 0; i<n; i++){
		cin>>arr[i];
		if(arr[i]>max)
			max = arr[i];
	}
	
	for(int i = 0; i<n; i++){
		arr[i] = arr[i]/max*100;
	}
	
	for(int i = 0; i<n; i++)
		result +=arr[i];
	result/=n;
	
	cout.precision(6);
	cout<<result<<"\n";
	
	return 0;
}
