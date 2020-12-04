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
		System.out.println("���� ������ : " + radius);
		System.out.println("���� ������ : " + getCircumfevence());
	}
}
