#include <iostream>
using namespace std;

int main(){
	long a, b, c;
	int result;
	cin.tie(false);
	cin>>a;
	cin>>b;
	cin>>c;
	
	if(b>c)
		result = -1;
	else{
		for(result = 1; ;result++){
		if((a+b*result)<c*result)
			break;
		}
	}
	cout<<result;
}
