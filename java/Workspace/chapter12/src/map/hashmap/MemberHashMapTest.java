package map.hashmap;

import collection.Member;

public class MemberHashMapTest {

	public static void main(String[] args) {
		MemberHashMap mhm = new MemberHashMap();
		
		Member ml = new Member(1001, "ÀÌÁö¿ø");
		Member ms = new Member(1002, "¼Õ¹Î±¹");
		Member mp = new Member(1003, "¹Ú¼­ÈØ");
		Member mh = new Member(1004, "È«±æµ¿");
		
		mhm.addMember(ml);
		mhm.addMember(ms);
		mhm.addMember(mp);
		mhm.addMember(mh);
		
		mhm.showAllMember();
		
		mhm.removeMember(1004);
		mhm.showAllMember();
	}

}
