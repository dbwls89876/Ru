package test;

public class ShapeTest {
	public static void main(String[] args) {
		Rect rt1 = new Rect();
		
		rt1.setHeight(200);
		rt1.setWidth(30);
		
		System.out.println("사각형 높이 : " + rt1.getHeight() + ", 넓이 : " + rt1.getWidth() + ", 면적 : " + rt1.getArea() + "\n");
		
		Triangle tr1 = new Triangle(40, 35);
		
		System.out.println("삼각형 높이 : " + tr1.getHeight() + ", 밑변 : " + tr1.getWidth() + ", 면적 : " + tr1.getArea() + "\n");
		
	}
}
