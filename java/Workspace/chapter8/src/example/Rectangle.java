package example;

public class Rectangle extends Shape{
	
	public Rectangle(int w, int h) {
		super(w, h);
	}
	
	public double getArea() {
		return (double)width*height;
	}
	@Override
	public void showInfo() {
		System.out.println("사각형의 넓이 : " + width);
		System.out.println("사각형의 높이 : " + height);
		System.out.println("사각형의 면적 : " + getArea());
	}
}
