#include <vector>
#include <iostream>
using namespace std;

int main(void)
{
	vector<int> fibonacci { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }; 

	for (auto& number : fibonacci)
		cout << number << ' ';

	cout << endl;
	return 0;
}