package test;

public class PhoneBook {
	private String name;
	private String address;
	private String phoneNum;
	
	public PhoneBook(String name, String address, String phoneNum) {
		setName(name);
		setAddress(address);
		setPhoneNum(phoneNum);
	}
	
	public PhoneBook() {}
	
	public void showInfo() {
		System.out.println("이름 : " + name);
		System.out.println("전화번호 : " + phoneNum);
		System.out.println("주소 : " + address+"\n");
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	public String getPhoneNum() {
		return phoneNum;
	}
	public void setPhoneNum(String phoneNum) {
		this.phoneNum = phoneNum;
	}
	
}
