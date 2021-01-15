package 평가2.정유진.subject;

import java.util.ArrayList;

public class SubjectTest {

	public static void main(String[] args) {
		ArrayList<Subject> list = new ArrayList<Subject>();
		Subject s = new Subject(90, 80, 100);
		ScienceSubject ss = new ScienceSubject(80, 80, 100, 80, 90);
		LiterarySubject ls = new LiterarySubject(80, 70, 75, 86);
		
		list.add(s);
		list.add(ss);
		list.add(ls);
		
		for(Subject i : list) {
			i.showSubjectInfo();
			System.out.println();
		}
	}

}
