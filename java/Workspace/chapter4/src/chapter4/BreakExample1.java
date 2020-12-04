package chapter4;

public class BreakExample1 {

	public static void main(String[] args) {
		int sum = 0, num = 0;
		
		for(num = 0; sum < 100; num++) {
			sum+=num;
		}
		System.out.println("num : " + num);
		System.out.println("sum : " + sum);
	}

}
