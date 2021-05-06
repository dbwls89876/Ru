#include <stdio.h>
#include <list>
class Build{
	int arr[50][3];
	int t;
	public:
	Build(){}
	void init(int test){
		t = test;
		for(int i = 0; i<t; i++){
			scanf("%d %d", &arr[i][0], &arr[i][1]);
			arr[i][2] = 0;
			arr[i][2]++;
		}
	}
	
	//랭크 분류 
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
	
	//랭크 출력 
	void rankPrint(){
		for(int i = 0; i<t; i++)
		printf("%d ", arr[i][2]);
	}
	
	//유닛테스트 
	void test(){		
		//테스트1 **************************
		printf("Test1\n");
		int tf = 1;
		int n = 99, m = 197;
		int answer[100] = {5, 4, 3, 2, 1};
		t = 5;
		for(int i = 0; i<5; i++){
			arr[i][0] = n+i;
			arr[i][1] = m+i;
			arr[i][2] = 1;
		}
		
		build();

		std::list<int> list;
		trueORfalse(answer, &tf);
		list.push_back(tf);
		
		//테스트2 ************************************ 
		printf("Test2\n");
		for(int i = 0; i<5; i++){
			answer[i] = 1;
		}
		t = 5;
		for(int i = 0; i<5; i++){
			arr[i][0] = n;
			arr[i][1] = m;
			arr[i][2] = 1;
		}
		
		build();
		trueORfalse(answer, &tf);
		list.push_back(tf);
		
		//테스트3 ************************************ 
		printf("Test3\n");
		for(int i = 1; i<=5; i++){
			answer[i] = i;
		}
		t = 5;
		for(int i = 0; i<5; i++){
			arr[i][0] = n-i;
			arr[i][1] = m-i;
			arr[i][2] = 1;
		}
		
		build();
		trueORfalse(answer, &tf);
		list.push_back(tf);
		
		//테스트4 ************************************ 
		printf("Test4\n");
		for(int i = 0; i<5; i++){
			answer[i] = 1;
		}
		answer[0] = 2;
		t = 5;
		for(int i = 0; i<5; i++){
			arr[i][0] = n+i;
			arr[i][1] = m+i;
			arr[i][2] = 1;
		}
		
		arr[2][0] == 99;
		arr[4][0] == 99;
		
		build();
		trueORfalse(answer, &tf);
		list.push_back(tf);
		
		//테스트 케이스 성공/실패 출력 
		std::list<int>::iterator iter; 
	    for(iter=list.begin(); iter!=list.end(); iter++) 
	    { 
	        if(*iter)
	        	printf("true\n");
	        else
	        	printf("false\n");
	    } 
	}
	
	void trueORfalse(int answer[], int * tf){
		for(int i = 0; answer[i]!=0; i++){
			if(arr[i][2] != answer[i]){
				*tf=0;
				break;
			}		
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
