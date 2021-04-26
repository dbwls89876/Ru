#include <iostream>
using namespace std;
//시간초과 
int main(){
	int n, b, c, d, r, i=0;
	cin.tie(NULL);
	
	cin>>n;
	r = n;
	if(n<10&&n>0){
		n+=10;i++;
	}
	else if(n==0)
		i++;
	while(n){
		b=n%10;			
		c = ((n-b)/10)+b;		
		if(c>=10)
			c-=10;		
		d=(b*10)+c;	
		n=d;
		i++;		
		if(n==r)
			break;
	} 
	printf("%d", i);
	return 0;
}
