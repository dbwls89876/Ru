package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class multifle {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("������ �Է��ϼ��� : ");
		int n = Integer.parseInt(inbr.readLine());
		System.out.print("����� �Է��ϼ��� : ");
		int m = Integer.parseInt(inbr.readLine());
		int count=0, sum=0;
		for(int i = 1; i<=n; i++) {
			if(i%m==0) {
				sum+=i;count++;
			}
		}
		System.out.println("1���� �Էµ� ���� "+n+"������ "+m+"�� ����� ���� : " + count);
		System.out.println("1���� �Էµ� ���� "+n+"������ "+m+"�� ����� �հ� : " + sum);
	}
}
