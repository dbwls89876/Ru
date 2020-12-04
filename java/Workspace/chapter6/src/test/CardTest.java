package test;

public class CardTest {
	public static void main(String[] args) {
		CardCompany cc = CardCompany.getInstance("삼성화재");
		System.out.println("카드회사 : " + cc.getCompanyName());
		
		cc.createCard("강아지");
		System.out.println(cc.card.getName() +
		" 카드번호 : " + cc.card.getCardNum());
	
		CardCompany cc2 = CardCompany.getInstance("삼성화재");
		cc.createCard("고양이");
		System.out.println(cc.card.getName() +
		" 카드번호 : "+cc.card.getCardNum());

	}
}
