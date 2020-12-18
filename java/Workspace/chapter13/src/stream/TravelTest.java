package stream;

import java.util.ArrayList;
import java.util.List;

public class TravelTest {

	public static void main(String[] args) {
		TravelCustomer cl = new TravelCustomer("�̼���", 40, 100);
		TravelCustomer ck = new TravelCustomer("������", 20, 100);
		TravelCustomer ch = new TravelCustomer("ȫ�浿", 13, 50);
		List<TravelCustomer> customerList = new ArrayList<>();
		customerList.add(cl);
		customerList.add(ck);
		customerList.add(ch);
		
		System.out.println("== �� ��� �߰��� ������� ��� ==");
		customerList.stream().map(c -> c.getName()).forEach(s -> System.out.println(s));
		
		int total = customerList.stream().mapToInt(c->c.getPrice()).sum();
		
		System.out.println("== 20�� �̻� �� ��� �����Ͽ� ���");
		customerList.parallelStream().filter(c -> c.getAge() >= 20).map(c-> c.getName()).sorted().forEach(s->System.out.println(s));
	}

}
