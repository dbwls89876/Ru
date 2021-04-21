#include <iostream>
using namespace std;

template <typename T>
int getSum(T list[], T n) {
	int sum = 0;
	for (int i = 0; i < n; i++)
		sum += list[i];
	return sum;
}

int main() {
	int arr[3] = { 1, 2, 3 };
	int sum=0;
	sum = getSum(arr, 3);
	cout << sum << endl;
}