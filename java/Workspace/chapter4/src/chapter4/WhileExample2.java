package chapter4;

public class WhileExample2 {
	public static void main(String[] args) {
		int num = 1;
		int sum = 0;
		
		while(num<=10) {
			if(num%2==0) {
				sum+=num;
			}
		}
		System.out.println("1���� 10������ ¦���� ����" + sum + "�Դϴ�.");
	}
}