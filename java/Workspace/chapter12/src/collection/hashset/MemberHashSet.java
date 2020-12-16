package collection.hashset;

import java.util.HashSet;
import java.util.Iterator;

import collection.Member;

public class MemberHashSet {
	private HashSet<Member> HashSet;
	
	public MemberHashSet() {
		HashSet = new HashSet<Member>();
	}
	
	public void addMember(Member member) {
		HashSet.add(member);
	}
	public boolean removeMember(int memberID) {
		Iterator<Member> ir = HashSet.iterator();
		
		while(ir.hasNext()) {
			Member member = ir.next();
			int tempID = member.getMemberID();
			if(tempID == memberID) {
				HashSet.remove(member);
				return true;
			}
		}
		System.out.println(memberID + "�� �������� �ʽ��ϴ�.");
		return false;
	}
	
	public void showAllMember() {
		for(Member member : HashSet) {
			System.out.println(member);
		}
		System.out.println();
	}
}

