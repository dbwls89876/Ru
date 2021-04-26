#include <iostream>
#include <cstring>
using namespace std;

int main(){
	char arr[1000000];
	int count = 0;
	cin.getline(arr, 1000000, '\n');
	
	if(arr[0]>='A'&&arr[0]<='z'){
			count++;
		}
	for(int i = 1; i<strlen(arr); i++){
		if(arr[i-1]==' '&&arr[i]>='A'&&arr[i]<='z'){
			count++;
		}
	}
	cout<<count;
	return 0;
}
