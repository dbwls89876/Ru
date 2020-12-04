package chapter4;

public class Chapter4Q1 {
	public static void main(String[] args) {
		int num1 = 10;
		int num2 = 2;
		int result = 0;
		char operator = '+';
		switch(operator) {
		case '+' : result = num1+num2; break;
		case '-' : result = num1-num2; break;
		case '*' : result = num1*num2; break;
		case '/' : result = num1/num2; break;
		default : System.out.println("잘못된 연산자입니다.");
		}
		
		System.out.println(num1 +" "+operator+" "+ num2 + " = " + result);
	}
}
