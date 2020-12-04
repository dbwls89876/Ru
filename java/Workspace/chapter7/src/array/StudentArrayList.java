package array;

import java.util.ArrayList;

public class StudentArrayList {

	public static void main(String[] args) {
		ArrayList<Student> arr = new ArrayList<Student>();
		arr.add(new Student(1001, "James"));
		arr.add(new Student(1002, "Tomas"));
		arr.add(new Student(1003, "Edward"));
		
		for(Student stu : arr) {
			stu.showStudentInfo();
		}
	}

}
