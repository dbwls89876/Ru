package test;


public class Student implements Comparable<Student>{
	private String studentID;
	private String studentName;
	
	public Student(String studentID,String studentName) {
		this.studentID = studentID;
		this.studentName = studentName;
	}
	
	@Override
	public int compareTo(Student s) {
		return this.studentID.compareTo(s.studentID);
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return studentID + " : " + studentName;
	}

	public String getStudentID() {
		return studentID;
	}

	public void setStudentID(String studentID) {
		this.studentID = studentID;
	}

	public String getStudentName() {
		return studentName;
	}

	public void setStudentName(String studentName) {
		this.studentName = studentName;
	}

	@Override
	public int hashCode() {
		// TODO Auto-generated method stub
		return Integer.parseInt(studentID);
	}

	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Student) {
			Student student = (Student)obj;
			if(this.studentID == student.studentID) {
				return true;
			}else
				return false;
		}
		return false;
	}
	
}
