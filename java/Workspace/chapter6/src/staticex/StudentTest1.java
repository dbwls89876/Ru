package staticex;

public class StudentTest1 {
	public static void main(String[] args) {
		Student stuLee = new Student();
		stuLee.setStudentName("������");
		System.out.println(stuLee.serialNum);
		stuLee.serialNum++;
		
		Student studentSon = new Student();
		studentSon.setStudentName("�ռ���");
		System.out.println(studentSon.serialNum);
		System.out.println(stuLee.serialNum);
	}
}
