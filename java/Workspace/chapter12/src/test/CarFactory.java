package test;

import java.util.HashMap;

public class CarFactory {
	private static CarFactory instance;
	static int carNum = 10000;
	private HashMap<String, Car> hashMap = new HashMap<String, Car>();
	Car car;
	CarFactory(){}
	
	public static CarFactory getInstance() {
		if(instance == null) {
			instance = new CarFactory();
		}
		return instance;
	}
	
	public Car createCar(String key) {
		Car car = null;
		if(!hashMap.containsKey(key)) {
			hashMap.put(key, new Car(key));
		}
		car = hashMap.get(key);
		carNum++;
		return car;
	}
}
