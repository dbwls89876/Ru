package staticex;

public class StudentTest2 {

	public static void main(String[] args) {
		Student1 stuLee = new Student1();
		stuLee.setStudentName("������");
		System.out.println(stuLee.serialNum);
		System.out.println(stuLee.studentName + "�й� : " + stuLee.studentID);
		
		Student1 studentSon = new Student1();
		studentSon.setStudentName("�ռ���");
		System.out.println(studentSon.serialNum);
		System.out.println(studentSon.studentName + "�й� : " + studentSon.studentID);
		
	}

}
