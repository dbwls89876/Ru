package ��2.������;

import java.util.ArrayList;

import ��2.������.subject.Subject;

public class Main {

	public static void main(String[] args) {
		ArrayList<Student> list = new ArrayList<Student>();
		list.add(new Student(1, 90, 90, 90));
		list.add(new Student(2, new Subject(88, 97, 90)));
		list.add(new Student(3, 70, 70, 70));
		CalcRank.calcRank(list);
		int i = 1;
		
		for(Student s : list) {
			System.out.println(i + "�� �л� : ");
			s.subject.showSubjectInfo();
			System.out.println("���� : " + s.rank);
			System.out.println();
			i++;
		}
	}

}
