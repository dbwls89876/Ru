package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SumOfBetweenNums {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("ù��° ���� �Է��ϼ��� : ");
		int a = Integer.parseInt(inbr.readLine());
		System.out.print("�ι�° ���� �Է��ϼ��� : ");
		int b = Integer.parseInt(inbr.readLine());
		int sum = 0, cnt=0, max, min, temp;
		
		if(a>b) {
			temp=b;
			b=a;
			a=temp;
		}
		for(int i = a; i<=b; i++) {
			sum+=i;cnt++;
		}
		
		/* min, max
		if(a>b) {
			max=a; min=b;
		}
		else {
			max=b; min=a;
		}
			
		for(int i = min; i<=max; i++) {
			sum+=i;cnt++;
		}
	/*	for�� 2��
	 * if(a>b) {
			for(int i = b; i<=a; i++)
				sum+=i;cnt++;
		}
		else if(a<=b) {
			for(int i = a; i<=b; i++)
				sum+=i;cnt++;
		}*/
		System.out.println(a+"����"+b+"������ �� : " + sum);
		System.out.println("���� : " + cnt);
	}

}
