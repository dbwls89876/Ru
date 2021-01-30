#ifndef __EMPLOYEE_H__
#define __EMPLOYEE_H__

#include <stdlib.h>

typedef struct employee
{
	int num;
	char name;
} Employee;

void empAdd(Employee * emp, int n, char name);

void empAdd(Employee * emp, int n, char name){
	emp->num = n;
	emp->name = name;
}

#endif
