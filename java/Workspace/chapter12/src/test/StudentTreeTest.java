package test;

import java.util.TreeSet;

public class StudentTreeTest {

	public static void main(String[] args) {
		TreeSet<Student> set = new TreeSet<Student>();
		set.add(new Student("100", "ȫ�浿"));
		
		set.add(new Student("400", "�����"));
		set.add(new Student("200", "������"));
		set.add(new Student("300", "�̼���"));
		
		set.add(new Student("100", "���߱�"));
		
		System.out.println(set);
	}

}
