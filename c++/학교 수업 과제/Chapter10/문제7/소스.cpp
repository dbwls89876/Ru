#include <iostream>
using namespace std;

class Time {
	int hours; // 시간
	int minute; // 분
public:
	Time() { hours = 0; minute = 0; }
	Time(int h, int m) { hours = h; minute = m; }
	friend Time operator+(const Time& t1, const Time& t2);
	Time operator+(const Time& t2);
	void operator+=(const Time& t2);
	friend ostream& operator<< (ostream& os, const Time& t);
};

Time operator+(const Time&t1, const Time& t2) { // +연산자 프렌드함수 중복
	Time t;
	t.hours = t1.hours + t2.hours;
	t.minute = t1.minute + t2.minute;
	if (t.minute >= 60) {
		int rem = t.minute / 60;
		t.hours += rem;
		t.minute %= 60;
	}
	return t;
}

Time Time::operator+(const Time& t2) { // +연산자 멤버함수 중복
	Time t;
	t.hours = this->hours + t2.hours;
	t.minute = this->minute + t2.minute;
	if (t.minute >= 60) {
		int rem = t.minute / 60;
		t.hours += rem;
		t.minute %= 60;
	}
	return t;
}

void Time::operator+=(const Time& t2) { // +=연산자 멤버함수 중복
	this->hours = this->hours + t2.hours;
	this->minute = this->minute + t2.minute;
	if (this->minute >= 60) {
		int rem = this->minute / 60;
		this->hours += rem;
		this->minute %= 60;
	}
}

ostream& operator<<(ostream& os, const Time& t) { // <<연산자 프렌드함수 중복
	os << t.hours << "시 " << t.minute << "분" << endl;
	return os;
}

int main() {
	Time t1(1, 20);
	Time t2(2, 50);
	Time t3;
	t1 += t2;
	t3 = t2 + t1;
	cout << t1 << t3; 
	return 0;
}