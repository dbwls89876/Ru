package example;

public class Triangle extends Shape{
	
	public Triangle( int w, int h) {
		super(w, h);
	}
	
	@Override
	public void showInfo() {
		System.out.println("�ﰢ���� �غ� : " + width);
		System.out.println("�ﰢ���� ���� : " + height);
		System.out.println("�ﰢ���� ���� : " + getArea());

	}
	@Override
	public double getArea() {
		return width*height/2.0;
	}
}