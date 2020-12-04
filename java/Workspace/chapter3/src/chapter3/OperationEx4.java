package chapter3;

public class OperationEx4 {
	public static void main(String[] args) {
		int fatherAge = 45;
		int motherAge = 47;
		int num = 10;
		boolean isEven;
		char ch;
		ch = (fatherAge > motherAge) ? 'T' : 'F';
		
		System.out.println(ch);
	
		isEven = num%2==0 ? true : false;
	}
}
