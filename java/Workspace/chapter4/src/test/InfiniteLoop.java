package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class InfiniteLoop {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		while(true) {
			System.out.print("�ΰ��� ������ �Է��ϼ��� : ");
			int a = Integer.parseInt(inbr.readLine());
			int b = Integer.parseInt(inbr.readLine());
			System.out.println("�� ������ �� : "+a*b);
			if(a*b>500) {
				System.out.println("���α׷��� �����մϴ�.");break;
			}
		}
		
	}

}
