package example;

public class Cylinder extends Circle{
	
	

	public Cylinder(int r, int h) {
		super(r);
		height = h;
	}

	public double getVolume() {
		return getArea()*height;
	}
	
	@Override
	public void showInfo() {
		super.showInfo();
		System.out.println("�Ǹ����� ���� : " + height);
		System.out.println("�Ǹ����� ���� : " + getVolume());
	}
}