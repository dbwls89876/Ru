package classpart;

public class Man {
	String name;
	int age, child;
	boolean marriage;
	public static void main(String[] args) {
		Man m = new Man();
		m.setName("James");
		m.setAge(40);
		m.setMarriage(true);
		m.setChild(3);
		
		System.out.println("�̸� : " + m.getName());
		System.out.println("���� : " + m.getAge());
		System.out.print("��ȥ ���� : ");
		if(m.isMarriage()==true)
			System.out.println("��");
		else
			System.out.println("��");
		System.out.println("�ڽ��� �� : " + m.getChild());
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public int getChild() {
		return child;
	}
	public void setChild(int child) {
		this.child = child;
	}
	public boolean isMarriage() {
		return marriage;
	}
	public void setMarriage(boolean marriage) {
		this.marriage = marriage;
	}

}
