package object;

class Book {
	int bookNumber;
	String bookTitle;
	
	Book(int bn, String bt){
		this.bookNumber = bn;
		this.bookTitle = bt;
	}


@Override
	public String toString() {
		return bookTitle + "," + bookNumber;
	}

}
public class ToStringEx {
	public static void main(String[] args) {
		Book book1 = new Book(200, "개미");
		
		System.out.println(book1);
		System.out.println(book1.toString());
		
		Student1 stu = new Student1(100, "이상원");
		System.out.println(stu.toString());
	}
}
