#include <iostream>
#include <sstream>
using namespace std;

int main(){
	int n;
	stringstream str;
	cin>>n;
	for(; n; n--)
		str<<n<<"\n";
	cout<<str.str()<<"\n";
	return 0;
}
