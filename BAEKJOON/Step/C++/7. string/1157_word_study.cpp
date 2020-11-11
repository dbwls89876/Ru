#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int alphabet[26] = {0};
	int dup=0, max=0, check = 0;
	char arr[1000000];
	cin>>arr;
	for(int i = 0; i<strlen(arr); i++){
		if(arr[i]>='A'&&arr[i]<='Z')
			alphabet[arr[i]-'A']++;
		else if(arr[i]>='a'&&arr[i]<='z')
			alphabet[arr[i]-'a']++;
	}
	
	for(int i = 0; i<sizeof(alphabet)/sizeof(int); i++){
		if(alphabet[i] == max&&alphabet[i]!=0){
			dup = 1;
		}
		else if(alphabet[i]>max){
			max = alphabet[i]; dup = 0;
			check = i;
		}
		
	}
	if(dup == 1)
		cout<<"?"<<"\n";
	else{
		cout<<(char)(check+'A')<<"\n";
	}
		
	return 0;
}
