package test;

import classpart.Student;

public class StudentTest1 {
	public static void main(String[] args) {
		Student s1 = new Student();
		s1.studentName = "안연수";
		System.out.println(s1.getStudentName());
		Student s2 = new Student();
		s2.studentName = "안승연";
		System.out.println(s2.getStudentName());
	}
}
