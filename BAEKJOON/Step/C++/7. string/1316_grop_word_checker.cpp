#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int n, count;
	cin>>n;

	for(int i = 0; i<n; i++){
		char arr[100];
		int alphabet[26] = {0};
		
		cin>>arr;
		for(int j = 0; j<strlen(arr); j++){
			if(alphabet[arr[j]-'a']==0)
				alphabet[arr[j]-'a']++;
			else if(alphabet[arr[j]-'a']>0){
				if((arr[j-1])==arr[j]){
					continue;			
				}
				else{
					alphabet[arr[j]-'a']=-1;
				}
			}
		}
		
		for(int j = 0; j<26; j++){		
			if(alphabet[j]<0)
				break;
			if(j==25)
				count++;
		}
	}
	
	cout<<count<<"\n";
	return 0;
}
