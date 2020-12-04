package chapter3;

public class OperationEx3 {
	public static void main(String[] args) {
		int num1 = 10, num2 = 20;		
		int i = 2;
		
		boolean flag = (num1 > 0)&&(num2 > 0);
		System.out.println(flag);
		flag = (num1 < 0) && (num2 > 0);
		System.out.println(flag);
		flag = (num1 < 0) || (num2 > 0);
		System.out.println(flag);
		System.out.println();
		
		boolean value = ((num1 = num1+10)<10)&&((i=i+2)<10);
		System.out.println(value);
		System.out.println(num1);
		System.out.println(i);
		
		value = ((num1 = num1 + 10)>10) || ((i=i+2)<10);
				
		System.out.println(value);
		System.out.println(num1);
		System.out.println(i);
	
		int  num = 5;
		i = 10;
		
		value = ((num = num * 10)>45)||((i = i - 5)<10);
		System.out.println(value);
		System.out.println(num);
		System.out.println(i);
	}
}
