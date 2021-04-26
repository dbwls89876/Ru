#include <iostream>
using namespace std;

int main(){
	int i;
	cin>>i;
	
	if(i>=90&&i<=100)
		cout<<"A";
	else if(i<=89&&i>=80)
		cout<<"B";
	else if(i<=79&&i>=70)
		cout<<"C";
	else if(i<=69&&i>=60)
		cout<<"D";
	else
		cout<<"F";
	return 0;
}
