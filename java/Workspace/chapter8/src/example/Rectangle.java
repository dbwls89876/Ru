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
		System.out.println("�簢���� ���� : " + width);
		System.out.println("�簢���� ���� : " + height);
		System.out.println("�簢���� ���� : " + getArea());
	}
}
