#include <iostream>
using namespace std;

int main(){
	int h, m;
	cin>>h;
	cin>>m;
	
	if(h==0&&m<45){
		h=23; m = m+60-45;	
	}
	else if(m>=45)
		m-=45;
	else{
		h-=1; m = m+60-45;
	}
		
	cout<<h<<" "<<m<<endl;
	
	return 0;
}
