package example;

public class Circle extends Shape{
	int radius;
	
	public Circle(int r) {
		super();
		this.radius = r;
	}
	
	@Override
	public double getArea() {
		return PI*radius*radius;
	}
	
	public double getCircumfevence() {
		return radius*2*PI;
	}
	
	@Override
	public void showInfo() {
		System.out.println("원의 반지름 : " + radius);
		System.out.println("원의 원주율 : " + getCircumfevence());
	}
}
