package chapter2;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Chapter2Q4_1 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("ù��° ���� �Է��ϼ���(����) : ");
		int a = Integer.parseInt(inbr.readLine());
		System.out.println("�ι�° ���� �Է��ϼ���(����) : ");
		double b = Double.parseDouble(inbr.readLine());
		System.out.println(a+" + "+b+" = "+(int)(a+b));
		System.out.println(a+" - "+b+" = "+(int)(a-b));
		System.out.println(a+" * "+b+" = "+(int)(a*b));
		System.out.println(a+" / "+b+" = "+(int)(a/b));
		

	}

}
