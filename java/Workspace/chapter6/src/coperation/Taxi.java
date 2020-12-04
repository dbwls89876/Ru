package coperation;

public class Taxi {
	String tNum;
	int money, passengerCount;
			
	public Taxi(String tNum){
		this.tNum = tNum;
	}
	
	public void take(int money) {
		this.money = money;
		passengerCount++;
	}
	
	public void showInfo() {
		System.out.println(tNum + "의 승객은 "
				+ passengerCount + "명이고, 수입은 " + money + "원 입니다.");
	}
}
