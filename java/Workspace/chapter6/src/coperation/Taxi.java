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
		System.out.println(tNum + "�� �°��� "
				+ passengerCount + "���̰�, ������ " + money + "�� �Դϴ�.");
	}
}
