#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int n, count;
	cin>>n;
	
	for(int i = 0; i<n; i++)
		
	
	for(int i = 0; i<n; i++){
		char arr[100];
		char alphabet[26] = {0};
		
		cin>>arr[i];
		for(int j = 0; j<strlen(arr); j++){
			
			if(alphabet[arr[i]-'a']==0)
				alphabet[arr[i]-'a']=i;
			else if(alphabet[arr[i]-'a']>0){
				if(alphabet[arr[i-1]==alphabet[i]]){
					alphabet[arr[i]-'a']=i;				
				}
				else{
					alphabet[arr[i]-'a']=-1;
				}
			}
			for(int j = 0; j<26; i++){
				if(alphabet[j]<0)
					break;		
				if(j==25)
					count++;
				}
		}
		
	}
	
	cout<<count<<"\n";
	return 0;
}
