package chapter4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class WhileExample3 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("합계를 구할 배수를 입력해주세요 : ");
		int n = Integer.parseInt(inbr.readLine());
		int i = 1, sum = 0;
		while(i<=50) {
			if(i%n==0)
				sum+=i;
			i++;
		}
		System.out.println("1부터 50까지의" + n + "의 배수의 합은 " + sum + "입니다.");
	}
}
