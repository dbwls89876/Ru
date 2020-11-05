#include <iostream>
using namespace std;
//시간초과 
int main(){
	int n, a, b, i=0;
	a=n;
	cin.tie(NULL);
	
	cin>>n;
	a = n;
	do{		
		b=a;	
		if(a>=10)
			b = (a/10)+(a%10);			
		a = (a%10*10)+(b%10);
		i++;		
	}while(n!=a);
	
	printf("%d", i);
	return 0;
}
