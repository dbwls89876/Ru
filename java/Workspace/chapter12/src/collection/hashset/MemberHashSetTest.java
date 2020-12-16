package collection.hashset;

import collection.Member;

public class MemberHashSetTest {

	public static void main(String[] args) {
		MemberHashSet mhs = new MemberHashSet();
		
		Member ml = new Member(1001, "ÀÌÁö¿ø");
		Member ms = new Member(1002, "¼Õ¹Î±¹");
		Member mp = new Member(1003, "¹Ú¼­ÈØ");
		
		mhs.addMember(ml);
		mhs.addMember(ms);
		mhs.addMember(mp);
		mhs.showAllMember();
		
		Member mh = new Member(1003, "È«±æµ¿");
		mhs.addMember(mh);
		mhs.showAllMember();
	}

}
