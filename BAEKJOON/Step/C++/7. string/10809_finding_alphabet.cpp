#include <iostream>
#include <cstring>
using namespace std;

int main(){
	char arr[100];
	int az[26];
	for(int i = 0; i<26; i++)
		az[i] = -1;
	cin>>arr;
	for(int i = 0; i<strlen(arr); i++){
		if(az[(arr[i])-'a']!=-1)
			continue;
		az[(arr[i])-'a'] = i;
	}
	for(int i = 0; i<26; i++){
		cout<<az[i]<<" ";
	}
	return 0;
}
