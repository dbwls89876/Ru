package test;

import collection.Member;

class Car{
	String name;
	public Car() {}
	public Car(String name) {
		this.name = name;
	}
	
	@Override
	public String toString(){
		return name;
	}
	
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Car) {
			Car c = (Car)obj;
			if(this.name.equals(c.name)) {
				return true;
			}else
				return false;
		}
		return false;
	}
}

public class CarTest {

	public static void main(String[] args) {
		CarFactory factory = CarFactory.getInstance();
		Car sonata1 = factory.createCar("���� ��");
		Car sonata2 = factory.createCar("���� ��");
		System.out.println(sonata1);
		System.out.println(sonata2);
		System.out.println(sonata1 == sonata2);
		
		Car avante1 = factory.createCar("�¿� ��");
		Car avante2 = factory.createCar("�¿� ��");
		
		System.out.println(avante1 == avante2);
		System.out.println(sonata1 == avante1);
	}

	

}
