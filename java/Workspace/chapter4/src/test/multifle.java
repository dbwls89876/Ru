package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class multifle {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("정수를 입력하세요 : ");
		int n = Integer.parseInt(inbr.readLine());
		System.out.print("배수를 입력하세요 : ");
		int m = Integer.parseInt(inbr.readLine());
		int count=0, sum=0;
		for(int i = 1; i<=n; i++) {
			if(i%m==0) {
				sum+=i;count++;
			}
		}
		System.out.println("1부터 입력된 정수 "+n+"까지의 "+m+"의 배수의 갯수 : " + count);
		System.out.println("1부터 입력된 정수 "+n+"까지의 "+m+"의 배수의 합계 : " + sum);
	}
}
