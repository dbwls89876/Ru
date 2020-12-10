package object;

class Student{
	int studentID;
	String studentName;
	
	public Student(int studentID, String studentName) {
		this.studentID = studentID;
		this.studentName = studentName;
	}
	
	public String toString() {
		return studentID + "," + studentName;
	}
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Student) {
			Student std = (Student)obj;
			if(this.studentID == std.studentID)
				return true;
			else return false;
		}
		return false;
	}
	
	@Override
	public int hashCode() {
		return studentID;
	}
}

public class EqualsTest {

	public static void main(String[] args) {
		Student studentLee = new Student(100, "�̻��");
		Student studentLee2 = studentLee;
		Student studentSang = new Student(100, "�̻��");
		
		if(studentLee == studentLee2) {
			System.out.println("studentLee�� studentLee2�� �ּҴ� �����ϴ�.");
		}
		else {
			System.out.println("studentLee�� studentLee2�� �ּҴ� �ٸ��ϴ�.");
		}
		
		if(studentLee.equals(studentLee2))
			System.out.println("studentLee�� studentLee2�� �����մϴ�.");
		else
			System.out.println("studentLee�� studentLee2�� �������� �ʽ��ϴ�.");
		
		if(studentLee == studentSang)
			System.out.println("studentLee�� studentLee2�� �ּҴ� �����ϴ�.");
		else
			System.out.println("studentLee�� studentLee2�� �ּҴ� �ٸ��ϴ�.");
	
		if(studentLee.equals(studentSang))
			System.out.println("studentLee�� studentSang�� �����մϴ�.");
		else
			System.out.println("studentLee�� studentSang�� �������� �ʽ��ϴ�.");
		
		System.out.println("studentLee�� hashCode : " + studentLee.hashCode());
		System.out.println("studentSang�� hashCode : " + studentSang.hashCode());

		System.out.println("studentLee�� ���� �ּҰ� : : " + System.identityHashCode(studentLee));
		System.out.println("studentSang�� ���� �ּҰ� : : " + System.identityHashCode(studentSang));
	}
}
