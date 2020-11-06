#include <iostream>
using namespace std;

int selfNum(int n){
	int result = n;
	while(n){
		result += (n%10);
		n/=10;
	}
	return result;
}
int main(){
	int arr[10000] = {0}, n;
	for(int i = 1; i<10000; i++){
		n = selfNum(i);
		if(n<10000)
			arr[n] = n;
	}
	
	for(int i = 1; i<10000; i++){
		if(arr[i]==0)
			cout<<i<<"\n";
	}
	
	return 0;
}
