#include <iostream>
using namespace std;

int sequence(int n){
	int count = 0, n;
	for(int i = 1; i<=n; i++){
		int arr[10];
		n = 0;
		int j=i;//내일확인하 
		for(int k = 0; j; k++){
			arr[k] = j%10;
			j/=10;
			n++;
		}기 
		for(int k = 1; k<10; k++){
			for(int l = 1; l<n; l++){
				if((arr[l-1] % k) != (arr[l] % k))
					break;
				if(l==(n-1))
					count++;
			}
		}
		
	}
}

int main(){
	
}
