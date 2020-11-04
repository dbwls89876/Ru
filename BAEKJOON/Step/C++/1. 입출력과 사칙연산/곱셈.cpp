#include <iostream>
using namespace std;

int main(){
	int i, j;
	cin>>i;
	cin>>j;
	cout<<(j%10)*i<<"\n";
	cout<<(((j%100)-(j%10))*i)/10<<"\n";
	cout<<((j-(j%100))*i)/100<<"\n";
	cout<<i*j<<"\n";
	
	return 0;
}
