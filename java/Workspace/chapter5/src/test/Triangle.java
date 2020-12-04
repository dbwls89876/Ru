package test;

public class Triangle {
	double height;
	double width;
	
	public Triangle(double height, double width) {
		setHeight(height);
		setWidth(width);
	}
	
	public double getArea() {
		return (height*width)/2;
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
