package test;

public class Cafe {
	private String shopName;
	private String coffeeName;
	private int customerCnt;
	private int money;
	
	public Cafe(String shopName, String coffeName) {
		this.shopName = shopName;
		this.coffeeName = coffeName;
		
	}

	public void take(int money) {
		this.money+=money;
		customerCnt++;
	}
	
	public String getShopName() {
		return shopName;
	}

	public void setShopName(String shopName) {
		this.shopName = shopName;
	}

	public String getCoffeeName() {
		return coffeeName;
	}

	public void setCoffeeName(String coffeeName) {
		this.coffeeName = coffeeName;
	}

	public int getCustmerCnt() {
		return customerCnt;
	}

	public void setCustmerCnt(int custmerCnt) {
		this.customerCnt = custmerCnt;
	}

	public int getMoney() {
		return money;
	}

	public void setMoney(int money) {
		this.money = money;
	}
	
}
