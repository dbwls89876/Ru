package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CompareNum {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int a, b;
		System.out.print("ù��° �� �Է� : ");
		a = Integer.parseInt(inbr.readLine());
		System.out.print("�ι�° �� �Է� : ");
		b = Integer.parseInt(inbr.readLine());
		
		if(a==b)
			System.out.println("���� �����ϴ�.");
		else if(a>b)
			System.out.println(a+"��"+b+"���� Ů�ϴ�.");
		else
			System.out.println(b+"��"+a+"���� Ů�ϴ�.");
	}
}
