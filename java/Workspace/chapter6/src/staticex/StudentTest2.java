package staticex;

public class StudentTest2 {

	public static void main(String[] args) {
		Student1 stuLee = new Student1();
		stuLee.setStudentName("이지원");
		System.out.println(stuLee.serialNum);
		System.out.println(stuLee.studentName + "학번 : " + stuLee.studentID);
		
		Student1 studentSon = new Student1();
		studentSon.setStudentName("손수경");
		System.out.println(studentSon.serialNum);
		System.out.println(studentSon.studentName + "학번 : " + studentSon.studentID);
		
	}

}
