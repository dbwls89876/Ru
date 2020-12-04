package reference;

public class Student3Test {
	public static void main(String[] args) {
		Student3 s = new Student3();
	
		s.korean = new Subject("±¹¾î", 90);
		System.out.println(s.korean.SubjectName);
	}
}
