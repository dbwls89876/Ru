package example;

public class Shape {
	protected int x, y;
	protected int width, height;
	final double PI = 3.14159;
	
	public Shape() {}
	
	public Shape(int w, int h){
		this.width = w;
		this.height = h;
	}
	public Shape(int x, int y, int w, int h){
		this.x = x;
		this.y = y;
		this.width = w;
		this.height = h;
	}

	public void showInfo() {
		System.out.println("������ x��ǥ : " + x 
				+ ", y��ǥ : " + y + ", ���� : " + width + ", ���� : " + height);
	}
	
	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

	public int getWidth() {
		return width;
	}

	public void setWidth(int width) {
		this.width = width;
	}

	public int getHeight() {
		return height;
	}

	public void setHeight(int height) {
		this.height = height;
	}
	
	public double getArea() {
		return 0;
	}
}