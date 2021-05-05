#include <stdio.h>
#include <list>
class Build{
	int arr[50][3];
	int t;
	public:
	Build(){}
	Build(int test){
		t = test;
		for(int i = 0; i<t; i++){
			scanf("%d %d", &arr[i][0], &arr[i][1]);
			arr[i][2] = 0;
			arr[i][2]++;
		}
	}
	void build(){	
		for(int i = 0; i<t; i++){
			for(int j = i+1; j<t; j++){
				if(arr[i][0] > arr[j][0] && arr[i][1] >= arr[j][1] || arr[i][0] >= arr[j][0] && arr[i][1] > arr[j][1])
					arr[j][2]++;
				else if(arr[i][0] == arr[j][0] && arr[i][1] == arr[j][1])
					continue;
				else if(arr[i][0] > arr[j][0] && arr[i][1] < arr[j][1] || arr[i][0] < arr[j][0] && arr[i][1] > arr[j][1]){
					continue;
				}
				else
					arr[i][2]++;			
			}
		}	
	}
	
	void rankPrint(){
		for(int i = 0; i<t; i++)
		printf("%d ", arr[i][2]);
	}
	
	void test(){		
		int tf = 1;
		int n = 70, m = 180;
		int answer[100] = {5, 4, 3, 2, 1};
		for(int i = 0; i<5; i++){
			arr[i][0] = n+i;
			arr[i][1] = m+i;
			arr[i][2] = 1;
		}
		
		build();

		std::list<int> list;
		for(int i = 0; i<answer[i]!=0; i++){
			if(arr[i][2] != answer[i]){
				printf("arr=%d, ans = %d", arr[i][2], answer[i]);
				tf=0;
				break;
			}
				
		}
		printf("%d\n", tf);
		list.push_back(tf);
		
		std::list<int>::iterator iter; 
 
	    for(iter=list.begin(); iter!=list.end(); iter++) 
	    { 
	        if(*iter)
	        	printf("true");
	        else
	        	printf("false");
	    } 

	}
	
};



int main(){
	int t;
	scanf("%d", &t);
	Build build;
	//Build build(t);
//	build.build();
//	build.rankPrint();
	build.test();
	return 0;
}
