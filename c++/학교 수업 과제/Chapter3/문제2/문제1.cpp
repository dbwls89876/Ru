#include <iostream>
#include <math.h>
using namespace std;

inline double calc_volume(double r = 3.0) { // 함수 삽입, 변수미전달시 3입력
	double result;
	return result = (4.0 / 3.0 * 3.14 * pow(r, 3));
}

int main() {
	double r;
	cout << "구의 반지름을 입력하시오 : ";
	cin >> r;
	cout << "구의 부피는 "<< calc_volume(r) << endl;

}