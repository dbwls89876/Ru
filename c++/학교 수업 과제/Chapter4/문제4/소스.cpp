#include <iostream>
#include <string>
using namespace std;

class Book {
public: // �������� ������ ���� ����
	string title;
	string author;
};

int main() {
	Book obj; // ��ü����
	
	cout << "å �̸� : " << (obj.title = "Great C++") << endl; // title�ʱ�ȭ �� ���
	cout << "å ���� : " << (obj.author = "Bob") << endl; // author�ʱ�ȭ �� ���
	return 0;
}