package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Quest2 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		String studentNum, name;
		int toepl;
		System.out.print("이름, 학번, 토플 점수를 입력하세요! : ");
		name = inbr.readLine();
		studentNum = inbr.readLine();
		toepl = Integer.parseInt(inbr.readLine());
		System.out.println("나의 이름은 " + name + "입니다.");
		System.out.println("학번은" + studentNum + "입니다.");
		System.out.println("그리고 토플 점수는" + toepl + "점 입니다.");
	}
}
