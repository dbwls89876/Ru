#include <iostream>
using namespace std;

class Sum {
private:
	int n1, n2;
public:
	void init(int x, int y);
	int add();
};

void Sum::init(int x, int y) { // �ʱ�ȭ
	n1 = x;
	n2 = y;
}
int Sum::add() { // �ʱ�ȭ�� n1�� n2�� ���Ѱ��� ����
	return n1 + n2;
}

int main() {
	Sum obj;
	int n1, n2;
	cout << "ù��° ���� : "; // ����ڷκ��� �Է¹���
	cin >> n1;
	cout << "�ι�° ���� : ";
	cin >> n2;
	obj.init(n1, n2); // �Է¹��� ���� ����
	cout << "������ : " <<obj.add() << endl; // �� ��� 
}