#include <stdio.h>
#include <stdlib.h>
#include "DLinkedList.h"


int main(){
	List list;
	Point *p1;
	Point p2;
	int i = 0;
	ListInit(&list);
	
	p1 = (Point*)malloc(sizeof(Point));
	setPoint(p1, 1, 1);
	LInsert(&list, *p1);
	
	p1 = (Point*)malloc(sizeof(Point));
	setPoint(p1, 2, 1);
	LInsert(&list, *p1);

	p1 = (Point*)malloc(sizeof(Point));
	setPoint(p1, 2, 2);
	LInsert(&list, *p1);

	printf("데이터 수 : %d\n", LCount(&list));
	
	
	if(LFirst(&list, p1)){
		ShowPoint(p1);
		
		while(LNext(&list, p1)){
			printf("=======================\n");
			ShowPoint(p1);
			i++;
		}
	}
	p2.x = 1;
	p2.y = 2;
	
	switch(PointComp(p1, &p2)){
		case 0 : printf("동일\n");break; 
		case 1 : printf("x동일\n");break;
		case 2 : printf("y동일\n");break;
		case -1 : printf("모두다름\n");break;
	}
} 

