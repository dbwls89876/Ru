package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Quest2 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		String studentNum, name;
		int toepl;
		System.out.print("�̸�, �й�, ���� ������ �Է��ϼ���! : ");
		name = inbr.readLine();
		studentNum = inbr.readLine();
		toepl = Integer.parseInt(inbr.readLine());
		System.out.println("���� �̸��� " + name + "�Դϴ�.");
		System.out.println("�й���" + studentNum + "�Դϴ�.");
		System.out.println("�׸��� ���� ������" + toepl + "�� �Դϴ�.");
	}
}
