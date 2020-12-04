package test;

public abstract class Car {
	public abstract  void start();
	public abstract  void drive();
	public abstract  void stop();
	public abstract  void turnOff();
	public void run() {
		start();
		drive();
		stop();
		turnOff();
		washCar();
	}
	public void washCar() {
		System.out.println("세차를 합니다.");
	}
}
