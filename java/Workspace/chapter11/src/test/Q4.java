package test;

class MyDog{
	String name;
	String type;
	
	public MyDog(String name, String type) {
		this.name = name;
		this.type = type;
	}
	
	@Override
	public String toString() {
		return this.type + " " + this.name;
	}
}

public class Q4 {
	public static void main(String[] args) {
		MyDog dog = new MyDog("∏€∏€¿Ã", "¡¯µæ∞≥");
		System.out.println(dog);
	}
}
