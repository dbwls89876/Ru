package constructor;

public class PersonTest {
	public static void main(String[] args) {
		Person personKim = new Person();
		personKim.name = "������";
		personKim.weight = 85.5F;
		personKim.height = 180.0F;
		
		Person personLee = new Person("�̼���", 175, 75);
		Person p = new Person("��");
		Person personTest = new Person("ȫ�浿", 179.0f, 80.0f);
	}
	
}
