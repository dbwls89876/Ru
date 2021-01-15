package 평가2.정유진;

import 평가2.정유진.subject.Subject;

public class Student {
	protected int studentNum;
	protected Subject subject;
	protected int rank = 1;
	
	public Student() {
		
	}
	
	public Student(int sNum, int kor, int eng, int math) {
		studentNum = sNum;
		subject = new Subject(kor, eng, math);
	}
	
	public Student(int sNum, Subject subject) {
		studentNum = sNum;
		this.subject = subject;
	}

}
