package example;

public class Triangle extends Shape{
	
	public Triangle( int w, int h) {
		super(w, h);
	}
	
	@Override
	public void showInfo() {
		System.out.println("삼각형의 밑변 : " + width);
		System.out.println("삼각형의 높이 : " + height);
		System.out.println("삼각형의 면적 : " + getArea());

	}
	@Override
	public double getArea() {
		return width*height/2.0;
	}
}
