#include <iostream>
#include <string>
using namespace std;

class Book{
	private:
	string title;
	string author;
	public:
	Book(string title, string author){
		this->title = title;
		this->author = author;
	}
	string getTitle(){ return title; }	
	string getAuthor(){ return author;	}
};

int main(){
	Book obj("Great C++", "Bob");
	cout << "å �̸� : " << obj.getTitle() << endl;
	cout << "å ���� : " << obj.getAuthor() << endl;
}
