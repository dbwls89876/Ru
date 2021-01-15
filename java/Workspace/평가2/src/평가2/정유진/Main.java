package 평가2.정유진;

import java.util.ArrayList;

import 평가2.정유진.subject.Subject;

public class Main {

	public static void main(String[] args) {
		ArrayList<Student> list = new ArrayList<Student>();
		list.add(new Student(1, 90, 90, 90));
		list.add(new Student(2, new Subject(88, 97, 90)));
		list.add(new Student(3, 70, 70, 70));
		CalcRank.calcRank(list);
		int i = 1;
		
		for(Student s : list) {
			System.out.println(i + "번 학생 : ");
			s.subject.showSubjectInfo();
			System.out.println("석차 : " + s.rank);
			System.out.println();
			i++;
		}
	}

}
