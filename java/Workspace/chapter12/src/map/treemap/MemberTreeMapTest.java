package map.treemap;

import collection.Member;

public class MemberTreeMapTest {

	public static void main(String[] args) {
		MemberTreeMap mtm = new MemberTreeMap();
		
		Member ml = new Member(1001, "������");
		Member ms = new Member(1002, "�չα�");
		Member mp = new Member(1003, "�ڼ���");
		Member mh = new Member(1004, "ȫ�浿");
		
		mtm.addMember(mp);
		mtm.addMember(ms);
		mtm.addMember(ml);
		mtm.addMember(mh);
		
		mtm.showAllMember();
		
		mtm.removeMember(1004);
		mtm.showAllMember();
	}

}
