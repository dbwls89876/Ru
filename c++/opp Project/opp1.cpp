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
		cout<<"1. 계좌개설\n";
		cout<<"2. 입 금\n";
		cout<<"3. 출 금\n";
		cout<<"4. 계좌정보 전체 출력\n";
		cout<<"5. 프로그램 종료\n";
		cout<<"선택: ";
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
	cout<<"[계봐개설]\n";
	cout<<"계좌ID : ";
	cin>>acc[accountNum].accNum;
	cout<<"\n이름 : ";
	cin>>acc[accountNum].name;
	cout<<"\n입금액 : ";
	cin>>acc[accountNum].cash;
	
	accountNum++;
} 

void deposit(Account * acc){
	int accNum, cash, i;
	
	cout<<"계좌ID : ";
	cin>>accNum;
	cout<<"\n입금액 : ";
	cin>>cash;
	
	for(i=0; i<accountNum; i++){
		if(accNum==acc[i].accNum)
			acc[i].cash+=cash;
	}
	cout<<"\n입금완료"; 
}

void withdraw(Account * acc){
	int accNum, cash, i;
	
	cout<<"계좌ID : ";
	cin>>accNum;
	cout<<"\n출금액 : ";
	cin>>cash;
	
	for(i=0; i<accountNum; i++){
		if(accNum==acc[i].accNum)
			acc[i].cash-=cash;
	}
	cout<<"\n출금완료"; 
}

void accountPrint(Account * acc){
	int i;
	for(i=0; i<accountNum; i++){
		cout<<"계좌ID : "<<acc[i].accNum<<"\n";
		cout<<"이름 : "<<acc[i].name<<"\n";
		cout<<"잔액 : "<<acc[i].cash<<"\n\n";
	}
}

