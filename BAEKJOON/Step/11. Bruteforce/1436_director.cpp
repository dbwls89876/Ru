#include <stdio.h>
#include <math.h>
int main(){
	int n, result=0, num=0; // ã�� ����, ������ ��,  ã�Ƴ� ���� 
	int check; // 666 Ȯ�� 
	int i = 0; // �ڸ��� ��� 
	scanf("%d", &n);
	int temp; // 666�� ã�Ƴ��� ���� ������ ��
	
	
	for(int j = 666; j<=10000000; j++){ // ù��° �� 666���� ���� 
		if(num == n) // n���� ���ڸ� ã���� �� Ż�� 
			break;
		temp = j; //�ڸ��� ã�� 
		check = 0;
		
		for(i = 0; temp>=10; i++){
		temp/=10; // temp�� 10�� ���� �ڸ����� ã�� 
		}
		temp = j; // 666�� ������ ���� ã�� 
		for(; i>=0; i--){ // �ڸ�����ŭ �����⸦ �ݺ� 
			if(temp/(int)pow(10, i) == 6) // ���� ���� 6�϶� 
				check++; // 6�� üũ
			else
				check = 0; // 6�� ���ӵ������� 
			temp%=(int)pow(10, i); // ���������� ���� 
		
			if(check==3){ // 6�� �����ؼ� 3�� ������ �� 
			result = j; // j���� ���� 
			num++; // �߰��� �� ���� 
			break;
			}
		}
		
		
	}
	printf("%d" ,result);
}
