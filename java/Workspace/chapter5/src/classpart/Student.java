package classpart;

public class Student {
	int studentID;
	public String studentName;
	int garde;
	String address;
	
	public static void main(String[] args) {
		Student studentAhn = new Student();
		studentAhn.studentName = "¾È¿¬¼ö";
		System.out.println(studentAhn.studentName);
		System.out.println(studentAhn.getStudentName());
	}

	public void showStudentInfo() {
		System.out.print(studentName+","+address);
	}
	
	public String getStudentName() {
		return studentName;
	}

	public void setStudentName(String studentName) {
		this.studentName = studentName;
	}
	
	
	public int getStudentID() {
		return studentID;
	}

	public void setStudentID(int studentID) {
		this.studentID = studentID;
	}

	public int getGarde() {
		return garde;
	}

	public void setGarde(int garde) {
		this.garde = garde;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}
}