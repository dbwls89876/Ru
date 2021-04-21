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
	cout << "책 이름 : " << obj.getTitle() << endl;
	cout << "책 저자 : " << obj.getAuthor() << endl;
}
