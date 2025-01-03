#include <iostream>
using namespace std;


class Counter
{
private:
	int value;

public:
	Counter() : value{0} { };
	~Counter() { }
	int getValue() const { return value; }
	void setValue(int x) { value = x; }

	Counter& operator++() 
	{
		++value;
		return *this;
	}

};

int main()
{
	Counter c;
	cout << "카운터의 값: " << c.getValue() << endl;
	++c;
	cout << "카운터의 값: " << c.getValue() << endl;

	return 0;
}
