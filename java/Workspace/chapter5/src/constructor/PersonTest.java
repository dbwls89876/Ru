package constructor;

public class PersonTest {
	public static void main(String[] args) {
		Person personKim = new Person();
		personKim.name = "김유신";
		personKim.weight = 85.5F;
		personKim.height = 180.0F;
		
		Person personLee = new Person("이순신", 175, 75);
		Person p = new Person("냥");
		Person personTest = new Person("홍길동", 179.0f, 80.0f);
	}
	
}
