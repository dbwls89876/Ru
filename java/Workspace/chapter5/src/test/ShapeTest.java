package test;

public class ShapeTest {
	public static void main(String[] args) {
		Rect rt1 = new Rect();
		
		rt1.setHeight(200);
		rt1.setWidth(30);
		
		System.out.println("�簢�� ���� : " + rt1.getHeight() + ", ���� : " + rt1.getWidth() + ", ���� : " + rt1.getArea() + "\n");
		
		Triangle tr1 = new Triangle(40, 35);
		
		System.out.println("�ﰢ�� ���� : " + tr1.getHeight() + ", �غ� : " + tr1.getWidth() + ", ���� : " + tr1.getArea() + "\n");
		
	}
}
