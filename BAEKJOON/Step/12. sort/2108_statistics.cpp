#include <stdio.h>
#include <algorithm>
#include <vector>
using namespace std;
int main(){
	int arr[8001] = {0};
	int n;
	scanf("%d", &n);
	for(int i = 0; i<n; i++){
		int num;
		scanf("%d", &num);
		arr[num+4000];
	}
	int mid, min = 4000, max = -4000 ,check = 0;
	double avg;
	for(int i = 0; i<8001; i++){
		while(arr[i]){
			printf("%d", i);
			avg += (double)(i - 4000);
			std::min(min, i);
			std::max(max, i);
		}
	}
	avg/=(double)n;
	
	printf("%f.0\n", avg);
	printf("%d\n", max-min);
}
