package codingTest;

import java.util.ArrayList;
import java.util.HashMap;

abstract class Bread{ // �� Ŭ���� �߻�ȭ
	public abstract void recipe(); // ���� ���� ������ �߻�ȭ

//	
//	public static Bread getBread(String breadType) {
//		
//		
//		switch(breadType) {
//			case "Cream":
//				return new Cream(breadType);
//			case "Sugar":
//				return new Sugar(breadType);
//			case "Butter":
//				return new Butter(breadType);
//			
//		
//		throw new IllegalArgumentException("�߸��� ���� �ԷµǾ����ϴ�.");
//	}
//	
	
}

class BreadFactory{
	final static HashMap<String, Bread> map = new HashMap<String, Bread>();
//	String breadType;
//	BreadFactory(String breadType){
//		this.breadType = breadType;
//	}
	static {
		map.put("cream", new Cream());
		map.put("sugar", new Sugar());
		map.put("butter", new Butter());
	}
	
	public static Bread createBread(String ingredient) {
		return map.get(ingredient);
	}
}

class Cream extends Bread{ // ũ���� Ŭ����
	String breadType = "cream";
	int flour = 100;
	int water = 100;
	int ingredient = 200;
	@Override
	
	public void recipe() { // ũ���� ������ ���
		// TODO Auto-generated method stub
		System.out.println("breadType: " + breadType);
		System.out.println("recipe");
		System.out.println("flour: " + flour);
		System.out.println("water: " + water);
		System.out.println("cream: " + ingredient);
	}
}

class Sugar extends Bread{ // ������ Ŭ����
	String breadType = "sugar";
	int flour = 100;
	int water = 50;
	int ingredient = 200;

	@Override
	public void recipe() { // ������ ������ ���
		// TODO Auto-generated method stub
		System.out.println("breadType: " + breadType);
		System.out.println("recipe");
		System.out.println("flour: " + flour);
		System.out.println("water: " + water);
		System.out.println("sugar: " + ingredient);
	}
}

class Butter extends Bread{ // ���ͻ� Ŭ����
	String breadType = "butter";
	int flour = 100;
	int water = 100;
	int ingredient = 50;

	@Override
	public void recipe() { // ���ͻ� ������ ���
		// TODO Auto-generated method stub
		System.out.println("breadType: " + breadType);
		System.out.println("recipe");
		System.out.println("flour: " + flour);
		System.out.println("water: " + water);
		System.out.println("butter: " + ingredient);
	}
}


public class first {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ArrayList<Bread> breadList = new ArrayList<Bread>(); // Bread ��ü�� ����Ʈ ����
		breadList.add(BreadFactory.createBread("cream")); // ũ���� �����
		breadList.add(BreadFactory.createBread("sugar")); // ������ �����
		breadList.add(BreadFactory.createBread("butter")); // ���ͻ� �����
		
		for(Bread bread:breadList) { // ������ �� ������ ���
			bread.recipe();
			System.out.println();
		}
	}
}
