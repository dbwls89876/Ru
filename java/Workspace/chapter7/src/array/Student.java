package array;

import java.util.ArrayList;

public class Student {
	private int studentID;
	private String studentName;
	ArrayList<Subject> subjectList;
	
	public Student(int stuID, String stuName) {
		this.studentID = stuID;
		this.studentName = stuName;
		subjectList = new ArrayList<Subject>();
	}
	
	public void addSubject(String name, int score) {
		Subject subject = new Subject();
		subject.setName(name);
		subject.setScorePoint(score);
		subjectList.add(subject);
	}
	
	public void showStudentInfo() {
		int total = 0;
		for(Subject s : subjectList) {
			total += s.getScorePoint();
			System.out.println("�л�" + 
			studentName + "�� " + s.getName() + "���� ������"
			+ s.getScorePoint() + "�Դϴ�.");
		}
		System.out.println("�л�" + 
				studentName + "�� ������"
				+ total + "�Դϴ�.");
		
	}
	
	public String getStudentName() {
		return studentName;
	}
	public void setStudentName(String name) {
		this.studentName = name;
	}
}
