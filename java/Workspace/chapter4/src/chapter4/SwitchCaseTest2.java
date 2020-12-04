package chapter4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SwitchCaseTest2 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("성적을 입력하세요 : ");
		int score = Integer.parseInt(inbr.readLine());
		char grade;
		switch(score/10) {
			case 9: grade = 'A'; break;
			case 8: grade = 'B'; break;
			case 7: grade = 'C'; break;
			case 6: grade = 'D'; break;
			default: grade = 'F';
			}
		System.out.println("성적은 "+score+ "이고 학점은 "+grade+"입니다.");
	}
} 
