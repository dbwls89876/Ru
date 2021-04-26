#include <iostream>
using namespace std;

int main(){
	int arr[9], max, n=1;
	for(int i =0; i<9; i++)
		cin>>arr[i];
		
	max = arr[0];
	for(int i =1; i<9; i++)
		if(max<arr[i]){
			max=arr[i]; n=i+1;
		}
	cout<<max<<"\n"<<n<<"\n";
	return 0;
}
