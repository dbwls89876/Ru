package map.hashmap;

import collection.Member;

public class MemberHashMapTest {

	public static void main(String[] args) {
		MemberHashMap mhm = new MemberHashMap();
		
		Member ml = new Member(1001, "������");
		Member ms = new Member(1002, "�չα�");
		Member mp = new Member(1003, "�ڼ���");
		Member mh = new Member(1004, "ȫ�浿");
		
		mhm.addMember(ml);
		mhm.addMember(ms);
		mhm.addMember(mp);
		mhm.addMember(mh);
		
		mhm.showAllMember();
		
		mhm.removeMember(1004);
		mhm.showAllMember();
	}

}
