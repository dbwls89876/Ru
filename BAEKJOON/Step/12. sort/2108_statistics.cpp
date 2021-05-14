#include <stdio.h>
#include <algorithm>
#include <vector>
using namespace std;
int main(){
	int arr[8001] = {0, };
	vector<int> v;
	int n;
	scanf("%d", &n);
	for(int i = 0; i<n; i++){
		int num;
		scanf("%d", &num);
		v.push_back(num);
		arr[num+4000]++;
	}
	int mode = 0, min = 4000, max = -4000 ,check1 = 0, check2=0;
	double avg;
	for(int i = 0; i<8001; i++){
		while(arr[i]){
			if(check1 < arr[i]){
				check1 = arr[i];
				check2 = 0;
				mode = i-4000;
			}else if(check2 == 0 && check1 == arr[i]){
				check2 = 1;
				mode = i-4000;
			}
			avg += (double)(i - 4000);
			min = std::min(min, i-4000);
			max = std::max(max, i-4000);
			arr[i]--;
		}
	}
	
	sort(v.begin(), v.end());
	avg/=(double)n;
	
	printf("%.0f\n", avg);
	printf("%d\n", v[(int)(n/2)]);
	printf("%d\n", mode);
	printf("%d\n", max-min);
}
