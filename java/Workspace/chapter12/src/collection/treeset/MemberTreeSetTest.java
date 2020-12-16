package collection.treeset;

import collection.Member;

public class MemberTreeSetTest {

	public static void main(String[] args) {
		MemberTreeSet mts = new MemberTreeSet();
		
		Member mp = new Member(1003, "�ڼ���");
		Member ml = new Member(1001, "������");
		Member ms = new Member(1002, "�չα�");
		
		mts.addMember(ml);
		mts.addMember(ms);
		mts.addMember(mp);
		mts.showAllMember();
		
		Member mh = new Member(1003, "ȫ�浿");
		mts.addMember(mh);
		mts.showAllMember();
	}

}
