package test;

public class TakeCafe {
	public static void main(String[] args) {
		Cafe star = new Cafe("별다방", "아메리카노");
		Cafe cong = new Cafe("콩다방", "라떼");
		
		Person lee = new Person("이씨", 20000);
		Person kim = new Person("김씨", 20000);
		
		lee.takeCoffee(star, 4000);
		System.out.println("이씨의 지갑 현황 : " + lee.getMoney());
		System.out.println(star.getShopName() + "의 손님은 " + star.getCustmerCnt() + "명이고 수입은 " + star.getMoney() + "입니다.");
	}
}
