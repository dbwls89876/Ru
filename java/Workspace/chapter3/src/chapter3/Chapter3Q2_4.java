package chapter3;

public class Chapter3Q2_4 {
	public static void main(String[] args) {
		//Q2
		int num;
		num = -5+3*10/2;
		System.out.println(num);
		//Q3
		num = 10;
		
		System.out.println(num);
		System.out.println(num++);
		System.out.println(num);
		System.out.println(--num);
		
		//Q4
		int num1 = 10;
		int num2 = 20;
		boolean result;
		
		result = ((num1>10)&&(num2>10));
		System.out.println(result);
		result = ((num1>10) || (num2>10));
		System.out.println(result);
		System.out.println(!result);
		
		
	}
}
