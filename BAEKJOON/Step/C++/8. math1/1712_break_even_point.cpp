#include <cstdio>
using namespace std;

int main(){
	long a, b, c;
	int cnt = 0;
	scanf("%d", &a);
	scanf("%d", &b);
	scanf("%d", &c);

	if(b>=c) cnt=-1;
	else{
		c-=b;
		cnt = (a/c)+1;
	}
	printf("%d", cnt);
}
