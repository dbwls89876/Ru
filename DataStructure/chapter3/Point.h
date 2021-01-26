#include <stdio.h>
#ifndef __POINT_H__
#define __POINT_H__


typedef struct Point{
	int x;
	int y;
} Point;


void setPoint(Point * p, int x, int y); // x, y �� ����
void ShowPoint(Point * p); // x, y ���� ��� 
int PointComp(Point * p1, Point * p2); // x, y �� 

void setPoint(Point * p, int x, int y){
	p->x = x;
	p->y = y;
}

void ShowPoint(Point * p){
	printf("x : %d\n", p->x);
	printf("y : %d\n", p->y);
}

int PointComp(Point * p1, Point * p2){
	if(p1->x==p2->x&&p1->y==p2->y) // ��� ������ �� 0 ��ȯ 
		return 0;
	else if(p1->x == p2->x) // x�� ���� ������ 1 ��ȯ 
		return 1;
	else if(p1->y == p2->y) // y�� ���� ������ 2 ��ȯ
		return 2;
	else //��� ���� ���� �� 
		return -1;
}

#endif
