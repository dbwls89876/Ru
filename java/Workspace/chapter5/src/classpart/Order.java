package classpart;

public class Order {
	String orderNum, ID, date, name, address, goodsNum;
	public static void main(String[] args) {
		Order o = new Order();
		
		o.setOrderNum("201803120001");
		o.setID("abc123");
		o.setDate("2018��3��12��");
		o.setName("ȫ���");
		o.setGoodsNum("PD0345-12");
		o.setAddress("����� �������� ���ǵ��� 20����");
		System.out.println("�ֹ� ��ȣ : " + o.getOrderNum());
		System.out.println("�ֹ��� ���̵� : " + o.getID());
		System.out.println("�ֹ� ��¥ : " + o.getDate());
		System.out.println("�ֹ��� �̸� : " + o.getName());
		System.out.println("�ֹ� ��ǰ ��ȣ : " + o.getGoodsNum());
		System.out.println("��� �ּ� : " + o.getAddress());
		
	}
	public String getOrderNum() {
		return orderNum;
	}
	public void setOrderNum(String orderNum) {
		this.orderNum = orderNum;
	}
	public String getID() {
		return ID;
	}
	public void setID(String iD) {
		ID = iD;
	}
	public String getDate() {
		return date;
	}
	public void setDate(String date) {
		this.date = date;
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
	public String getGoodsNum() {
		return goodsNum;
	}
	public void setGoodsNum(String goodsNum) {
		this.goodsNum = goodsNum;
	}

}
