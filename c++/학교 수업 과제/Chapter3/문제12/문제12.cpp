#include <iostream>
#include <string>
using namespace std;

int main() {
	string s;
	int counter[256] = { 0 }; 
	cout << "���ڿ��� �Է��Ͻÿ� : ";
	getline(cin, s); // ���� ��ü �Է�

	for (int i = 0; i < s.size(); i++) {
		counter[s[i]]++; // ���ڰ� �ش�Ǵ� �����ڵ� ���ڿ� �迭�� �Է�
	}
	for (char i = 'a'; i <= 'z'; i++) { // a���� z������ �� ���
		cout << i << " : " <<counter[i] << endl;
	}
	return 0;
}