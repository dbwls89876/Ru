#include <stdio.h>
#include <list>

//괜히 심각하게 생각한 나머지 간단한 문제에 생고생함
//알고보니 몸무게가 동일하거나 키가 동일한 경우는 고려도 안했던거임~~ 올림피아드라도 그렇지 초등학생 문제를 왜 이따구로 내나 싶었습니다........ 
//하지만 내가 문제를 너무 어렵게 생각했던거시다 
 
class Build{
	int arr[50][3];
	int t;
	public:
	Build(){}
	void init(int test){ // 입력을 받는 함수 
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
			for(int j = 0; j<t; j++){
				if(i==j)
					continue;
				else if((arr[i][0] < arr[j][0] && arr[i][1]<=arr[j][1]) || (arr[i][0] <= arr[j][0] && arr[i][1] < arr[j][1])) // 몸무게가 작고 키는 작거나 같음, 몸무게는 작거나 같고 키는 작음 
					arr[i][2]++;		
			}
		}

		for(int k = 0; k<t; k++) //테스트케이스만큼 
			for(int i = 0; i<t; i++)
				for(int j = 0; j<t; j++)
					if((arr[i][0] > arr[j][0] && arr[i][1] < arr[j][1]) || (arr[i][0] < arr[j][0] && arr[i][1] > arr[j][1]))// 몸무게가 크고 키가 작음, 몸무게가 작고 키가 큼  
						{
							if(arr[i][2]<arr[j][2]) // 랭크가 높은 쪽의 랭크를 옮겨옴 
								arr[j][2] = arr[i][2];
							else
								arr[i][2] = arr[j][2];
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
		for(int i = 0; i<5; i++){
			answer[i] = i+1;
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
		answer[0] = 5;
		t = 5;
		for(int i = 0; i<5; i++){
			arr[i][0] = n+i;
			arr[i][1] = m+i;
			arr[i][2] = 1;
		}
		
		arr[2][0] = 99;
		arr[4][0] = 99;
		
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
	
	void trueORfalse(int answer[], int * tf){ // 테스트의 성공/실패 여부를 가리는 함수 
		for(int i = 0; answer[i]!=0; i++){
			printf("랭크 : %d, 답 : %d", arr[i][2], answer[i]);
			if(arr[i][2] != answer[i]){
				*tf=0;
				//break;
			}	
			printf("\n");	
		}
	}
};



int main(){
	int t;
	int arr[50][3];
	scanf("%d", &t);
	for(int i = 0; i<t; i++){
			scanf("%d %d", &arr[i][0], &arr[i][1]);
			arr[i][2] = 1;
		}
//	Build build;
//	build.init(t);
//	build.build();
//	build.rankPrint();
//	build.test();

	for(int i = 0; i<t; i++){
		for(int j = 0; j<t; j++){
			if(arr[i][0] > arr[j][0] && arr[i][1] > arr[j][1])
				arr[j][2]++;
		}
	}
	
	for(int i = 0; i<t; i++)
		printf("%d ", arr[i][2]);
		
	return 0;
}
