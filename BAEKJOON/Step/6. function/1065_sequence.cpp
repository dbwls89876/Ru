#include <iostream>
using namespace std;

int sequence(int n){
	int count = 0;
	for(int i = 1; i<=n; i++){
		int num = i, arrCount = 0, arr[10];
		
		for(int j = 0; num; j++){
			arr[j] = num%10;
			num/=10;
			arrCount++;
		}
	
		if(i<100){
				count++;continue;
			}
			
		int diff = arr[0]-arr[1];
		int diffCount = 1;
		for(int j = 2; j<arrCount; j++){
		
			if(diff==(arr[j-1]-arr[j])){
				diffCount++;		
			}
			if(diffCount == (arrCount-1)){
			count++;break;
			}			
		}
		
	}
	
	return count;
}

int main(){
	int n;
	cin>>n;
	cout<<sequence(n)<<"\n";
	return 0;
}
