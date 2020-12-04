package chapter4;

public class WhileExample1_1 {
	public static void main(String[] args) {
		int num = 1;
		int sum = 0;
		
		while(num <= 50) {
			sum += 50;
			num++;
		}
		System.out.println("1부터 50까지의 합은" + sum + "입니다.");
	}
}
