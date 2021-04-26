#include <iostream>
#include <string>
#include <cstring>

using namespace std;

int main(){
	string str[100];
	char a;
		
	int n, score = 0, s = 0;
	cin.tie(NULL);
	cin>>n;
	for(int i = 0; i<n; i++)
		cin>>str[i];
	
	for(int i = 0; i<n; i++){
		score = 0;
		s=0;
		for(int j = 0; j<str[i].length(); j++){
			a = str[i].at(j);
			if(a=='X'){
				s=0; continue;
			}
			else{
				s+=1;
				score += s;
			}
			
		}
		cout<<score<<"\n";
	} 
	return 0;
} 


