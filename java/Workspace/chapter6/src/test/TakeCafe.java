package test;

public class TakeCafe {
	public static void main(String[] args) {
		Cafe star = new Cafe("���ٹ�", "�Ƹ޸�ī��");
		Cafe cong = new Cafe("��ٹ�", "��");
		
		Person lee = new Person("�̾�", 20000);
		Person kim = new Person("�达", 20000);
		
		lee.takeCoffee(star, 4000);
		System.out.println("�̾��� ���� ��Ȳ : " + lee.getMoney());
		System.out.println(star.getShopName() + "�� �մ��� " + star.getCustmerCnt() + "���̰� ������ " + star.getMoney() + "�Դϴ�.");
	}
}
