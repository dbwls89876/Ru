#include <iostream>
#include <vector>
using namespace std;

long long sum(std::vector<int> &a) {
	long long ans = 0;
	for(int i = 0; i<a.size(); i++)
		ans += a[i];
	return ans;
}

int main(){
	vector<int> v;
	v.push_back(1);
	v.push_back(2);
	int result;
	
	result = sum(v);
	cout<<result<<endl;
	return 0;
}



