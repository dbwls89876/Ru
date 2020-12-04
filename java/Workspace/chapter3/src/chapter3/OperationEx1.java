package chapter3;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class OperationEx1 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("수학 점수를 입력하세요 : ");
		int mathScore = Integer.parseInt(inbr.readLine());
		System.out.print("영어 점수를 입력하세요 : ");
		int engScore = Integer.parseInt(inbr.readLine());
		System.out.print("국어 점수를 입력하세요 : ");
		int korScore = Integer.parseInt(inbr.readLine());
		
		int totalScore = mathScore + engScore + korScore;
		System.out.println(totalScore);
		
		double avgScore = totalScore / 3.0;
		System.out.println(avgScore);
	}
}
