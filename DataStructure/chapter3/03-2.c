#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define TRUE	1
#define FALSE	0

/*** ArrayList�� ���� ****/
#define LIST_LEN	100
//NameCard�� ���� 
#define NAME_LEN		30
#define PHONE_LEN		30


//namecard����ü 

typedef struct __namecard
{
	char name[NAME_LEN];
	char phone[PHONE_LEN];
} NameCard;

//arraylist ����ü 
typedef NameCard LData;

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

// NameCard ����ü ������ ���� �Ҵ� �� �ʱ�ȭ �� �ּ� �� ��ȯ
NameCard * MakeNameCard(char * name, char * phone);
   
// NameCard ����ü ������ ���� ���
void ShowNameCardInfo(NameCard * pcard);
   
// �̸��� ������ 0, �ٸ��� 0�� �ƴ� �� ��ȯ
int NameCompare(NameCard * pcard, char * name);
   
// ��ȭ��ȣ ������ ����
void ChangePhoneNum(NameCard * pcard, char * phone);

int main(){
	List list;
	NameCard * nc;
	int i;
	ListInit(&list);
	
	nc = MakeNameCard("��", "010-1234-1234");
	LInsert(&list, *nc);

	nc = MakeNameCard("��", "010-1111-1111");
	LInsert(&list, *nc);

	nc = MakeNameCard("��", "010-1112-1112");
	LInsert(&list, *nc);
	if(LFirst(&list, nc))
	for(i = 0; i<LCount(&list); i++){
		int cmp;
		if(i==0){
			LFirst(&list, nc);
		}
		else{
			LNext(&list, nc);
		}
		cmp = NameCompare(nc, "��");
		if(cmp==0){
			ShowNameCardInfo(nc);
			LRemove(&list);
		}
	}
	LFirst(&list, nc);
	ShowNameCardInfo(nc);
	while(LNext(&list, nc)){
		ShowNameCardInfo(nc);
	}	
	
}

//namecard���
NameCard * MakeNameCard(char name[], char phone[]){
	NameCard * nc;
	nc = (NameCard*)malloc(sizeof(NameCard));
	strcpy(nc->name, name);
	strcpy(nc->phone, phone);
	return nc;
} 

void ShowNameCardInfo(NameCard * nc){
	printf("%s\n", nc->name);
	printf("%s\n", nc->phone);
}

int NameCompare(NameCard * nc, char * name){
	return strcmp(nc->name, name);
}

//arraylist��� 
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

