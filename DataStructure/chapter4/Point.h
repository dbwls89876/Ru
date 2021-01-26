#ifndef __POINT_H__
#define __POINT_H__

typedef struct _point
{
	int xpos;
	int ypos;
} Point;

// Point 변수의 xpos, ypos 값 설정
void SetPointPos(Point * ppos, int xpos, int ypos);

// Point 변수의 xpos, ypos 정보 출력 
void ShowPointPos(Point * ppos);

// 두 Point 변수의 비교
int PointComp(Point * pos1, Point * pos2); 


void SetPointPos(Point * ppos, int xpos, int ypos)
{
	ppos->xpos = xpos;
	ppos->ypos = ypos;
}

void ShowPointPos(Point * ppos)
{
	printf("[%d, %d] \n", ppos->xpos, ppos->ypos);
}

int PointComp(Point * pos1, Point * pos2)
{
	if(pos1->xpos == pos2->xpos && pos1->ypos == pos2->ypos)
		return 0;
	else if(pos1->xpos == pos2->xpos)
		return 1;
	else if(pos1->ypos == pos2->ypos)
		return 2;
	else
		return -1;
}

#endif
