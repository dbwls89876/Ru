package chapter4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class IfExampleTest {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		
		char grade;
		System.out.print("������ �Է����ּ��� : ");
		int score = Integer.parseInt(inbr.readLine());
		if(score>=90)
			grade = 'A';
		else if(score>=80)
			grade = 'B';
		else if(score>=70)
			grade = 'C';
		else if(score>=60)
			grade = 'D';
		else
			grade = 'F';
		System.out.println("������ "+score+ "�̰� ������ "+grade+"�Դϴ�.");
	}
}
