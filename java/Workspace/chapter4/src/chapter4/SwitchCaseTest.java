package chapter4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SwitchCaseTest {
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader inbr = new BufferedReader(new InputStreamReader(System.in));
		int e;
		System.out.print("이동하실 층을 입력해주세요 : ");
		e=Integer.parseInt(inbr.readLine());
		switch(e) {
		case 1 : System.out.println("1층 약국입니다.");break;
		case 2 : System.out.println("2층 정형외과입니다.");break;
		case 3 : System.out.println("3층 피부과입니다.");break;
		case 4 : System.out.println("4층 치과입니다.");break;
		default : System.out.println("5층 헬스 클럽입니다.");
		}
		
	}
}
