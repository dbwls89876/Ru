package object;

public class Student1 {
	public static int serialNum = 1000;
	public int studentID;
	public String studentName;
	public int garde;
	public String address;
	public static int getSerialNum() {
		return serialNum;
	}
	
	public Student1(int n, String name) {
		this.studentID = n;
		this.studentName = name;
	}
	
	public static void setSerialNum(int serialNum) {
		Student1.serialNum = serialNum;
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
	
	@Override
	public String toString() {
		return "이름 : " + studentName + "학번 : " + studentID;
	}
	
}
