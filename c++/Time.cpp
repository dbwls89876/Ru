#include <stdio.h>
#include <time.h>

class Time{
	private :
	clock_t s, e;
	double r;
	
	public :
	Time(){
	}
	void start(){
		s = clock();
	}
	
	void end(){
		e = clock();
	}
	
	double result(){
		r = (double)(e - s);
		return r;
	}
};


