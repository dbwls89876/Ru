#include <iostream>
using namespace std;

int main(){
	int h, w, p, n;
	cin>>n;
	for(int i = 0; i<n; i++){
		cin>>h;
		cin>>w;
		cin>>p;
		if(p%h == 0)
			cout<<h*100+(p/h)<<"\n";
		else	
			cout<<((p%h)*100)+(p/h+1)<<"\n";
		}
	return 0;
}
