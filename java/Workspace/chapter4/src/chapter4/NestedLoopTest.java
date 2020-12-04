package chapter4;

public class NestedLoopTest {
	public static void main(String[] args) {
		int dan, times;
		for(dan = 1; dan<=9; dan++) {
			for(times = 1; times<=9; times++) {
				System.out.print(times+"X"+dan+"="+dan*times+"  ");
				if(dan*times<10)
					System.out.print(" ");
			}
			System.out.println();
		}
	}
}
