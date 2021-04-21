#include <iostream>
#include <string>
using namespace std;

class Box {
private:
	int length; // 길이
	int width; // 넓이
	int height; // 높이
public :
	Box() {
		length = 0;
		width = 0;
		height = 0; 
	}
	Box(int l, int w, int h) : length{l}, width{w}, height{h} {}
	
	int getLength () { return length; } //접근자
	int getWidth () { return width; }
	int getHeight () { return height; }
	void setLength(int l) { length = l; } // 설정자
	void setWidth(int w) { width = w; }
	void setHeight(int h) { height = h; }
	int getVolume() { return length * width * height; } // 부피

	void empty();
	void print();
};

void Box::empty(){
	if (length * width * height == 0) // 부피가 0일때 빈상자
		cout << "박스가 비어있습니다." << endl;
}
void Box::print() { // 상자의 정보 출력
	
	cout << "상자의 길이 :" << length << endl;
	cout << "상자의 너비 : " << width << endl;
	cout << "상자의 높이 : " << height << endl;
	cout << "상자의 부피 : " << getVolume() << endl;
}

int main() {
	Box obj1; // 매개변수가 없는 생성자 호출
	Box obj2(3, 2, 4); // 매개변수가 있는 생성자 호출
	Box obj3;
	obj3.setHeight(3); // 설정자를 이용한 초기화
	obj3.setLength(2);
	obj3.setWidth(5);
	cout << "상자 #1" << endl;
	obj1.print();
	obj1.empty(); // 빈상자확인

	cout << "상자 #2" << endl;
	obj2.print();
	obj2.empty();

	cout << "상자 #3" << endl;
	cout << "상자의 길이 : " << obj3.getLength() << endl;
	cout << "상자의 너비 : " << obj3.getWidth() << endl;
	cout << "상자의 높이 : " << obj3.getHeight() << endl;
	
	obj3.empty();
}