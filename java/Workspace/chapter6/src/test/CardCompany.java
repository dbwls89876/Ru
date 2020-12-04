package test;

public class CardCompany {
	private String companyName;
	public Card card;
	private static long serialNum = 1111222233334444L;
	private static CardCompany instance;
	private CardCompany(String companyName) {
		this.companyName = companyName; 
	}
	public static CardCompany getInstance(String companyName) {
		if(instance==null) {
			instance = new CardCompany(companyName);
		}
		return instance;
	}
	
	public Card createCard(String name) {
		card = new Card();
		card.setCardNum(String.valueOf(serialNum));
		card.setName(name);
		serialNum++;
		return card;
	}
	public String getCompanyName() {
		return companyName;
	}
	public void setCompanyName(String companyName) {
		this.companyName = companyName;
	}
}
