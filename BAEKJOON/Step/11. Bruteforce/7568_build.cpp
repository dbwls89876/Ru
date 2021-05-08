#include <stdio.h>
#include <list>

//���� �ɰ��ϰ� ������ ������ ������ ������ �������
//�˰��� �����԰� �����ϰų� Ű�� ������ ���� ����� ���ߴ�����~~ �ø��ǾƵ�� �׷��� �ʵ��л� ������ �� �̵����� ���� �;����ϴ�........ 
//������ ���� ������ �ʹ� ��ư� �����ߴ��Žô� 
 
class Build{
	int arr[50][3];
	int t;
	public:
	Build(){}
	void init(int test){ // �Է��� �޴� �Լ� 
		t = test;
		for(int i = 0; i<t; i++){
			scanf("%d %d", &arr[i][0], &arr[i][1]);
			arr[i][2] = 0;
			arr[i][2]++;
		}
	}
	
	//��ũ �з� 
	void build(){	
		for(int i = 0; i<t; i++){
			for(int j = 0; j<t; j++){
				if(i==j)
					continue;
				else if((arr[i][0] < arr[j][0] && arr[i][1]<=arr[j][1]) || (arr[i][0] <= arr[j][0] && arr[i][1] < arr[j][1])) // �����԰� �۰� Ű�� �۰ų� ����, �����Դ� �۰ų� ���� Ű�� ���� 
					arr[i][2]++;		
			}
		}

		for(int k = 0; k<t; k++) //�׽�Ʈ���̽���ŭ 
			for(int i = 0; i<t; i++)
				for(int j = 0; j<t; j++)
					if((arr[i][0] > arr[j][0] && arr[i][1] < arr[j][1]) || (arr[i][0] < arr[j][0] && arr[i][1] > arr[j][1]))// �����԰� ũ�� Ű�� ����, �����԰� �۰� Ű�� ŭ  
						{
							if(arr[i][2]<arr[j][2]) // ��ũ�� ���� ���� ��ũ�� �Űܿ� 
								arr[j][2] = arr[i][2];
							else
								arr[i][2] = arr[j][2];
						}
	}
	
	//��ũ ��� 
	void rankPrint(){
		for(int i = 0; i<t; i++)
		printf("%d ", arr[i][2]);
	}
	
	//�����׽�Ʈ 
	void test(){		
		//�׽�Ʈ1 **************************
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
		
		//�׽�Ʈ2 ************************************ 
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
		
		//�׽�Ʈ3 ************************************ 
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
		
		//�׽�Ʈ4 ************************************ 
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
		
		//�׽�Ʈ ���̽� ����/���� ��� 
		std::list<int>::iterator iter; 
	    for(iter=list.begin(); iter!=list.end(); iter++) 
	    { 
	        if(*iter)
	        	printf("true\n");
	        else
	        	printf("false\n");
	    } 
	}
	
	void trueORfalse(int answer[], int * tf){ // �׽�Ʈ�� ����/���� ���θ� ������ �Լ� 
		for(int i = 0; answer[i]!=0; i++){
			printf("��ũ : %d, �� : %d", arr[i][2], answer[i]);
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
