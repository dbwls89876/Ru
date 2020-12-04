package staticex;

public class StudentTest1 {
	public static void main(String[] args) {
		Student stuLee = new Student();
		stuLee.setStudentName("이지원");
		System.out.println(stuLee.serialNum);
		stuLee.serialNum++;
		
		Student studentSon = new Student();
		studentSon.setStudentName("손수경");
		System.out.println(studentSon.serialNum);
		System.out.println(stuLee.serialNum);
	}
}
