package singleton;

import java.util.HashMap;

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
	
	public Car createCar() {
		Car car = null;
		
		carNum++;
		return car;
	}
}
