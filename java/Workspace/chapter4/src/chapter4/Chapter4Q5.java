package chapter4;

public class Chapter4Q5 {
	public static void main(String[] args) {
		int i, j, n=3;	
		
		for(i = 0; i<4; i++) {
			for(j=0; j<n; j++) {
				System.out.print(" ");
			}
			for(j = 0; j<(1+2*i); j++) {
				System.out.print("*");
			}
			System.out.println();
			if(n==0) {
				while(true) {
					n++;
					for(j=0; j<n; j++) {
						System.out.print(" ");
					}
					for(j = 0; j<(1+2*(i-n)); j++) {
						System.out.print("*");
					}
					System.out.println();
					if(n==3)
						break;				
				}	
			}
			n--;		
		}		
	}
}