package test;

public class Rect {
	double height;
	double width;
	
	public Rect(double height, double width) {
		setHeight(height);
		setWidth(width);
	}
	
	
	public Rect() {}
	
	public double getArea() {
		return height*width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}
}
