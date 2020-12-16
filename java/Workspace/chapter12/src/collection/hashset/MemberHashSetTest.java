package collection.hashset;

import collection.Member;

public class MemberHashSetTest {

	public static void main(String[] args) {
		MemberHashSet mhs = new MemberHashSet();
		
		Member ml = new Member(1001, "������");
		Member ms = new Member(1002, "�չα�");
		Member mp = new Member(1003, "�ڼ���");
		
		mhs.addMember(ml);
		mhs.addMember(ms);
		mhs.addMember(mp);
		mhs.showAllMember();
		
		Member mh = new Member(1003, "ȫ�浿");
		mhs.addMember(mh);
		mhs.showAllMember();
	}

}
