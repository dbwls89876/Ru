package test;

public class Person {
	private String name;
	private int money;
	public Person() {}
	
	public Person(String name, int money) {
		this.name = name;
		this.money = money;
	}

	public void takeCoffee(Cafe cafe, int money) {
		cafe.take(money);
		this.money-=money;
	}
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getMoney() {
		return money;
	}

	public void setMoney(int money) {
		this.money = money;
	}
	
}
