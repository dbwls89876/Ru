package test;

public class Card {
	private String cardNum;
	private String name;
	
	public void setCardNum(String cardNum) {
		this.cardNum = cardNum;
	}
	public String getCardNum() {
		return cardNum.substring(0, 4)
				+"-"+cardNum.substring(4, 8)
				+"-"+cardNum.substring(8, 12)
				+"-"+cardNum.substring(12);
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	
	
}
