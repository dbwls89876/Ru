package test;

import lambda.Calc;

public class Q4{
	public static void main(String[] args) {
		Calc c = (s, v) -> {return s + v;};
		System.out.println(c.add(1, 2));
		
		Shape tri = (w, h) -> {return w*h/2;}; 
		Shape rectangle = (w, h) -> {return w*h;};
		
		System.out.println("삼각형 면적 : " + tri.area(3, 2));
		System.out.println("사각형 면적 : " + rectangle.area(3, 2));
	}

}
