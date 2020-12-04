package hiding;

public class Student {
	int studentID;
	private String studentName;
	int grade;
	String address;
	
	public String getStudentName() {
		return this.studentName;
	}
	
	public void setStudentNmae(String studentName) {
		this.studentName = studentName;
	}
	
}
