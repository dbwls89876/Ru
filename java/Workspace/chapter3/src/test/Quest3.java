package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Quest3 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int r;
		final double PI = 3.14159;
		
		System.out.print("���� �������� �Է����ּ��� : ");
		r = Integer.parseInt(inbr.readLine());
		System.out.println("���� ������ : "+r+"\n"+"���� �ѷ� : " + 2*r*PI);
	}
}
