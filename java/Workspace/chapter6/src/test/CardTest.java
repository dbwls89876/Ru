package test;

public class CardTest {
	public static void main(String[] args) {
		CardCompany cc = CardCompany.getInstance("�Ｚȭ��");
		System.out.println("ī��ȸ�� : " + cc.getCompanyName());
		
		cc.createCard("������");
		System.out.println(cc.card.getName() +
		" ī���ȣ : " + cc.card.getCardNum());
	
		CardCompany cc2 = CardCompany.getInstance("�Ｚȭ��");
		cc.createCard("�����");
		System.out.println(cc.card.getName() +
		" ī���ȣ : "+cc.card.getCardNum());

	}
}
