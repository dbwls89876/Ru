package chapter3;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class OperationEx1 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("���� ������ �Է��ϼ��� : ");
		int mathScore = Integer.parseInt(inbr.readLine());
		System.out.print("���� ������ �Է��ϼ��� : ");
		int engScore = Integer.parseInt(inbr.readLine());
		System.out.print("���� ������ �Է��ϼ��� : ");
		int korScore = Integer.parseInt(inbr.readLine());
		
		int totalScore = mathScore + engScore + korScore;
		System.out.println(totalScore);
		
		double avgScore = totalScore / 3.0;
		System.out.println(avgScore);
	}
}
