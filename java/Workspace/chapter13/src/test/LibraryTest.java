package test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Stream;

class Book{
	private String name;
	private int price;
	
	public Book(String name, int price) {
		this.name = name;
		this.price = price;
	}
	
	public int getPrice() {
		return price;
	}
	
	public String getName() {
		return name;
	}
}

public class LibraryTest {

	public static void main(String[] args) {
			List<Book> bookList = new ArrayList<>();
			int n;
			
			bookList.add(new Book("자바", 25000));
			bookList.add(new Book("파이썬", 15000));
			bookList.add(new Book("안드로이드", 30000));
			
			Stream<Book> stream1 = bookList.stream();
			System.out.println("모든 책의 가격의 합은 " + stream1.mapToInt(s->s.getPrice()).sum() + "입니다.");
			Stream<Book> stream2 = bookList.stream();
			stream2.filter(c->c.getPrice()>=20000).map(c->c.getName()).sorted().forEach(s->System.out.println(s));
	}
}

