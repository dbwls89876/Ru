package classpart;

public class FunctionTest {
	
	public static void main(String[] args) {
		int n1 = 10;
		int n2 = 20;
		
		int sum = add(n1, n2);
		System.out.println(n1 +"+"+ n2+"="+sum+"�Դϴ�.");
	}
	public static int add(int n1, int n2) {
		int result = n1+n2;
		return result;
	}
	public static double div(int n1, int n2) {
		if(n2==0) {
			System.out.println("������ ���� 0�� �� �� �����ϴ�.");
			return 0;
		}
		double result = (double)n1/+n2;
		return result;
	}
	
	public static int mul(int n1, int n2) {
		int result = n1*n2;
		return result;
	}
	public static int sub(int n1, int n2) {
		int result = n1-n2;
		return result;
	}
	
}
