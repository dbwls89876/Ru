package codingTest;

import java.util.ArrayList;
import java.util.HashMap;

abstract class Bread{ // 빵 클래스 추상화
	public abstract void recipe(); // 빵을 만들 레시피 추상화

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
//		throw new IllegalArgumentException("잘못된 값이 입력되었습니다.");
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

class Cream extends Bread{ // 크림빵 클래스
	String breadType = "cream";
	int flour = 100;
	int water = 100;
	int ingredient = 200;
	@Override
	
	public void recipe() { // 크림빵 레시피 출력
		// TODO Auto-generated method stub
		System.out.println("breadType: " + breadType);
		System.out.println("recipe");
		System.out.println("flour: " + flour);
		System.out.println("water: " + water);
		System.out.println("cream: " + ingredient);
	}
}

class Sugar extends Bread{ // 설탕빵 클래스
	String breadType = "sugar";
	int flour = 100;
	int water = 50;
	int ingredient = 200;

	@Override
	public void recipe() { // 설탕빵 레시피 출력
		// TODO Auto-generated method stub
		System.out.println("breadType: " + breadType);
		System.out.println("recipe");
		System.out.println("flour: " + flour);
		System.out.println("water: " + water);
		System.out.println("sugar: " + ingredient);
	}
}

class Butter extends Bread{ // 버터빵 클래스
	String breadType = "butter";
	int flour = 100;
	int water = 100;
	int ingredient = 50;

	@Override
	public void recipe() { // 버터빵 레시피 출력
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
		ArrayList<Bread> breadList = new ArrayList<Bread>(); // Bread 객체의 리스트 생성
		breadList.add(BreadFactory.createBread("cream")); // 크림빵 만들기
		breadList.add(BreadFactory.createBread("sugar")); // 설탕빵 만들기
		breadList.add(BreadFactory.createBread("butter")); // 버터빵 만들기
		
		for(Bread bread:breadList) { // 각각의 빵 레시피 출력
			bread.recipe();
			System.out.println();
		}
	}
}
