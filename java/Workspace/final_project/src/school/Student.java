package school;

import java.util.ArrayList;

public class Student {
	private int studentID;
	private String studentName;
	private Subject majorSubject;
	
	private ArrayList<Score> scoreList = new ArrayList<Score>();
	
	public Student(int stuID, String stuName, Subject ms) {
		this.studentID = stuID;
		this.studentName = stuName;
		this.majorSubject = ms;
	}

	public void addSubjectScore(Score score) {
		scoreList.add(score);
	}
	
	public int getStudentID() {
		return studentID;
	}

	public void setStudentID(int studentID) {
		this.studentID = studentID;
	}

	public String getStudentName() {
		return studentName;
	}

	public void setStudentName(String studentName) {
		this.studentName = studentName;
	}

	public Subject getMajorSubject() {
		return majorSubject;
	}

	public void setMajorSubject(Subject majorSubject) {
		this.majorSubject = majorSubject;
	}

	public ArrayList<Score> getScoreList() {
		return scoreList;
	}

	public void setScoreList(ArrayList<Score> scoreList) {
		this.scoreList = scoreList;
	}

}
