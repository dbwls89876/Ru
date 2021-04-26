#include <iostream>
#include <string.h>
using namespace std;

int main(){
	int t;
	int k, n; // Ãþ, È£ 
	int arr[15];
	int temp[15];
	cin>>t;

	
	for(int l = 0; l<t; l++){
		cin>>k;
		cin>>n;
		for(int i = 0; i<n; i++){
			arr[i] = i+1;
		}		
		if(k>0){
			for(int i = 0; i<k; i++){
				for(int j = 1; j<n; j++){
					copy(arr, arr+15, temp);
					arr[j]=arr[j-1]+temp[j];
				}
			}
		}
		cout<<arr[n-1]<<"\n";
	}
	
		
}
