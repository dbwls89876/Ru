#include <iostream>
#include <string>
using namespace std;

class CellPhone {
public:
	bool on = false;
	string number, model, color;
	void setOn();
};

void CellPhone::setOn() { //�¿��� ����
	if (on == false) { // on�� 0�϶� 1�� ������ true ���
	on = 1;
	cout << "true" << endl;
	}
	else if (on == true) { // on�� 1�϶� 0���� ������ false ���
	on = 0;
	cout << "false" << endl;
	}

}

int main() {
	CellPhone obj; // ��ü����
	cout << "CellPhone1 : " << endl; 
	cout << (obj.number = "010-1234-5678") << endl; // ��ȣ �ʱ�ȭ �� ���
	cout << (obj.model = "Galaxy") << endl; // �� �ʱ�ȭ �� ���
	cout << (obj.color = "Black") << endl; // ���� �ʱ�ȭ �� ���
	obj.setOn(); // �����¿��� �� �������
	return 0;
}