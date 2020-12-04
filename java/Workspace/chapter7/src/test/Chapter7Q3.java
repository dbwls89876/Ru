package test;

public class Chapter7Q3 {
	public static void main(String[] args) {
		int[] arr = new int[5];
		int j = 0;
		for(int i = 1; i<=10; i++) {
			if(i%2==0) {
				arr[j]=i;
				j++;
			}
		}
		for(int a : arr) {
			System.out.println(a);
		}
		int sum = 0;
		for(int i = 0; i<5; i++)
			sum+=arr[i];
		System.out.println(sum);
	}
}
