package array;

public class TwoDimension {

	public static void main(String[] args) {
		int[][] arr = {{1, 2, 3}, {4, 5, 6}};
		for(int i = 0; i<arr.length; i++) {
			for(int j = 0; j<arr[i].length; j++)
				System.out.print(arr[i][j]);
		System.out.println();
		}
		
		for(int[] row : arr) {
			for(int col : row) {
				System.out.println(col);
			}
		}
		
		char[][] ch = new char[13][2];
		char a = 'a';
		
		for(int i = 0; i<ch.length; i++) {
			for(int j = 0; j<ch[i].length; j++) {
				ch[i][j] = a;
				a++;
				System.out.print(ch[i][j] + "        ");
			}
			System.out.println();
		}
		
	}

}