package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ReverseNumber {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("���ڸ� �Է��ϼ��� : ");
		int n = Integer.parseInt(inbr.readLine());
		int r;
		System.out.print("�ٲ����(����): ");
		while(n!=0) {
			r = n%10;
			n/=10;
			System.out.print(r);
		}
	}
}
