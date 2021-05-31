#include <stdio.h>
#include <algorithm>
#include <vector>
using namespace std;

bool desc(int a, int b){
	return a>b;
}

int main(){
	char n[11]; 
	scanf("%s", &n);
	vector<int> arr;
	
	for(int i = 0; n[i]>='0'&&n[i]<='9'; i++){
		arr.push_back(n[i]-'0');
	}
	
	std::sort(arr.begin(), arr.end(), desc); // 내장함수
	
	for(int i = 0; i<arr.size(); i++)
		printf("%d", arr[i]);
	
	return 0;
}
