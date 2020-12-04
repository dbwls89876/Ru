package singleton;

public class CarFactory {
	private static CarFactory instance;
	static int carNum = 10000;
	Car car;
	CarFactory(){}
	
	public static CarFactory getInstance() {
		if(instance == null) {
			instance = new CarFactory();
		}
		return instance;
	}
	
	Car createCar() {
		Car car = new Car();
		carNum++;
		car.setCarNum(carNum);
		return car;
	}
}
