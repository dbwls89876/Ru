package school;

public class Score {
	int studentID;
	Subject subject;
	int point;
	
	public Score(int stuID, Subject subject, int point) {
		this.studentID = stuID;
		this.subject = subject;
		this.point = point;
	}

	public int getStudentID() {
		return studentID;
	}

	public void setStudentID(int studentID) {
		this.studentID = studentID;
	}

	public Subject getSubject() {
		return subject;
	}

	public void setSubject(Subject subject) {
		this.subject = subject;
	}

	public int getPoint() {
		return point;
	}

	public void setPoint(int point) {
		this.point = point;
	}
	
	public String toString() {
		return "ÇÐ¹ø : " + studentID + ", " + subject.getSubjectName() + " : " +point;
	}
}
