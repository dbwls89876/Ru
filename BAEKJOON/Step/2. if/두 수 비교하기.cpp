#include <iostream>
using namespace std;

int main(){
	int i, j;
	cin>>i;
	cin>>j;
	
	if(i>j)
		cout<<">";
	else if(i<j)
		cout<<"<";
	else if(i==j)
		cout<<"==";
		
	return 0;
	
}
