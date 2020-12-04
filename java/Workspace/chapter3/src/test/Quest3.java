package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Quest3 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int r;
		final double PI = 3.14159;
		
		System.out.print("원의 반지름을 입력해주세요 : ");
		r = Integer.parseInt(inbr.readLine());
		System.out.println("원의 반지름 : "+r+"\n"+"원의 둘레 : " + 2*r*PI);
	}
}
