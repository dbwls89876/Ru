package codingTest;


public class third {

	public static int factorial(int n) {
		if(n<=1)
			return 1; //��� Ż��
		return n*factorial(n-1);
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int result = factorial(4);
		System.out.println(result);
	}
	
	
	
}
