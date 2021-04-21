#include <iostream>
#include <string>
using namespace std;

class Box {
private:
	int length; // ����
	int width; // ����
	int height; // ����
public :
	Box() {
		length = 0;
		width = 0;
		height = 0; 
	}
	Box(int l, int w, int h) : length{l}, width{w}, height{h} {}
	
	int getLength () { return length; } //������
	int getWidth () { return width; }
	int getHeight () { return height; }
	void setLength(int l) { length = l; } // ������
	void setWidth(int w) { width = w; }
	void setHeight(int h) { height = h; }
	int getVolume() { return length * width * height; } // ����

	void empty();
	void print();
};

void Box::empty(){
	if (length * width * height == 0) // ���ǰ� 0�϶� �����
		cout << "�ڽ��� ����ֽ��ϴ�." << endl;
}
void Box::print() { // ������ ���� ���
	
	cout << "������ ���� :" << length << endl;
	cout << "������ �ʺ� : " << width << endl;
	cout << "������ ���� : " << height << endl;
	cout << "������ ���� : " << getVolume() << endl;
}

int main() {
	Box obj1; // �Ű������� ���� ������ ȣ��
	Box obj2(3, 2, 4); // �Ű������� �ִ� ������ ȣ��
	Box obj3;
	obj3.setHeight(3); // �����ڸ� �̿��� �ʱ�ȭ
	obj3.setLength(2);
	obj3.setWidth(5);
	cout << "���� #1" << endl;
	obj1.print();
	obj1.empty(); // �����Ȯ��

	cout << "���� #2" << endl;
	obj2.print();
	obj2.empty();

	cout << "���� #3" << endl;
	cout << "������ ���� : " << obj3.getLength() << endl;
	cout << "������ �ʺ� : " << obj3.getWidth() << endl;
	cout << "������ ���� : " << obj3.getHeight() << endl;
	
	obj3.empty();
}