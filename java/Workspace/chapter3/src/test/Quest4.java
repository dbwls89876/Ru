package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Quest4 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int price;
		double sale;
		System.out.print("��ǰ�� ������ �Է��ϼ��� : ");
		price = Integer.parseInt(inbr.readLine());
		System.out.print("������(%)�� �Է��ϼ��� : ");
		sale = Double.parseDouble(inbr.readLine());
		
		System.out.println("��ǰ���� : " + price + "��");
		System.out.println("������(%) : " + sale);
		System.out.println("���ϰ��� : " + price/100*(100-sale));
	
	}


}