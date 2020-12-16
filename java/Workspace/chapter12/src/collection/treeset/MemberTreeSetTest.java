package collection.treeset;

import collection.Member;

public class MemberTreeSetTest {

	public static void main(String[] args) {
		MemberTreeSet mts = new MemberTreeSet();
		
		Member mp = new Member(1003, "¹Ú¼­ÈØ");
		Member ml = new Member(1001, "ÀÌÁö¿ø");
		Member ms = new Member(1002, "¼Õ¹Î±¹");
		
		mts.addMember(ml);
		mts.addMember(ms);
		mts.addMember(mp);
		mts.showAllMember();
		
		Member mh = new Member(1003, "È«±æµ¿");
		mts.addMember(mh);
		mts.showAllMember();
	}

}
