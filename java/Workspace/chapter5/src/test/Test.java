package test;

public class Test {
	public static void main(String[] args) {
		PhoneBook addr1 = new PhoneBook();
		PhoneBook addr2 = new PhoneBook("�̼���", "010-2111-0222", "����");
		
		addr1.setName("������");
		addr1.setPhoneNum("010-7010-1010");
		addr1.setAddress("����");
		addr1.showInfo();
		addr2.showInfo();
				
	}
}
