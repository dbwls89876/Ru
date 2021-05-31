#include <stdio.h>
#include <algorithm>
#include <vector>
using namespace std;
int main(){
	int n;
	scanf("%d", &n);
	vector<int> arr;
	
	for(int i = 0; i<n; i++){
		int num;
		scanf("%d", &num);
		arr.push_back(num);
	}
	
	std::sort(arr.begin(), arr.end());
	
	for(int i = 0; i<n; i++)
		printf("%d\n", arr[i]);
	
	return 0;
}
