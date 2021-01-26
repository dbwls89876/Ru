#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define TRUE	1
#define FALSE	0

/*** ArrayList의 정의 ****/
#define LIST_LEN	100
//NameCard의 정의 
#define NAME_LEN		30
#define PHONE_LEN		30


//namecard구조체 

typedef struct __namecard
{
	char name[NAME_LEN];
	char phone[PHONE_LEN];
} NameCard;

//arraylist 구조체 
typedef NameCard LData;

typedef struct __ArrayList
{
	LData arr[LIST_LEN];
	int numOfData;
	int curPosition;
} ArrayList;


/*** ArrayList와 관련된 연산들 ****/
typedef ArrayList List;

void ListInit(List * plist);
void LInsert(List * plist, LData data);

int LFirst(List * plist, LData * pdata);
int LNext(List * plist, LData * pdata);

LData LRemove(List * plist);
int LCount(List * plist);

// NameCard 구조체 변수의 동적 할당 및 초기화 후 주소 값 반환
NameCard * MakeNameCard(char * name, char * phone);
   
// NameCard 구조체 변수의 정보 출력
void ShowNameCardInfo(NameCard * pcard);
   
// 이름이 같으면 0, 다르면 0이 아닌 값 반환
int NameCompare(NameCard * pcard, char * name);
   
// 전화번호 정보를 변경
void ChangePhoneNum(NameCard * pcard, char * phone);

int main(){
	List list;
	NameCard * nc;
	int i;
	ListInit(&list);
	
	nc = MakeNameCard("강", "010-1234-1234");
	LInsert(&list, *nc);

	nc = MakeNameCard("냥", "010-1111-1111");
	LInsert(&list, *nc);

	nc = MakeNameCard("찍", "010-1112-1112");
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
		cmp = NameCompare(nc, "강");
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

//namecard기능
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

//arraylist기능 
void ListInit(List * plist)
{
	(plist->numOfData) = 0;
	(plist->curPosition) = -1;
}

void LInsert(List * plist, LData data)
{
	if(plist->numOfData > LIST_LEN) 
	{
		puts("저장이 불가능합니다.");
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

