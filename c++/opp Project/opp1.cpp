#include <iostream>

using namespace std;

int accountNum=0;
const int NAME_LEN = 20;

struct Account{
	int accNum;
	char name[NAME_LEN];
	int cash;
};

void makeAccount(Account * acc);
void deposit(Account * acc);
void withdraw(Account * acc);
void accountPrint(Account * acc);

int main(){
	
	int select;
	Account acc[100];
	
	while(1){
		cout<<"-----Menu-----\n";
		cout<<"1. ���°���\n";
		cout<<"2. �� ��\n";
		cout<<"3. �� ��\n";
		cout<<"4. �������� ��ü ���\n";
		cout<<"5. ���α׷� ����\n";
		cout<<"����: ";
		cin>>select;
		if(select==1){
			makeAccount(acc);
		}
		else if(select==2){
			deposit(acc);	
		}
		else if(select==3){
			withdraw(acc);
		}
		else if(select==4)
			accountPrint(acc);
		else if(select==5)
			break;
	}
}


void makeAccount(Account * acc){
	cout<<"[�������]\n";
	cout<<"����ID : ";
	cin>>acc[accountNum].accNum;
	cout<<"\n�̸� : ";
	cin>>acc[accountNum].name;
	cout<<"\n�Աݾ� : ";
	cin>>acc[accountNum].cash;
	
	accountNum++;
} 

void deposit(Account * acc){
	int accNum, cash, i;
	
	cout<<"����ID : ";
	cin>>accNum;
	cout<<"\n�Աݾ� : ";
	cin>>cash;
	
	for(i=0; i<accountNum; i++){
		if(accNum==acc[i].accNum)
			acc[i].cash+=cash;
	}
	cout<<"\n�ԱݿϷ�"; 
}

void withdraw(Account * acc){
	int accNum, cash, i;
	
	cout<<"����ID : ";
	cin>>accNum;
	cout<<"\n��ݾ� : ";
	cin>>cash;
	
	for(i=0; i<accountNum; i++){
		if(accNum==acc[i].accNum)
			acc[i].cash-=cash;
	}
	cout<<"\n��ݿϷ�"; 
}

void accountPrint(Account * acc){
	int i;
	for(i=0; i<accountNum; i++){
		cout<<"����ID : "<<acc[i].accNum<<"\n";
		cout<<"�̸� : "<<acc[i].name<<"\n";
		cout<<"�ܾ� : "<<acc[i].cash<<"\n\n";
	}
}

