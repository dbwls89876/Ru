package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Quest4 {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int price;
		double sale;
		System.out.print("상품의 가격을 입력하세요 : ");
		price = Integer.parseInt(inbr.readLine());
		System.out.print("할인율(%)을 입력하세요 : ");
		sale = Double.parseDouble(inbr.readLine());
		
		System.out.println("상품가격 : " + price + "원");
		System.out.println("할인율(%) : " + sale);
		System.out.println("세일가격 : " + price/100*(100-sale));
	
	}


}