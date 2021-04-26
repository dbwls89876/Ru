#include <iostream>
#include <cstring>
using namespace std;

int main(){
	char c[15];
	int count = 0;
	
	cin>>c;
	for(int i = 0; i<strlen(c); i++){
		if(c[i]>='A'&&c[i]<='C')
			count+=3;
		else if(c[i]<='F')
			count+=4;
		else if(c[i]<='I')
			count+=5;
		else if(c[i]<='L')
			count+=6;
		else if(c[i]<='O')
			count+=7;
		else if(c[i]<='S')
			count+=8;
		else if(c[i]<='V')
			count+=9;
		else if(c[i]<='Z')
			count+=10;
	}
	cout<<count<<"\n";
}
