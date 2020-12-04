package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class InfiniteLoop {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		while(true) {
			System.out.print("두개의 정수를 입력하세요 : ");
			int a = Integer.parseInt(inbr.readLine());
			int b = Integer.parseInt(inbr.readLine());
			System.out.println("두 정수의 곱 : "+a*b);
			if(a*b>500) {
				System.out.println("프로그램을 종료합니다.");break;
			}
		}
		
	}

}
