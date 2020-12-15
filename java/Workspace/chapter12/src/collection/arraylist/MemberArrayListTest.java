package collection.arraylist;

import collection.Member;

public class MemberArrayListTest {

	public static void main(String[] args) {
		MemberArrayList mal = new MemberArrayList();
		Member l = new Member(1001, "������");
		Member s = new Member(1002, "�չα�");
		Member p = new Member(1003, "�ڼ���");
		Member h = new Member(1004, "ȫ�浿");
		
		mal.addMember(l);
		mal.addMember(s);
		mal.addMember(p);
		mal.addMember(h);
		mal.insertMember(l, 1);
		mal.showAllMember();
		mal.removeMember(h.getMemberID());
		mal.showAllMember();
	}
}