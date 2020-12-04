package classpart;

public class Order {
	String orderNum, ID, date, name, address, goodsNum;
	public static void main(String[] args) {
		Order o = new Order();
		
		o.setOrderNum("201803120001");
		o.setID("abc123");
		o.setDate("2018년3월12일");
		o.setName("홍길순");
		o.setGoodsNum("PD0345-12");
		o.setAddress("서울시 영등포구 여의도동 20번지");
		System.out.println("주문 번호 : " + o.getOrderNum());
		System.out.println("주문자 아이디 : " + o.getID());
		System.out.println("주문 날짜 : " + o.getDate());
		System.out.println("주문자 이름 : " + o.getName());
		System.out.println("주문 상품 번호 : " + o.getGoodsNum());
		System.out.println("배송 주소 : " + o.getAddress());
		
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
