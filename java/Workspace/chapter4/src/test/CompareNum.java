package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CompareNum {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int a, b;
		System.out.print("첫번째 값 입력 : ");
		a = Integer.parseInt(inbr.readLine());
		System.out.print("두번째 값 입력 : ");
		b = Integer.parseInt(inbr.readLine());
		
		if(a==b)
			System.out.println("값이 같습니다.");
		else if(a>b)
			System.out.println(a+"가"+b+"보다 큽니다.");
		else
			System.out.println(b+"가"+a+"보다 큽니다.");
	}
}
