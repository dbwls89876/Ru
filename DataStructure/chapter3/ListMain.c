#include <stdio.h>

#define TRUE	1
#define FALSE	0

/*** ArrayList�� ���� ****/
#define LIST_LEN	100
typedef int LData;

typedef struct __ArrayList
{
	LData arr[LIST_LEN];
	int numOfData;
	int curPosition;
} ArrayList;


/*** ArrayList�� ���õ� ����� ****/
typedef ArrayList List;

void ListInit(List * plist);
void LInsert(List * plist, LData data);

int LFirst(List * plist, LData * pdata);
int LNext(List * plist, LData * pdata);

LData LRemove(List * plist);
int LCount(List * plist);


int main(){
	List list;
	int data;
	int i = 2;
	ListInit(&list);
	
	LInsert(&list, 1);
	LInsert(&list, 2);
	LInsert(&list,3);
	LInsert(&list, 4);
	LInsert(&list, 5);
	
	printf("���� �� : %d \n", LCount(&list));
	
	if(LFirst(&list, &data)){
		printf("ù��° ���� : %d \n", LFirst(&list, &data));
		
		while(LNext(&list, &data)){
			printf("%d��° ���� : %d \n", i, data);
			i++;
			if(data==3)
				printf("���ŵ� ���� : %d \n", LRemove(&list));
		}				
	}
	
	printf("���ŵ� ���� : %d \n", LRemove(&list));
	
	printf("���� �� : %d \n", LCount(&list));
	
	return 0;
}

void ListInit(List * plist)
{
	(plist->numOfData) = 0;
	(plist->curPosition) = -1;
}

void LInsert(List * plist, LData data)
{
	if(plist->numOfData > LIST_LEN) 
	{
		puts("������ �Ұ����մϴ�.");
		return;
	}

	plist->arr[plist->numOfData] = data;
	(plist->numOfData)++;
}

int LFirst(List * plist, LData * pdata)
{
	if(plist->numOfData == 0)
		return FALSE;

	(plist->curPosition) = 0;
	*pdata = plist->arr[0];
	return TRUE;
}

int LNext(List * plist, LData * pdata)
{
	if(plist->curPosition >= (plist->numOfData)-1)
		return FALSE;

	(plist->curPosition)++;
	*pdata = plist->arr[plist->curPosition];
	return TRUE;
}

LData LRemove(List * plist)
{
	int rpos = plist->curPosition;
	int num = plist->numOfData;
	int i;
	LData rdata = plist->arr[rpos];

	for(i=rpos; i<num-1; i++)
		plist->arr[i] = plist->arr[i+1];

	(plist->numOfData)--;
	(plist->curPosition)--;
	return rdata;
}

int LCount(List * plist)
{
	return plist->numOfData;
}

