package staticex;

public class StudentTest4 {
	public static void main(String[] args) {
		Student2 studentLee = new Student2();
		studentLee.setStudentName("이지원");
		System.out.println(Student2.getSerialNum());
		System.out.println(studentLee.studentName + "학번 : " + studentLee.studentID);
		System.out.println("이지원의 카드번호 : " + studentLee.cardNum);
		
		Student2 studentSon = new Student2();
		studentSon.setStudentName("손수경");
		System.out.println(Student2.getSerialNum());
		System.out.println(studentSon.studentName + "학번 : " + studentSon.studentID);
		System.out.println("손수경의 카드번호 : " + studentSon.cardNum);
	}
}
