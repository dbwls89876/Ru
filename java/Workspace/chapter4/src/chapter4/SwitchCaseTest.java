package chapter4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SwitchCaseTest {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int e;
		System.out.print("�̵��Ͻ� ���� �Է����ּ��� : ");
		e=Integer.parseInt(inbr.readLine());
		switch(e) {
		case 1 : System.out.println("1�� �౹�Դϴ�.");break;
		case 2 : System.out.println("2�� �����ܰ��Դϴ�.");break;
		case 3 : System.out.println("3�� �Ǻΰ��Դϴ�.");break;
		case 4 : System.out.println("4�� ġ���Դϴ�.");break;
		default : System.out.println("5�� �ｺ Ŭ���Դϴ�.");
		}
		
	}
}
