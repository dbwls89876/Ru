#include <cstdio>
using namespace std;

int main(){
	long a, b, c;
	long n;
	int cnt;
	scanf("%d", &a);
	scanf("%d", &b);
	scanf("%d", &c);
	
	n = a;
	if(b>=c)
		cnt = -1;
	else{
		c-=b;
		while(n){
			n-=c;
			cnt++;
		}
	}
	printf("%d", cnt);
}
