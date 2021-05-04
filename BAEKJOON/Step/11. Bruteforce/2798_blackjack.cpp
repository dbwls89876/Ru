#include <stdio.h>

int main(){
	int n, m;
	int arr[100];
	int min = 100000, max=0;
	scanf("%d %d", &n, &m);
	
	for(int i = 0; i<n; i++)
		scanf("%d", arr+i);

	for(int i = 0; arr[i+2]!=0; i++){
		for(int j = i+1; arr[j]!=0; j++){
			for(int k = i+2; arr[k]!=0; k++){
				int sum = arr[i]+arr[j]+arr[k];
				if(sum > m || k == j)
					continue;
				else
					if(m-sum<min){
						min = m-sum;
						max = sum;
					}
			}
		}
	}
	
	printf("%d\n", max);
	return 0;
}
