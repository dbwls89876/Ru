#include <stdio.h>
#include "CLinkedList.h"
#include <string.h>

Employee duty(CList *list, int n, char name);
int main(){
	List *list;
	ListInit(list);
	Employee * emp =  (Employee*)malloc(sizeof(Employee));
	
	empAdd(emp, 1, 'A');
	printf("%d : %c", emp->num, emp->name);
//
//	LInsert(list, *emp);
//	empAdd(emp, 2, 'B');
//	LInsert(list, *emp);
//	empAdd(emp, 3, 'C');
//	LInsert(list, *emp);
//	printf("%d : %c", emp->num, emp->name);
//	*emp = duty(1, 'A');
//	
//	printf("%d : %c", emp->num, emp->name);
}

Employee duty(List *list, int n, char name){
	Employee emp;
	int i;
	
	LFirst(list, &emp);
	
	while(1){
		if(emp.num == n && strcmp(&emp.name, &name)){
			for(i = 0; i<n; i++)
				LNext(list, &emp);
			break;
		}
		LNext(list, &emp);
	}
	
	return emp;
}
