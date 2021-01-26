#include <stdio.h>
#ifndef __POINT_H__
#define __POINT_H__


typedef struct Point{
	int x;
	int y;
} Point;


void setPoint(Point * p, int x, int y); // x, y 값 설정
void ShowPoint(Point * p); // x, y 정보 출력 
int PointComp(Point * p1, Point * p2); // x, y 비교 

void setPoint(Point * p, int x, int y){
	p->x = x;
	p->y = y;
}

void ShowPoint(Point * p){
	printf("x : %d\n", p->x);
	printf("y : %d\n", p->y);
}

int PointComp(Point * p1, Point * p2){
	if(p1->x==p2->x&&p1->y==p2->y) // 모두 동일할 때 0 반환 
		return 0;
	else if(p1->x == p2->x) // x의 값이 같을때 1 반환 
		return 1;
	else if(p1->y == p2->y) // y의 값이 같을때 2 반환
		return 2;
	else //모두 같지 않을 때 
		return -1;
}

#endif
