#include <iostream>
#include <string>
using namespace std;


int main() {
	string a, b;
	string result;
	int diff;
	long n1, n2;
	int l = 0;
	cin >> a;
	cin >> b;
	

	if (a.length() > b.length()) {
		diff = a.length() - b.length();
		for (int i = diff; i > 0; i--)
			b = "0" + b;
	}
	else{
		diff = b.length() - a.length();
		for (int i = diff; i > 0; i--)
			a = "0" + a;
	}
	if(a.length()/10>=1)
		for (l = 0; l < a.length()/10; l++) {
			n1 = stoi(a.substr(l*10, 9));
			n2 = stoi(b.substr(l*10, 9));
			result += to_string(n1 + n2);
		}
	else {
		n1 = stoi(a.substr(l * 10, a.length()%10));
		n2 = stoi(b.substr(l * 10, b.length()%10));
		result += to_string(n1 + n2);
	}
	cout << result;
}


/*
static int t = 0;
void plusNum(char * s, char c1, char c2, int * length) {
	char c;
	c = c1 + c2 - 48;

	if (*length == 0 && c>=58) {
		s[0] = '1';
		s[1] = c-10;
		*length += 1;
		t = -1;
	}
	else if (c >= 58) {
		s[*length] = c-10;
		*length -= 1;
		plusNum(s, '1', '0', length);
		*length += 1;
	}
	else {
		if (s[*length] >= '0' && s[*length] <= '9') {
			s[*length] += 1;
			return;
		}
		s[*length] = c;
	}

}

int main() {
	string c,d;
	cin >> c;
	cin >> d;
	char result[10001];
	int dif, max;

	if (c.length() > d.length()) {
		dif = c.length() - d.length();
		max = c.length();
		for (int i = dif; i != 0; i--) {
			d = "0" + d;
		}
	}
	else {
		dif = d.length() - c.length();
		max = c.length();
		for (int i = dif; i != 0; i--) {
			c = "0" + c;
		}
	}

	for (int i = 0; i <= max; i++) {
		char c1, c2;
		if (i == 0) {
			c1 = c[i];
			c2 = d[i];
			plusNum(result, c1, c2, &i);
			continue;
		}
		c1 = c[i+t];
		c2 = d[i+t];

		plusNum(result, c1, c2, &i);
	}
	
	for (int i = 0; result[i]>='0' && result[i]<='9'; i++) {
		cout << result[i];
	}
}*/