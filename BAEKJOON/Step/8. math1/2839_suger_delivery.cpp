#include <iostream>

using namespace std;

int main(){
	int n;
	int e5, e3;
	cin>>n;
	int tmp = n;
	for(int i = 0; i*5<tmp; i++){
		if(n>0){
			n = tmp;
			e5 = n/5;
			n %= 5;
			e5 -= i;
			n += (i*5);
			e3 = n/3;
			n %= 3;
		}
		else
			break;
	}
	
	if(n>0){
		cout<<-1;
	}
	else{
		cout<<e5+e3;
	}
}
