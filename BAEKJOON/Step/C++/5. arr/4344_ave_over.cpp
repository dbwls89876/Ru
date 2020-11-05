#include <iostream>
using namespace std;

int main(){
	int count, score[1000]; 
	int n, check;
	double ave, p;
	cout<<fixed;
	cout.precision(3);
	cin>>n;
	
	for(int i = 0; i<n; i++){
		cin>>count;
		ave = 0;
		p=0;
		for(int j = 0; j<count; j++){
			cin>>score[j];
			ave+=score[j];
			
		}
		ave /= count;
		for(int j = 0; j<count; j++){
			
			if(score[j]>ave)
				p++;
		}
		cout<<(p/count)*100<<"%"<<"\n";
	}			
}
