#include <iostream>
using namespace std;

class Date
{
	friend bool equals(Date d1, Date d2);
	int year, month, day;
public:
	Date(int y=0, int m=0, int d=0) : year(y), month(m), day(d) {   }
};

// ������ �Լ�
bool equals(Date d1, Date d2)
{
	return d1.year == d2.year && d1.month == d2.month && d1.day == d2.day;
}

int main()
{
	Date d1(1960, 5, 23), d2(2002, 7, 23);
	cout << equals(d1, d2) << endl;
}