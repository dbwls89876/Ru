#include <stdio.h>
#include <cmath>
int main(){
	int n, positionalNumber, m;
	
	scanf("%d", &n);
	int temp = n;
	for(positionalNumber = 1; temp>=10; positionalNumber++){ //�ڸ��� ã�� 
		temp/=10;
		
	}
	temp = 9*positionalNumber; // �ּ� ��
	for(int j = n-temp; j<=n; j++){
		int arr[100] = {0}; // �ʱ�ȭ
		m = j;
		int k = 0;
		for(int i = positionalNumber-1; i>=0; i--){
			arr[k] = m/(int)pow(10, i); // �� �ڸ����� �迭�� ���� 
			m %= (int)pow(10, i); // �̹� ���� �ڸ����� ������ �������� m�� ���� 
			k++;
			
		}
		m = j;
		for(int i = 0; i<k; i++)
			m += arr[i]; // �� �ڸ����� ���� 
		if(m==n){
			m = j;
			break;
		}
		if(j==n)
			m = 0; 
			
	}
	printf("%d", m);
		
}
