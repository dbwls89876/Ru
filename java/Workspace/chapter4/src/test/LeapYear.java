package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class LeapYear {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("�⵵�� �Է����ּ���: ");
		int n = Integer.parseInt(inbr.readLine());
		
		if(n%4==0&&n%100==0&&n%400==0)
			System.out.println("�����Դϴ�.");
		else if(n%4==0&&n%100==0)
			System.out.println("������ �ƴմϴ�.");
		else if(n%4==0)
			System.out.println("�����Դϴ�.");
		else 
			System.out.println("������ �ƴմϴ�.");
			
	}
}
